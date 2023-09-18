using System.Runtime.Serialization;

namespace SportYar.Infrastructure.Base
{
    [Serializable]
    public class CommandValidationException : Exception
    {
        public CommandValidationException()
        {
        }

        public CommandValidationException(string message) : base(message)
        {
        }

        public CommandValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CommandValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public class ManagedException : Exception
    {

        public ManagedException(string errorMessage)
        {
            ErrorMessage = new List<string> { errorMessage };
        }

        public ManagedException(IEnumerable<string> errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public IEnumerable<string> ErrorMessage { get; }
    }
    [Serializable]
    public class LoopException : Exception
    {
        public LoopException()
        {
        }

        public LoopException(string message) : base(message)
        {
        }
    }
    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string message) : base(message)
        {
        }

        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
