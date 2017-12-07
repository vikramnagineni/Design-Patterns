using System.IO;

namespace Design_Patterns.AdapterPattern.Day3
{
    public interface IDocumentStorageService
    {
        void SaveFile(string bucketName, Stream stream);
        Stream GetFile(string bucketName, string filePath);
        void DeleteFile(string bucketName, string filePath);
    }
}
