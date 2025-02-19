using System.Net;

namespace TechLibrary.Exception;
    public class ErrorOnValidationException : TechLIbraryException
    {
    private readonly List<string> errors;
    public ErrorOnValidationException(List<string> errorMessages)
    {
        errors = errorMessages;
    }
    public override List<string> GetErrorMessages()
        {
        return errors;
        }

        public override HttpStatusCode GetStatusCode()=> HttpStatusCode.InternalServerError;
    }

