namespace API.General.Classes
{ 
    /// <summary>
    /// Request structure
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Message´s ID
        /// </summary>
        public int IdMessage { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// Request structure
    /// </summary>
    public class RequestValue : Request
    {

        /// <summary>
        /// Value
        /// </summary>
        public string Value { get; set; }
    }
}
