using System.Runtime.Serialization;

namespace Pronia.Buisness.Exceptions;

public class FileTypeException:Exception
{
    public FileTypeException(string message): base(message)
    {
        
    }

    protected FileTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
