using System.IO;

namespace Design_Patterns.AdapterPattern.Day3
{
    public class AWSS3Storage
    {
        public void SaveDocument(string folderName, Stream stream)
        {

        }
        public Stream GetDocument(string folderName, string documentPath)
        {
            return new MemoryStream();
        }
        public void DeleteDocument(string folderName, string documentPath)
        {

        }
    }

    public class AWSS3StorageAdapter: AWSS3Storage, IDocumentStorageService
    {

        public void SaveFile(string folderName, Stream stream)
        {
            SaveDocument(folderName, stream);
        }
        public Stream GetFile(string folderName, string filePath)
        {
            return GetDocument(folderName, filePath);
        }
        public void DeleteFile(string folderName, string filePath)
        {
            DeleteDocument(folderName, filePath);
        }
    }
}
