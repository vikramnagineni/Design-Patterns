using System.IO;

namespace Design_Patterns.AdapterPattern.Day2
{
    public interface IDocumentStorageService
    {
        void SaveFile(string bucketName, Stream stream);
        Stream GetFile(string bucketName, string filePath);
        void DeleteFile(string bucketName, string filePath);
    }
    // Now selecting storage service based on user selection happens in this file, which can be consumed across application.

    // Still these are the issues with the following code.
    // 1. Still we have if/else conditions in all methods. If one more target is added, we have to add one more if else condition in all methods.
    public class DocumentStorageService : IDocumentStorageService
    {
        public StorageTarget storageTarget { get; set; }
        public DocumentStorageService(StorageTarget _storageTarget)
        {
            storageTarget = _storageTarget;
        }

        public void SaveFile(string folderName, Stream stream)
        {
            if (storageTarget == StorageTarget.Azure)
            {
                var service = new AzureBlobStorage();
                service.SaveBlob(folderName, stream);
            }
            else if (storageTarget == StorageTarget.AWS)
            {
                var service = new AWSS3Storage();
                service.SaveDocument(folderName, stream);
            }
            else if (storageTarget == StorageTarget.MongoDB)
            {
                var service = new MongoGridFSStorage();
                service.SaveFile(folderName, stream);
            }
        }
        public Stream GetFile(string folderName, string filePath)
        {
            return new MemoryStream();
        }
        public void DeleteFile(string folderName, string filePath)
        {
            if (storageTarget == StorageTarget.Azure)
            {
                var service = new AzureBlobStorage();
                service.DeleteBlob(folderName, filePath);
            }
            else if (storageTarget == StorageTarget.AWS)
            {
                var service = new AWSS3Storage();
                service.DeleteDocument(folderName, filePath);
            }
            else if (storageTarget == StorageTarget.MongoDB)
            {
                var service = new MongoGridFSStorage();
                service.DeleteFile(folderName, filePath);
            }
        }
    }
}
