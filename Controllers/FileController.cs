using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sn_project_be.Core.Interfaces;
using sn_project_be.Core.Models.Files;

namespace sn_project_be.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FileController: ControllerBase
{
    private readonly IFileService _fileService;
    
    public FileController(IFileService fileService)
    {
        _fileService = fileService;
    }
    
    [Authorize]
    [Route("upload-profile-pic")]
    [HttpPost]
    public async Task<IActionResult> Upload([FromForm]FileModel model)
    {
        var imageUri = await  _fileService.UploadProfilePicture(model);
        return Ok(imageUri);
    }
}
