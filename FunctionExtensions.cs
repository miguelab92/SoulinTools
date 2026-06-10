using CSharpFunctionalExtensions;

namespace SoulinTools;

public static class FunctionExtensions
{
    public static Result<T> Try<T>(this Func<Result<T>> func)
    {
        try
        {
            return func();
        }
        catch (Exception ex)
        {
            return Result.Failure<T>(ex.Message);
        }
    }
}
