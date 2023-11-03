using System.Runtime.Serialization;

namespace Examen.Operation
{
    public class CustomException : Exception
    {
        public int Status { get; set; }
        public string? Mensaje { get; set; }

        public CustomException()
                : base()
        {
        }

        public CustomException(string message)
            : base(message)
        {
        }

        public CustomException(string format, params object[] args)
            : base(string.Format(format, args))
        {
            Mensaje = format;
            var dato = args.ToList().FirstOrDefault();
            if (dato != null)
                Status = (int)dato;
        }

        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public CustomException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException)
        {
        }

        protected CustomException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
