using System.Collections.Generic;
using InterestChallenge.Card;

namespace InterestChallenge.Wallet
{
    public interface IWallet : IInterestAccruable
    {
        /// <summary>
        /// The cards in a wallet.
        /// </summary>
        /// <value>List of cards</value>
        List<ICard> Cards { get; set; }
    }
}
