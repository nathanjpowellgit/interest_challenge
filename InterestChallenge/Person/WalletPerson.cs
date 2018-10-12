﻿using System.Collections.Generic;
using InterestChallenge.Wallet;

namespace InterestChallenge.Person
{
    public class WalletPerson : IPerson
    {
        /// <summary>
        /// The wallets that belong to a person.
        /// </summary>
        /// <value>List of wallets</value>
        public List<IWallet> Wallets { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:InterestChallenge.Person.WalletPerson"/> class.
        /// </summary>
        public WalletPerson()
        {
            Wallets = new List<IWallet>();
        }

        /// <summary>
        /// Adds a wallet.
        /// </summary>
        /// <returns>The wallet person.</returns>
        /// <param name="wallet">Wallet.</param>
        public WalletPerson AddWallet(IWallet wallet)
        {
            Wallets.Add(wallet);

            return this;
        }

        /// <summary>
        /// Calculates the total interest.
        /// </summary>
        /// <returns>The total interest.</returns>
        public decimal CalculateTotalInterest()
        {
            decimal totalInterest = 0.0m;

            foreach (WalletType wallet in Wallets)
            {
                totalInterest += wallet.CalculateTotalInterest();
            }

            return totalInterest;
        }
    }
}
