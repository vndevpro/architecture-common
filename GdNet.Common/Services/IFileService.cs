namespace GdNet.Common.Services
{
    /// <summary>
    /// Simple file service
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Save the text into a file that is translated from virtual path
        /// </summary>
        OperationResult SaveFile(string virtualFilePath, string body);

        /// <summary>
        /// Get content of the file from its virtual path
        /// </summary>
        OperationResult GetFile(string virtualFilePath);
    }
}