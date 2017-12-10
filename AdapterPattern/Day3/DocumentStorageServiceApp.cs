using System;
using System.IO;

namespace Design_Patterns.AdapterPattern.Day3
{
    public enum StorageTarget
    {
        Azure = 1,
        AWS,
        MongoDB
    }

    public static class DocumentStorageServiceApp
    {
        public static void Run()
        {
            Console.WriteLine("Welcome!");
            StorageTarget storageTarget;

            bool storageTargetSelected;
            do
            {
                Console.WriteLine("Please select storage type");
                Console.WriteLine("1.AWS");
                Console.WriteLine("2.Azure");
                Console.WriteLine("3.MongoDB");
                storageTargetSelected = Enum.TryParse(Console.ReadLine(), out storageTarget);
                if (!storageTargetSelected)
                {
                    Console.WriteLine("That's an invalid entry. Try again.");
                }
            }
            while (!storageTargetSelected);

            // Now we have created common interface IDocumentStorageService for document storage. And we have created adapter for each storage target which transforms calls from our common interface to particular storage target.

            // Still the issue is, we are using if else conditions to select adapter.
            IDocumentStorageService documentStorageService = new AWSS3StorageAdapter();
            if (storageTarget == StorageTarget.Azure)
            {
                documentStorageService = new AzureBlobStorageAdapter();
            }
            else if(storageTarget == StorageTarget.MongoDB)
            {
                documentStorageService = new MongoGridFSStorageAdapter();
            }
            documentStorageService.SaveFile("Personal Files", new MemoryStream());
            Console.WriteLine("File saved successfully");
            documentStorageService.DeleteFile("Personal Files", "file path");
            Console.ReadLine();
        }
    }
}
