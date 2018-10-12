namespace InterestChallenge.Card
{
    public interface ICard : IInterestAccruable
    {   
        /// <summary>
        /// Gets or sets the interest rate.
        /// </summary>
        /// <value>The interest rate.</value>
        decimal InterestRate { get; set; }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>The balance.</value>
        decimal Balance { get; set; }
    }
}
