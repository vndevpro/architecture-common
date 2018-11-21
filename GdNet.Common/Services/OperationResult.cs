namespace GdNet.Common.Services
{
    public class OperationResult
    {
        /// <summary>
        /// Result of the operation
        /// </summary>
        public bool Result { get; set; }

        /// <summary>
        /// Output data returns by the operation
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// The message output of the operation. It could be error message if Result is false
        /// </summary>
        public string Message { get; set; }

        public OperationResult()
        {
        }

        public OperationResult(bool result)
        {
            Result = result;
        }
    }
}