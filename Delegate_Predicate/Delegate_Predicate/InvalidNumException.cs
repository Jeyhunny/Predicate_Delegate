using System.Runtime.Serialization;

[Serializable]
internal class InvalidNumException : Exception
{

    public InvalidNumException(string msg) : base(msg) { }
}