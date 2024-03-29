﻿// <copyright file="Account.cs" company="daniellfeijo.com">
//     daniellfeijo.com. All rights reserved.
// </copyright>
// <author>Daniel Feijo</author>
namespace CashMachine.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// The model for Account Class
    /// </summary>
    public abstract class Account
    {

        public int ID { get; set; }

        /// <summary>
        /// Gets or sets Number of the checking account
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets Balance of checking account
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// Gets or sets Client of checking account
        /// </summary>
        public virtual Client Client { get; set; }

        public int ClientID { get; set; }

        /// <summary>
        /// Method to Withdraw the value
        /// </summary>
        /// <param name="value">Value for withdraw</param>
        public abstract void Withdraw(double value);

        /// <summary>
        /// Method to Deposit the value
        /// </summary>
        /// <param name="value">Value to deposit</param>
        public virtual void Deposit(double value)
        {
            this.Balance += value;
        }

        /// <summary>
        /// Method to transfer the value
        /// </summary>
        /// <param name="value">Value for transfer</param>
        /// <param name="account">Account that receive the value</param>
        public void Transfer(double value, Account account)
        {
            this.Withdraw(value);
            account.Deposit(value);
        }

        /// <summary>
        /// Overrinding Object Method ToString
        /// </summary>
        /// <returns>Number - Client Name</returns>
        public override string ToString()
        {
            return this.Number + " - " + this.Client.Name;
        }
    }
}
