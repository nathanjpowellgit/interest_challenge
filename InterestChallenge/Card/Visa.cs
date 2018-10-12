namespace InterestChallenge.Card

{
    public class Visa : CardType
    {
        /// <summary>
        /// The interest rate.
        /// </summary>
        private readonly decimal rate = .10m;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:InterestChallenge.Card.Visa"/> class.
        /// </summary>
        /// <param name="balance">Balance.</param>
        public Visa(decimal balance)
        {
            InterestRate = rate;
            Balance = balance;
        }
    }
}
