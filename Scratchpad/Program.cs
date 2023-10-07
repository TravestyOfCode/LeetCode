using System;
using System.Collections.Generic;

namespace Scratchpad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Func<object> getStr = GetStr;
        }

        static object GetObj() { return null; }
        static string GetStr() { return ""; }
        
        public IResult GetInts()
        {
            return Result<IEnumerable<int>>.Ok();
        }
    }

    public interface IResult
    {
        public int StatusCode { get; }

        public bool WasSuccessful { get; }

        public object Value { get; }
    }

    public interface IResult<out T> : IResult
    {
        public new T Value { get; }
    }

    public class Result : IResult
    {
        public int StatusCode { get; protected set; }

        public bool WasSuccessful => StatusCode >= 200 && StatusCode <= 299;

        protected object _Value;
        public object Value => WasSuccessful ? _Value : throw new InvalidOperationException();

        protected Result(int statusCode)
        {
            StatusCode = statusCode;
        }

        protected Result(int statusCode, object value) : this(statusCode)
        {
            _Value = value;
        }

        public static Result Ok() => new Result(200);
        
    }

    public class Result<T> : Result, IResult<T>
    {
        protected new T _Value;
        public new T Value => WasSuccessful ? _Value : throw new InvalidOperationException();

        internal Result(int statusCode) : base(statusCode)
        {

        }

        internal Result(int statusCode, T value) : base(statusCode)
        {
            _Value = value;
        }

        public static new Result<T> Ok() => new Result<T>(200);
    }
}