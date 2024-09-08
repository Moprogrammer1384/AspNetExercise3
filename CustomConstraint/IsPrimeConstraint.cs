
using AspNetExercise3.CustomConstraint.Contracts;

namespace AspNetExercise3.CustomConstraint;

public class IsPrimeConstraint
    (IValueCheckerService valueChecker) : IRouteConstraint
{
    private readonly IValueCheckerService _valueChecker = valueChecker;

    public bool Match(
        HttpContext? httpContext,
        IRouter? route,
        string routeKey,
        RouteValueDictionary values,
        RouteDirection routeDirection)
    {
        var value = int.Parse(values[routeKey].ToString());

        return _valueChecker.IsPrimeNumber(value);        
    }
}
