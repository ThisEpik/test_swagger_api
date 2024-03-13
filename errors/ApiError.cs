using System.Diagnostics.CodeAnalysis;

namespace test_swagger_api.errors
{
    [method: SetsRequiredMembers]
    public class ApiError(string message) : Exception
    {
        override
        public string Message { get;} = message;
    }
}
