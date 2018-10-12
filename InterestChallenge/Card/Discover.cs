namespace InterestChallenge.Card

{
    public class Discover : CardType
    {
        /// <summary>
        /// The interest rate.
        /// </summary>
        private readonly decimal rate = .01m;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:InterestChallenge.Card.Discover"/> class.
        /// </summary>
        /// <param name="balance">Balance.</param>
        public Discover(decimal balance)
        {
            InterestRate = rate;
            Balance = balance;
        }
    }
}
