namespace All4Auto.Core.Exceptions
{
    public class All4AutoException : ApplicationException
    {
        public All4AutoException()
        {
                
        }

        public All4AutoException(string errorMessage)
            : base(errorMessage)
        {

        }
    }
}
