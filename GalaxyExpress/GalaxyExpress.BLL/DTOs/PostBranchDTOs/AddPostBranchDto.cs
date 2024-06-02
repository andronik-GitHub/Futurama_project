namespace GalaxyExpress.BLL.DTOs.PostBranchDTOs;

public class AddPostBranchDto
{
    public int BranchNumber { get; set; }
    public string LocalAddress { get; set; } = default!;
    public string GlobalAddress { get; set; } = default!;
    public float X { get; set; }
    public float Y { get; set; }
}