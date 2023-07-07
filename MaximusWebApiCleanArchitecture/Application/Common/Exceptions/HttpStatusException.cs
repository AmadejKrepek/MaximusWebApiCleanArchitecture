namespace Application.Common.Exceptions
{
    public class HttpStatusException : Exception
    {
        public HttpStatusException(string message) : base(message)
        {

        }

        public HttpStatusException(string[] errors) : base("Multiple errors occurred. See error details.")
        {
            Errors = errors;
        }

        public string[] Errors { get; set; }
    }
}
