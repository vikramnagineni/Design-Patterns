using System;
using System.IO;

namespace Design_Patterns.AdapterPattern.Day2
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

            var service = new DocumentStorageService(storageTarget);
            service.SaveFile("Personal Files", new MemoryStream());
            Console.WriteLine("File saved successfully");
            service.DeleteFile("Personal Files", "file path");
            Console.ReadLine();
        }
    }
}
