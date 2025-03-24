
namespace Ordering.Domain.Exceptions
{
    internal class DomainException: Exception
    {
        public DomainException(string message):base($"domain exception: \"{message}\" throws from domain Layer")
        {
            
        }
    }
}
