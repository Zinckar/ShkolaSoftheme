using System;
using System.IO;
using System.Runtime.InteropServices;

namespace FileHandler
{
    public struct FileHandle
    {


        public long FileSize { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }

        public FileAccessEnum FileAccessEnum { get; set; }

        public FileHandle(long fileSize, string fileName, string filePath, FileAccessEnum fileAccessEnum)
        {

            FileSize = fileSize;
            FileName = fileName;
            FilePath = filePath;
            FileAccessEnum = fileAccessEnum;
        }
        public FileHandle OpenForRead(string filePath)
        {
            var f = new FileInfo(filePath);

            return new FileHandle(f.Length, f.Name, f.FullName, FileAccessEnum.Read);
        }

        public FileHandle OpenForWrite(string filePath)
        {
            var f = new FileInfo(filePath);

            return new FileHandle(f.Length, f.Name, f.FullName, FileAccessEnum.Write);
        }

        public FileHandle OpenFile(string filePath)
        {
            var f = new FileInfo(filePath);
            
            return new FileHandle(f.Length, f.Name, f.FullName, FileAccessEnum.ReadWrite);
        }

        public override string ToString()
        {
            return $"Name of file: {FileName}, File path: {FilePath}, Size of file: {FileSize}";
        }
    }
}