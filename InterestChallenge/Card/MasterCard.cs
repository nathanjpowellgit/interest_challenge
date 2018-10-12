namespace InterestChallenge.Card
{
    public class MasterCard : CardType
    {
        /// <summary>
        /// The interest rate.
        /// </summary>
        private readonly decimal rate = .05m;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:InterestChallenge.Card.MasterCard"/> class.
        /// </summary>
        /// <param name="balance">Balance.</param>
        public MasterCard(decimal balance)
        {
            InterestRate = rate;
            Balance = balance;
        }
    }
}
