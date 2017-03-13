﻿using CashMachine.Model;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachineTest.Model.Account
{
    [TestFixture]
    public class CheckingAccountTest
    {
        [Test]
        public void WithDraw300Test()
        {
            CheckingAccount account = new CheckingAccount();
            account.Balance = 300;

            //var account = new Mock<CheckingAccount>();
            //account.Setup(a => a.Balance).Returns(300);

            account.Withdraw(200.0);
            Assert.AreEqual(100, account.Balance);

        }
    }
}
