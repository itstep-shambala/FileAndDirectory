using System;
using System.IO;

namespace FileAndDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] discs = DriveInfo.GetDrives();
            foreach (DriveInfo disc in discs)
            {
                Console.Write($"{disc.Name} [{disc.VolumeLabel}] - ");
                Console.Write($"{disc.DriveFormat}, {disc.DriveType} ");
                Console.Write($"{disc.TotalSize}, {disc.TotalFreeSpace}");

                var files = Directory.GetFiles(disc.Name);
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }

                var directories = Directory.GetDirectories(disc.Name);
                foreach (var directoriy in directories)
                {
                    Console.WriteLine(directoriy);
                }
            }
        }
    }
}