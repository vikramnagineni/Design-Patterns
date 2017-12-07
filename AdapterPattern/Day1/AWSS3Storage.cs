using System.IO;

namespace Design_Patterns.AdapterPattern.Day1
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
}
