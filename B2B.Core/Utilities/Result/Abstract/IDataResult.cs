﻿namespace B2B.Core.Utilities.Result.Abstract;

public interface IDataResult<out T>:IResult
{
    T Data { get; }
}
