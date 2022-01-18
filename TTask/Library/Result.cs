namespace TTask.Library
{
    public class Result<T, U>
    {
        public T Ok { get; }

        public bool IsOK { get; }

        public U Error { get; }

        public bool IsError { get; }

        public Result(T ok)
        {
            Ok = ok;
            IsOK = true;
        }

        public Result(U error)
        {
            Error = error;
            IsError = true;
        }
    }
}
