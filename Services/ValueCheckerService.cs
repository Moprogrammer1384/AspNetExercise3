using AspNetExercise3.CustomConstraint.Contracts;

namespace AspNetExercise3.Servies;

public class ValueCheckerService : IValueCheckerService
{
    public bool IsPrimeNumber(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
