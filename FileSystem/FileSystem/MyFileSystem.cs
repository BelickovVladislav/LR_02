﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileSystem.Interface;
using System.IO;

namespace FileSystem.FileSystem
{
    public class MyFileSystem : IDirectory, IFile, IVFS
    {
        private DirectoryInfo directory;
        private StreamReader reader;
        private FileInfo file;

        public DelegateManager.logCallHardCodeMethod logCallHardCodeMethod;

        public string openFile(string path)
        {
            logCallHardCodeMethod.Invoke(path);
            reader = new StreamReader(path);
            return reader.ReadToEnd();
        }

        public string getParentObject(string path)
        {
            directory = new DirectoryInfo(path);
            return directory.Parent.FullName;
        }

        string IVFSObject.getInfoObject(string path)
        {
            if (File.Exists(path))
            {
                file = new FileInfo(path);
                string info = "Это файл\n";
                info += generateInfo("имя", file.Name);
                info += generateInfo("полнео имя", file.FullName);
                info += generateInfo("время создания", file.CreationTime.ToString());
                info += generateInfo("только чтение", file.IsReadOnly.ToString());
            }
            if (Directory.Exists(path))
            {
                directory = new DirectoryInfo(path);
                string info = "Это папка\n";
                info += generateInfo("имя", directory.Name);
                info += generateInfo("полнео имя", directory.FullName);
                info += generateInfo("время создания", directory.CreationTime.ToString());
            }
            return "Ошибка чтения информации.";
        }

        private string generateInfo(string name, string value)
        {
            return name + ": " + value + "\n"; ;
        }

        public string getHomePath(string path)
        {
            directory = new DirectoryInfo(@"C:/");
            return directory.FullName;
        }

        public string getDriverName(string path)
        {
            return "инфа о драйверах файловой системы";
        }

        public string getFileSystemName(string path)
        {
            return "MyFileSystem";
        }

        public string getCodeFileName(string path)
        {
            file = new FileInfo(path);
            return "UTF-8";
        }

        public List<string> getListItems(string path)
        {
            directory = new DirectoryInfo(path);
            List<String> items = new List<String>();
            foreach (var dir in directory.GetDirectories())
            {
                items.Add(dir.Name);
            }
            foreach (var file in directory.GetFiles())
            {
                items.Add(file.Name);
            }
            return items;
        }
    }
}
