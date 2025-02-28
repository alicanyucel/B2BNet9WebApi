namespace B2B.Core.Utilities.Result.Concrete;

public class SuccessDataResult<T> : DataResult<T>
{
    public SuccessDataResult(T data):base(data,true)
    {
        
    }
    public SuccessDataResult(T data, bool success, string message) : base(data, true, message)
    {
    }
    public SuccessDataResult():base(default,true) 
    {
        
    }
}
