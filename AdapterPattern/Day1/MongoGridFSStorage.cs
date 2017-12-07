using System.IO;

namespace Design_Patterns.AdapterPattern.Day1
{
    public class MongoGridFSStorage
    {
        public void SaveFile(string bucketName, Stream stream)
        {

        }
        public Stream GetFile(string bucketName, string filePath)
        {
            return new MemoryStream();
        }
        public void DeleteFile(string bucketName, string filePath)
        {

        }
    }
}
