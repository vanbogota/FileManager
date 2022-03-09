namespace FileManagerLibrary
{
    interface IItem
    {      
        void Create(string path);
        void Delete(string path);
        void Rename(string path,string newName);
        void CopyFromTo(string fromPath, string toPath);
        void MoveFromTo(string fromPath, string toPath);
        void GetSize(string path);
        void FindWithMask(string path, string mask);

    }
}
