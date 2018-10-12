namespace InterestChallenge.Card
{
    public abstract class CardType : ICard
    {
        /// <summary>
        /// Gets or sets the interest rate.
        /// </summary>
        /// <value>The interest rate.</value>
        public decimal InterestRate { get; set; }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>The balance.</value>
        public decimal Balance { get; set; }

        /// <summary>
        /// Calculates the total interest.
        /// </summary>
        /// <returns>The total interest.</returns>
        public decimal CalculateTotalInterest()
        {
            return InterestRate * Balance;
        }
    }
}
