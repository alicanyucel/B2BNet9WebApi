﻿namespace B2B.Core.Utilities.Result.Abstract;

public interface IResult
{
    public bool Success { get;  }
    public string Message {  get; }
}
