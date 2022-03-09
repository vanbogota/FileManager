using System;
using System.IO;

namespace FileManagerLibrary
{
    public class Files : IItem
    {
        public void CopyFromTo(string fromPath, string toPath)
        {
            if (File.Exists(fromPath))
            {
                FileInfo fi = new FileInfo(fromPath);

                fi.CopyTo(Path.Combine(toPath, fi.Name));

                Console.WriteLine($"File {fromPath} copied");
            }
            else
            {
                Console.WriteLine($"File {fromPath} doesn't exists");
            }
            
        }

        public void Create(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                Console.WriteLine($"File {path} created");
            }
            else
            {
                Console.WriteLine($"File {path} already exist");
            }
        }

        public void Delete(string path)
        {            
            File.Delete(path);
            Console.WriteLine($"File {path} deleted");
        }

        public void FindWithMask(string path, string mask)
        {
            foreach (string file in Directory.GetFiles(path, mask, SearchOption.AllDirectories))
            {
                Console.WriteLine(file);
            }            
        }

        public void GetSize(string path) 
        {
                FileInfo temp = new FileInfo(path);

                Console.WriteLine($"The size of file {path} is {temp.Length} bytes");                                                    
        }

        public void MoveFromTo(string fromPath, string toPath)
        {            
            if (Directory.Exists(toPath))
            {
                FileInfo temp = new FileInfo(fromPath);
                temp.MoveTo(Path.Combine(toPath, temp.Name));
                Console.WriteLine($"File {fromPath} moved to {toPath}");
            }
            else
            {
                Console.WriteLine($"Folder {toPath} doesn't exists");
            }
        }

        public void Rename(string path, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("The Name can't be empty");
            }

            FileInfo temp = new FileInfo(path);

            temp.MoveTo(Path.Combine(temp.DirectoryName, newName));

            Console.WriteLine($"File {path} renamed.");
        }
    }
}
