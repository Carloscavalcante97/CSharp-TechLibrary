using System.Net;

namespace TechLibrary.Exception
{
    public class InvalidLoginException : TechLIbraryException
    {
        public override List<string> GetErrorMessages() => ["Invalid login"];

        public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;
    }
}
