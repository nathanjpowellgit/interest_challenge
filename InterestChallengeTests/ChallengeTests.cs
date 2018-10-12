using System;
using InterestChallenge.Card;
using InterestChallenge.Person;
using InterestChallenge.Wallet;
using Xunit;

namespace InterestChallengeTests
{
    public class ChallengeTests
    {
        /// <summary>
        /// The first challenge test case.
        /// </summary>
        [Fact]
        public void TestCaseOne()
        {
            Discover discover = new Discover(100m);
            MasterCard mastercard = new MasterCard(100m);
            Visa visa = new Visa(100m);

            WalletType wallet = new WalletType();
            wallet.AddCard(discover)
                  .AddCard(mastercard)
                  .AddCard(visa);

            WalletPerson person = new WalletPerson();
            person.AddWallet(wallet);

            Assert.Equal(1m, discover.CalculateTotalInterest());
            Assert.Equal(5m, mastercard.CalculateTotalInterest());
            Assert.Equal(10m, visa.CalculateTotalInterest());
            Assert.Equal(16m, person.CalculateTotalInterest());
        }

        /// <summary>
        /// The second challenge test case.
        /// </summary>
        [Fact]
        public void TestCaseTwo()
        {
            Discover discover = new Discover(100m);
            MasterCard masterCard = new MasterCard(100m);
            Visa visa = new Visa(100m);

            WalletType wallet1 = new WalletType();
            wallet1.AddCard(discover)
                   .AddCard(visa);

            WalletType wallet2 = new WalletType();
            wallet2.AddCard(masterCard);

            Assert.Equal(11m, wallet1.CalculateTotalInterest());
            Assert.Equal(5m, wallet2.CalculateTotalInterest());
        }

        /// <summary>
        /// The third challenge test case.
        /// </summary>
        [Fact]
        public void TestCaseThree()
        {
            MasterCard person1MasterCard1 = new MasterCard(100m);
            MasterCard person1MasterCard2 = new MasterCard(100m);

            WalletType person1Wallet = new WalletType();
            person1Wallet.AddCard(person1MasterCard1)
                         .AddCard(person1MasterCard2);

            WalletPerson person1 = new WalletPerson();
            person1.AddWallet(person1Wallet);

            MasterCard person2MasterCard = new MasterCard(100m);
            Visa person2Visa = new Visa(100m);

            WalletType person2Wallet = new WalletType();
            person2Wallet.AddCard(person2MasterCard)
                         .AddCard(person2Visa);

            WalletPerson person2 = new WalletPerson();
            person2.AddWallet(person2Wallet);

            Assert.Equal(10m, person1.CalculateTotalInterest());
            Assert.Equal(10m, person1Wallet.CalculateTotalInterest());
            Assert.Equal(15m, person2.CalculateTotalInterest());
            Assert.Equal(15m, person2Wallet.CalculateTotalInterest());
        }
    }
}
