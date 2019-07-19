using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger.Models.IOManagement
{
    public class IoManager : IIOManager
    {
        private string currentPath;
        private string currentDirectory;
        private string currentFile;

        public IoManager()
        {
            this.currentPath = this.GetCurrentPath();
        }
        public IoManager(string currentDirectory, string currentFile)
            : this()
        {
            this.currentDirectory = currentDirectory;
            this.currentFile = currentFile;
        }

        public string CurrentDirectoryPath => 
            this.currentPath + this.currentDirectory;

        public string CurrentFilePath => 
            this.CurrentDirectoryPath + this.currentFile;

        public void EnsureDirectoryAndFileExist()
        {
            if (!Directory.Exists(this.CurrentDirectoryPath))
            {
                Directory.CreateDirectory(this.CurrentDirectoryPath);
            }

            File.WriteAllText(this.CurrentFilePath, "");
        }

        public string GetCurrentPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
