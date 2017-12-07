using System;
using System.IO;

namespace Design_Patterns.AdapterPattern.Day1
{
    public enum StorageTarget
    {
        Azure = 1,
        AWS,
        MongoDB
    }

    public static class DocumentStorageServiceApp
    {
        // Assume that in your organization,  different teams developed apis to store documents to various targets like Azure, AWS, MongoDB. Now, in your project you are required to save documents to different targets based on user configuration.

        // These are the issues with the following code.
        // 1. Everytime, we use api method, we are creating if/else conditions. And we have to do it in entire application whereever we consume api
        // 2. If a new type of storage target is added, we need to add one more else condition in all places, which is against open/closed principle.
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

            if (storageTarget == StorageTarget.Azure)
            {
                var service = new AzureBlobStorage();
                service.SaveBlob("Personal Files", new MemoryStream());
            }
            else if (storageTarget == StorageTarget.AWS)
            {
                var service = new AWSS3Storage();
                service.SaveDocument("Personal Files", new MemoryStream());
            }
            else if (storageTarget == StorageTarget.MongoDB)
            {
                var service = new MongoGridFSStorage();
                service.SaveFile("Personal Files", new MemoryStream());
            }

            Console.WriteLine("File saved successfully");

            if (storageTarget == StorageTarget.Azure)
            {
                var service = new AzureBlobStorage();
                service.DeleteBlob("Personal Files", "blob path");
            }
            else if (storageTarget == StorageTarget.AWS)
            {
                var service = new AWSS3Storage();
                service.DeleteDocument("Personal Files", "document path");
            }
            else if (storageTarget == StorageTarget.MongoDB)
            {
                var service = new MongoGridFSStorage();
                service.DeleteFile("Personal Files", "file path");
            }

            Console.ReadLine();
        }
    }
}
