using System;

namespace Module_8_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDiskObjectsCount(); //   Вызов метода получения директорий
        }

        static void GetDiskObjectsCount()
        {
            DriveInfo[] drives = DriveInfo.GetDrives(); // Получаем массив дисков

            foreach (var item in drives)
            {
                DirectoryInfo[] dirs = item.RootDirectory.GetDirectories(); // Получаем массив каталогов на диске
                FileInfo[] files = item.RootDirectory.GetFiles(); // Получаем массив файлов на диске
                Console.WriteLine($"Общее количество каталогов и файлов на диске {item}: {dirs.Length + files.Length}");
            }
        }
    }
}