namespace ExceptionHandling
{
    internal class BaseErrorResponse
    {
        public BaseErrorResponse()
        {
        }
        public BaseErrorResponse(string message)
        {
            Errors = new List<string> { message };
            this.Message = message;
        }

        public bool HasError => Errors.Any();
        public List<string> Errors { get; set; }
        public string Message { get; set; }
        public long Total { get; set; }
        public object Data { get; set; }
    }
}