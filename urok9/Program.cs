using System;
using System.IO;
using System.Text;
string root = @"C:\Users\video\Desktop\seminar\urok9\";
DirectoryInfo directory = new DirectoryInfo(root);
FileInfo fileInfo = new FileInfo(root + "MyFile.txt");
FileStream fs = fileInfo.Create();
FileInfo[] files = directory.GetFiles();
foreach (FileInfo file in files)
{
    fs.Write(Encoding.UTF8.GetBytes(file.FullName.ToString() + "\n"));
    fs.Write(Encoding.UTF8.GetBytes(file.CreationTime.ToString() + "\n"));
    fs.Write(Encoding.UTF8.GetBytes(file.LastAccessTime.ToString() + "\n"));
    fs.Write(Encoding.UTF8.GetBytes(file.LastWriteTime.ToString() + "\n"));
    fs.Write(Encoding.UTF8.GetBytes(file.Length.ToString() + "\n"));
    fs.Write(Encoding.UTF8.GetBytes(file.Name.ToString() + "\n"));
    fs.Write(Encoding.UTF8.GetBytes(file.DirectoryName.ToString() + "\n"));
    fs.Write(Encoding.UTF8.GetBytes("==========================================" + "\n"));
}

fs.Close();
