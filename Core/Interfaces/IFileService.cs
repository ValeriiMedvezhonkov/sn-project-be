using sn_project_be.Core.Models.Files;

namespace sn_project_be.Core.Interfaces;

public interface IFileService
{
    Task<string> UploadProfilePicture(FileModel fileModel);
}