﻿using AutoMapper;
using FluentValidation.Results;
using GalaxyExpress.BLL.DTOs.ParcelMachineDTOs;
using GalaxyExpress.BLL.Extensions;
using GalaxyExpress.BLL.Services.Interfaces;
using GalaxyExpress.BLL.Validators;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories.Interfaces;
using Microsoft.IdentityModel.Tokens;


#pragma warning disable

namespace GalaxyExpress.BLL.Services;

public class ParcelMachineService : IParcelMachineService
{
    private readonly IUnitOfWork unitOfWork;

    public ParcelMachineService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task<List<ParcelMachineInfoDto>> GetAllAsync(string? searchText)
    {
        IEnumerable<ParcelMachine>? parcelMachines = await unitOfWork.ParcelMachines.GetAllAsync();

        if (!searchText.IsNullOrEmpty())
        {
            parcelMachines = parcelMachines.Where(x => x.GlobalAddress.Contains(searchText) || x.LocalAddress.Contains(searchText));
        }

        return MapperConfiguration.CreateMapper()
            .Map<List<ParcelMachineInfoDto>>(parcelMachines);
    }

    public async Task<ServerResponse> DeleteAsync(Guid id)
    {
        await unitOfWork.ParcelMachines.DeleteAsync(id);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse { Message = $"ParcelMachine with id: {id} has been removed successfully!", IsSuccess = true };
    }

    public async Task<ServerResponse> CheckExistenceByParametersAsync(int parcelMachineNumber, string globalAddress, string localAddress)
    {
        ParcelMachine? parcelMachine = await unitOfWork.ParcelMachines
            .CheckExistenceByParametersAsync(parcelMachineNumber, globalAddress, localAddress);

        if (parcelMachine is null)
        {
            return new ServerResponse { Message = $"ParcelMachine with the given parameters does not exist!", IsSuccess = false };
        }

        return new ServerResponse { Message = $"ParcelMachine with the given parameters already exists!", IsSuccess = true };
    }

    public async Task<ServerResponse> AddAsync(AddParcelMachineDto addParcelMachineDTO)
    {
        AddParcelMachineValidator validator = new();
        ValidationResult validationResult = await validator.ValidateAsync(addParcelMachineDTO);

        if (!validationResult.IsValid)
        {
            string errors = validationResult.ToString("~");

            return new ServerResponse
            {
                Message = "Something went wrong... all errors are in [Errors] list!",
                IsSuccess = false,
                Errors = errors.Split('~')
            };
        }

        ParcelMachine? parcelMachine = null;

        parcelMachine = await unitOfWork.ParcelMachines
            .CheckExistenceByParametersAsync(addParcelMachineDTO.ParcelMachineNumber, addParcelMachineDTO.GlobalAddress,
            addParcelMachineDTO.LocalAddress);

        if (parcelMachine is not null)
        {
            return new ServerResponse { Message = $"ParcelMachine with the given parameters already exists!", IsSuccess = false };
        }

        parcelMachine = new()
        {
            ParcelMachineId = Guid.NewGuid(),
            ParcelMachineNumber = addParcelMachineDTO.ParcelMachineNumber,
            LocalAddress = addParcelMachineDTO.LocalAddress,
            GlobalAddress = addParcelMachineDTO.GlobalAddress,
            Coordinates = $"{addParcelMachineDTO.X};{addParcelMachineDTO.Y}"
        };

        await unitOfWork.ParcelMachines.CreateAsync(parcelMachine);

        await unitOfWork.SaveChangesAsync();

        return new ServerResponse { Message = "ParcelMachine has been added in the database!", IsSuccess = true };
    }

    private static MapperConfiguration MapperConfiguration
    {
        get => new(config =>
        {
            config.CreateMap<ParcelMachine, ParcelMachineInfoDto>()
            .ForMember(dest => dest.X, opt => opt.MapFrom(src =>
            float.Parse(src.Coordinates.Substring(0, src.Coordinates.IndexOf(';')))))
            .ForMember(dest => dest.Y, opt => opt.MapFrom(src =>
            float.Parse(src.Coordinates.Substring(src.Coordinates.IndexOf(';') + 1))));
        });
    }
}