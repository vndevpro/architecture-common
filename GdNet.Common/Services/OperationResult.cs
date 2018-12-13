namespace GdNet.Common.Services
{
    /// <summary>
    /// Represent result of an operation
    /// </summary>
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

        /// <summary>
        /// Instantiate an instance with result to false
        /// </summary>
        public OperationResult()
            : this(false)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public OperationResult(bool result)
        {
            Result = result;
        }
    }
}
