using System;
using System.IO;

namespace GdNet.Common.Services
{
    public class SimpleFileService : IFileService
    {
        private readonly string _rootFolder;

        public SimpleFileService(string rootFolder)
        {
            _rootFolder = rootFolder;
        }

        public OperationResult SaveFile(string virtualFilePath, string body)
        {
            try
            {
                var filePath = Path.Combine(_rootFolder, virtualFilePath);

                File.WriteAllText(filePath, body);

                return new OperationResult(true);
            }
            catch (Exception ex)
            {
                return new OperationResult(false)
                {
                    Message = ex.Message
                };
            }
        }

        public OperationResult GetFile(string virtualFilePath)
        {
            var filePath = Path.Combine(_rootFolder, virtualFilePath);

            if (File.Exists(filePath))
            {
                return new OperationResult(true)
                {
                    Data = File.ReadAllText(filePath),
                };
            }

            return new OperationResult(false)
            {
                Message = "File does not exist"
            };
        }
    }
}