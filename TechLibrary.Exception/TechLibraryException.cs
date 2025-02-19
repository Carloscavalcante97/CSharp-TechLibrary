using System.Net;

namespace TechLibrary.Exception
{
    public abstract class TechLIbraryException : SystemException
    {
        public abstract List<string> GetErrorMessages();
        public abstract HttpStatusCode GetStatusCode();
    }
}
