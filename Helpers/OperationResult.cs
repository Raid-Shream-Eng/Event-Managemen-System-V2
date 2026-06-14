namespace Event_Management_System_V._2.Helpers
{
    public class OperationResult
    {
        public bool Sucess { get; private set; }
        public string Message { get; private set; } = string.Empty;
        public static OperationResult Ok(string message = "")
        {
            return new OperationResult
            {
                Sucess = true,
                Message = message
            };
        }
        public static OperationResult fail(string message)
        {
            return new OperationResult
            {
                Sucess = false,
                Message = message
            };
        }
    }
}
