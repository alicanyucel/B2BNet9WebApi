﻿

namespace B2B.Core.Utilities.Result.Concrete;

public class ErrorResult : Result
{
    public ErrorResult() : base(false)
    {

    }
    public ErrorResult(string message) : base(false, message)
    {
    }
}
