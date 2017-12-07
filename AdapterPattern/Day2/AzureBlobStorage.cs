using System.IO;

namespace Design_Patterns.AdapterPattern.Day2
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
}
