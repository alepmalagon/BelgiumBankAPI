﻿namespace BelgiumBankAPI.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Balance { get; set; }
    }
}
