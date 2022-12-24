namespace SalesWebMvc60.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string msg) : base(msg)
        {
        }
    }
}
