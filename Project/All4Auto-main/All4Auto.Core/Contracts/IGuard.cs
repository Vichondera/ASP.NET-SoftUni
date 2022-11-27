namespace All4Auto.Core.Constants
{
    public interface IGuard
    {
        void AgainstNull<T>(T value, string? errorMessage = null);
    }
}
