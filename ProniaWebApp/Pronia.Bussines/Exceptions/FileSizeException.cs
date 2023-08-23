using System.Runtime.Serialization;

namespace Pronia.Buisness.Exceptions;

public class FileSizeException:Exception
{
    public FileSizeException(string message):base(message)
    {
        
    }

    protected FileSizeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
