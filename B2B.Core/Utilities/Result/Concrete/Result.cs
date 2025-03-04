
using B2B.Core.Utilities.Result.Abstract;

namespace B2B.Core.Utilities.Result.Concrete;

public class Result : IResult
{
    public Result(bool success)
    {
        Success = success;
    }
    public Result(bool success,string message):this(success)
    {
        Message = message;
    }
    //
    public bool Success { get; } 
    public string Message { get; }
}
