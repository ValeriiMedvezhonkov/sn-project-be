using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using sn_project_be.Core.Interfaces;
using sn_project_be.Core.Models.Files;
using sn_project_be.Data;

namespace sn_project_be.Core.Repository;

public class FileService : IFileService
{
    private readonly BlobServiceClient _blobServiceClient;
    
    public FileService(BlobServiceClient blobServiceClient)
    {
        _blobServiceClient = blobServiceClient;
    }
    
    public async Task<string> UploadProfilePicture(FileModel fileModel)
    {
        var blobContainer = _blobServiceClient.GetBlobContainerClient("profile-pic");
 
        var blobClient = blobContainer.GetBlobClient(FileHelper.GetUniqueFileName(fileModel.ImageFile.FileName));
        await blobClient.UploadAsync(fileModel.ImageFile.OpenReadStream(), new BlobHttpHeaders { ContentType = fileModel.ImageFile.ContentType });
        return blobClient.Uri.AbsoluteUri;
    }
}