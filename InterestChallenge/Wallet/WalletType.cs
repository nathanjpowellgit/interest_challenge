using System.Collections.Generic;
using InterestChallenge.Card;

namespace InterestChallenge.Wallet
{
    public class WalletType : IWallet
    {
        /// <summary>
        /// The cards in a wallet.
        /// </summary>
        /// <value>List of cards</value>
        public List<ICard> Cards { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:InterestChallenge.Wallet.WalletType"/> class.
        /// </summary>
        public WalletType()
        {
            Cards = new List<ICard>();
        }

        /// <summary>
        /// Adds the card.
        /// </summary>
        /// <returns>The wallet.</returns>
        /// <param name="card">Card.</param>
        public WalletType AddCard(ICard card)
        {
            Cards.Add(card);

            return this;
        }

        /// <summary>
        /// Calculates the total interest.
        /// </summary>
        /// <returns>The total interest.</returns>
        public decimal CalculateTotalInterest()
        {
            decimal totalInterest = 0;

            foreach (ICard card in Cards)
            {
                totalInterest += card.CalculateTotalInterest();
            }

            return totalInterest;
        }
    }
}
