using FileManagerLibrary;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {        
            ConsoleColor color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("FILEMANAGER\n (для вызова help нажмите F1)\n");
            
            Console.ForegroundColor = color;
            
            Help();
                        
            string currentDirectory = Directory.GetCurrentDirectory();

            while (true)
            {                
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine($"~You are in:\n~{currentDirectory}:");

                    Console.ForegroundColor = color;

                    string input = Console.ReadLine();

                    if (input.ToLowerInvariant() == "q")
                    {
                        break;
                    }                   

                    string[] inputArray = input.Split(" ");
                                        
                    switch (inputArray[0].ToLowerInvariant())
                    {
                        case "ls":
                            LS(inputArray, currentDirectory);
                            break;
                        case "cr":                            
                            Create(inputArray, currentDirectory);
                            break;
                        case "rm":
                            Remove(inputArray, currentDirectory);
                            break;
                        case "rn":
                            Rename(inputArray, currentDirectory);
                            break;
                        case "cp":
                            Copy(inputArray, currentDirectory);
                            break;
                        case "mv":
                            Move(inputArray, currentDirectory);
                            break;
                        case "size":
                            Size(inputArray, currentDirectory);
                            break;
                        case "find":
                            Find(inputArray, currentDirectory);
                            break;
                        case "info":
                            Info(inputArray, currentDirectory);
                            break;
                        case "cd":
                            currentDirectory = CD(inputArray, currentDirectory);                            
                            break;
                        default:
                            Console.WriteLine("Anknown command. See help.");
                            break;
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                                
            }
        }

        static void Help()
        {
            ConsoleColor color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"HELP
            Main Commads:
            ls - показать содержимое текущей папки или диска;
            cd <path/name> - переход в указанную директорую или папку в текущей директории;
            cr <name> - создать папку или файл в текущей директории;
            rm <name> - удалить папку или файл в текущей директории;
            rn <name of folder or file> <new name> - переименовать папку или файл в текущей директории;
            cp <name of folder or file> <to path> - копировать папку или файл из текущей директории в указанную директорию;
            mv <name of folder or file> <to path> - переместить папку или файл;            
            size <name> - информация о размере папки или файла в байтах;
            find <name> - поиск по маске;
            info <name> - статистические данные о текстовом файле (поддерживается только формат .txt);
            q - выход из программы.           
         Имена файлов должны быть указаны с расширением.
            ");

            Console.ForegroundColor = color;
        }

        //вывод содержимого папки или диска
        static void LS(string[] userInput, string currentDirectory)
        {
            if (userInput.Length > 1)
            {
                throw new Exception("Incorrect command. See help.");
            }

            Folder folder = new Folder();

            folder.DirectoryEntire(currentDirectory);

        }
        //переход в дргую папку
        static string CD(string[] userInput, string currentDirectory)
        {
            if (userInput.Length == 1)
            {
                throw new Exception("Enter folder or file name.");
            }

            currentDirectory = Path.Combine(currentDirectory, userInput[1]);

            if (!Directory.Exists(currentDirectory))
            {
                throw new Exception("Такой папки не существует.");
            };
            return currentDirectory;
        }

        //создание папки или файла
        static void Create(string[] userInput, string currentDirectory)
        {
            if (userInput.Length==1)
            {
                throw new Exception("Enter folder or file name.");
            }

            if (userInput.Length>2)
            {
                throw new Exception("Incorrect path.");
            }

            string pathToCreate = Path.Combine(currentDirectory, userInput[1]);

            if (Path.HasExtension(pathToCreate))
            {
                Files files = new Files();

                files.Create(pathToCreate);
            }
            else
            {
                Folder folder = new Folder();

                folder.Create(pathToCreate);
            }
        }
        //удаление папки или файла
        static void Remove(string[] userInput, string currentDirectory)
        {
            if (userInput.Length == 1)
            {
                throw new Exception("Enter folder or file name.");
            }

            if (userInput.Length > 2)
            {
                throw new Exception("Incorrect path.");
            }

            string pathToRemove = Path.Combine(currentDirectory, userInput[1]);

            if (Path.HasExtension(pathToRemove))
            {
                Files files = new Files();
                files.Delete(pathToRemove);
            }
            else
            {
                Folder folder = new Folder();
                folder.Delete(pathToRemove);
            }
        }
        //переименование папки или файла
        static void Rename(string[] userInput, string currentDirectory)
        {
            if (userInput.Length == 1)
            {
                throw new Exception("Enter folder or file name.");
            }

            if (userInput.Length > 3)
            {
                throw new Exception("Incorrect command input. See help.");
            }

            string pathToRename = Path.Combine(currentDirectory, userInput[1]);

            if (Path.HasExtension(pathToRename))
            {
                Files files = new Files();
                files.Rename(pathToRename, userInput[2]);
            }
            else
            {
                Folder folder = new Folder();
                folder.Rename(pathToRename, userInput[2]);
            }
        }
        //копирование папки или файла
        static void Copy(string[] userInput, string currentDirectory)
        {
            if (userInput.Length == 1)
            {
                throw new Exception("Enter folder or file name.");
            }

            if (userInput.Length > 3)
            {
                throw new Exception("Incorrect command input. See help.");
            }

            string pathToCopy = Path.Combine(currentDirectory, userInput[1]);

            if (Path.HasExtension(pathToCopy))
            {
                Files files = new Files();
                files.CopyFromTo(pathToCopy, userInput[2]);
            }
            else
            {
                Folder folder = new Folder();
                folder.Rename(pathToCopy, userInput[2]);
            }
        }
        //перемещение папки или файла
        static void Move(string[] userInput, string currentDirectory)
        {
            if (userInput.Length == 1)
            {
                throw new Exception("Enter folder or file name.");
            }

            if (userInput.Length > 3)
            {
                throw new Exception("Incorrect command input. See help.");
            }

            string pathToMove = Path.Combine(currentDirectory, userInput[1]);

            if (Path.HasExtension(pathToMove))
            {
                Files files = new Files();
                files.MoveFromTo(pathToMove, userInput[2]);
            }
            else
            {
                Folder folder = new Folder();
                folder.MoveFromTo(pathToMove, userInput[2]);
            }
        }
        //вывод размера папки или файла
        static void Size(string[] userInput, string currentDirectory)
        {
            if (userInput.Length == 1)
            {
                throw new Exception("Enter folder or file name.");
            }

            if (userInput.Length > 2)
            {
                throw new Exception("Incorrect path.");
            }

            string pathToSize = Path.Combine(currentDirectory, userInput[1]);

            if (Path.HasExtension(pathToSize))
            {
                Files files = new Files();
                files.GetSize(pathToSize);
            }
            else
            {
                Folder folder = new Folder();
                folder.GetSize(pathToSize);
            }
        }
        //поиск папки или файла в указанной директории
        static void Find(string[] userInput, string currentDirectory)
        {
            if (userInput.Length == 1)
            {
                throw new Exception("Enter folder or file name.");
            }

            if (userInput.Length > 2)
            {
                throw new Exception("Incorrect command. See help.");
            }
            
            if (Path.HasExtension(userInput[1]))
            {
                Files files = new Files();
                files.FindWithMask(currentDirectory, userInput[1]);
            }
            else
            {
                Folder folder = new Folder();
                folder.FindWithMask(currentDirectory, userInput[1]);
            }            
        }
        //вывод информации по текстовому файлу
        static void Info(string[] userInput, string currentDirectory)
        {
            if (userInput.Length == 1)
            {
                throw new Exception("Enter folder or file name.");
            }

            if (userInput.Length > 2)
            {
                throw new Exception("Incorrect command. See help.");
            }
            string infoPath = Path.Combine(currentDirectory, userInput[1]);

            TextFile file = new TextFile(infoPath);
            Console.WriteLine(@$"
Number of lines: {file.NumberOfLines};
Number of symbols including whitespace: {file.NumberOfSymbolsWithWhiteSpace};
Number of symbols exluding whitespace: {file.NumberOfSymbolsWithoutWhiteSpace};
Number of words: {file.NumberOfWords};
Number of paragraphs: {file.NumberOfParagraphs};
"); 
        }
    }
}