using System;

namespace InterestChallenge
{
    public interface IInterestAccruable
    {
        /// <summary>
        /// Calculates the total interest.
        /// </summary>
        /// <returns>The total interest.</returns>
        decimal CalculateTotalInterest();
    }
}
