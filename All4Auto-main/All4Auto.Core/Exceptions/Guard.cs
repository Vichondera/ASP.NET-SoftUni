namespace All4Auto.Core.Exceptions
{
    using All4Auto.Core.Constants;
    public class Guard : IGuard
    {
        public void AgainstNull<T>(T value, string? errorMessage = null)
        {
            if (value == null)
            {
                var exception = errorMessage == null ?
                    new All4AutoException() :
                    new All4AutoException(errorMessage);
                
                throw exception;
            }
        }
    }
}
