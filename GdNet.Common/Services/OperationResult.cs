namespace GdNet.Common.Services
{
    /// <summary>
    /// Represent result of an operation with result default to object type
    /// </summary>
    public class OperationResult : OperationResult<object>
    {
        /// <summary>
        /// Instantiate an instance with result to false
        /// </summary>
        public OperationResult()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public OperationResult(bool result)
            : base(result)
        {
        }
    }

    /// <summary>
    /// Represent result of an operation
    /// </summary>
    public class OperationResult<T> where T : class
    {
        /// <summary>
        /// Result of the operation
        /// </summary>
        public bool Result { get; set; }

        /// <summary>
        /// Output data returns by the operation
        /// </summary>
        public T Data { get; set; }

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
