﻿namespace MainApp.DIP;

internal interface IAccount
{
    int AccountId { get; }
    Customer Customer { get; }
    decimal Balance { get; set; }    
    void Deposit(decimal amount);    
    bool Withdraw(decimal amount);
}