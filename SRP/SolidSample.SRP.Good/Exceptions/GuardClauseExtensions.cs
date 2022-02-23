using Ardalis.GuardClauses;

namespace SolidSample.SRP.Good.Exceptions
{
    public static class GuardClauseExtensions
    {
        public static string InvalidEmail(this IGuardClause guardClause, string input)
        {
            // Sample validation
            if (!input.Contains("@"))
            {
                throw new InvalidEmailException();
            }

            return input;
        }
    }
}
