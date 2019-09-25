using System;
namespace Skylight
{
    public class InvalidAsteroidParametersException : Exception
    {
        public InvalidAsteroidParametersException(string message)
            : base(message)
        { }
    }
}
