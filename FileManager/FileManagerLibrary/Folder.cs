using System;
using System.IO;

namespace FileManagerLibrary
{
    public class Folder : IItem
    {
        /// <summary>
        /// Копирование первой указанной директории во вторую указанную директорию. Пути надо указывать полностью.
        /// </summary>
        /// <param name="fromPath"></param>
        /// <param name="toPath"></param>
        public void CopyFromTo(string fromPath, string toPath)
        {
            if (Directory.GetParent(toPath).FullName == fromPath)
            {
                throw new Exception("Конечняя папка, в которую следует поместить файлы, является дочерней для папки, в котрой они находятся.");
            }

            DirectoryInfo diFromPath = new DirectoryInfo(fromPath);

            var newDir = Path.Combine(toPath, diFromPath.Name);

            Directory.CreateDirectory(newDir);

            foreach (var file in diFromPath.GetFiles())
            {
                file.CopyTo(Path.Combine(newDir, file.Name));
            }

            foreach (var dir in Directory.GetDirectories(fromPath))
            {                
                CopyFromTo(dir, newDir);
            }
        }            
        /// <summary>
        /// Создание необходимой директории. Путь надо указывать полностью
        /// </summary>
        /// <param name="path"></param>
        public void Create(string path)
        {
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Folder created");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                                    
            }
            else
            {
                Console.WriteLine("Folder exist");
            }
        }
        /// <summary>
        /// Удаление указанной директории. Путь надо указывать полностью
        /// </summary>
        /// <param name="path"></param>
        public void Delete(string path)
        {            
            if (Directory.Exists(path))
            {
                try
                {
                    Directory.Delete(path,true);
                    Console.WriteLine("Folder deleted");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Folder doesn't exist");
            }
        }
        /// <summary>
        /// Перенос первой указанной директории во вторую указанную директорию. Пути надо указывать полностью.
        /// </summary>
        /// <param name="fromPath"></param>
        /// <param name="toPath"></param>
        public void MoveFromTo(string fromPath, string toPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(fromPath);
            if (dirInfo.Exists)
            {
                try
                {
                    if (Directory.Exists(toPath))
                    {                        
                        string[] temp = fromPath.Split('\\');
                        dirInfo.MoveTo(Path.Combine(toPath, temp[temp.Length - 1]));
                        Console.WriteLine("Folder moved.");
                    }
                    else
                    {
                        Console.WriteLine($"Folder {toPath} doesn't exist");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                                
            }
            else
            {
                Console.WriteLine($"Folder {fromPath} doesn't exist");
            }
        }
        /// <summary>
        /// Переименовывает указанную директорию. Путь начальной директории надо указывать полность.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="newName"></param>
        public void Rename(string path, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("The Name can't be empty");
            }

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (dirInfo.Exists)
            {              
                try
                {
                    string[] regardFromPath = newName.Split('\\');
                    dirInfo.MoveTo(Path.Combine(dirInfo.Parent.FullName, regardFromPath[regardFromPath.Length - 1]));
                    
                    Console.WriteLine("Folder renamed.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Folder doesn't exist");
            }
        }
        /// <summary>
        /// Получение информации о размере папки. Путь нало указывать полностью.
        /// </summary>
        public virtual void GetSize(string path)
        {
            Console.WriteLine($"The size of {path} is " + GetSizeOfFolder(path) + " bytes");
        }
        /// <summary>
        /// Вывод списка папок и файлов в указанной директории (без рекурсии).
        /// </summary>
        /// <param name="path"></param>
        public void DirectoryEntire(string path)
        {
            string[] dirs = null;
            string[] files = null;

            if (Directory.Exists(path))
            {
                try
                {
                    dirs = Directory.GetDirectories(path);
                    files = Directory.GetFiles(path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }

                if (dirs != null)
                {
                    foreach (string directory in dirs)
                    {
                        DirectoryInfo nameOfDirectory = new DirectoryInfo(directory);
                        
                        Console.WriteLine($"\\{nameOfDirectory.Name}");
                    }
                    foreach (string fileDir in files)
                    {
                        Console.WriteLine(Path.GetFileName(fileDir));
                    }
                }
            }
            else
            {
                Console.WriteLine($"Directory \"{path}\" doesn't exist");
            }                
        }
        public void FindWithMask(string path, string mask)
        {
            foreach (string folder in Directory.GetDirectories(path, mask, SearchOption.AllDirectories))
            {
                Console.WriteLine(folder);
            }
        }
        private long GetSizeOfFolder(string path)
        {
            long folderSize = 0;

            foreach (string file in Directory.GetFiles(path))
            {
                FileInfo f = new FileInfo(file);
                folderSize += f.Length;
            }
            string[] subDirs = Directory.GetDirectories(path);

            foreach (string subDir in subDirs)
            {
                folderSize += GetSizeOfFolder(subDir);
            }
            return folderSize;
        }       
    }
}
