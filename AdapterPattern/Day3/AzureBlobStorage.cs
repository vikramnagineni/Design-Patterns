using System.IO;

namespace Design_Patterns.AdapterPattern.Day3
{
    public class AzureBlobStorage
    {
        public void SaveBlob(string containerName, Stream stream)
        {

        }
        public Stream GetBlob(string containerName, string blobPath)
        {
            return new MemoryStream();
        }
        public void DeleteBlob(string containerName, string blobPath)
        {

        }
    }

    public class AzureBlobStorageAdapter : AzureBlobStorage, IDocumentStorageService
    {

        public void SaveFile(string folderName, Stream stream)
        {
            SaveBlob(folderName, stream);
        }
        public Stream GetFile(string folderName, string filePath)
        {
            return GetBlob(folderName, filePath);
        }
        public void DeleteFile(string folderName, string filePath)
        {
            DeleteBlob(folderName, filePath);
        }
    }
}
