﻿namespace GalaxyExpress.BLL.Extensions;

public class ServerResponse
{
    public string? Message { get; set; }
    public bool IsSuccess { get; set; }
    public IEnumerable<string>? Errors { get; set; }
}