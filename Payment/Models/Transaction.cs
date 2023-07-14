using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Payment.Models;

public class Transaction
{
    public int Id { get; set; }
    public int Amount { get; set; }
    public string? Reference { get; set; }

}

    