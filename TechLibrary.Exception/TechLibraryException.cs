using System.Net;

namespace TechLibrary.Exception
{
    public abstract class TechLibraryException : SystemException
    {
        protected TechLibraryException(string message) : base(message) 
        {
        
        }
  
        public abstract List<string> GetErrorMessages();
        public abstract HttpStatusCode GetStatusCode();
    }
}
