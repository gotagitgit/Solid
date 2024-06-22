﻿namespace MainApp.LSP;

internal abstract class Account(int accountId, Customer customer, decimal balance)
{  
    public decimal Balance { get; set; } = balance;

    public int AccountId { get; } = accountId;

    public Customer Customer { get; } = customer;

    public abstract bool Withdraw(decimal amount);   
}

    