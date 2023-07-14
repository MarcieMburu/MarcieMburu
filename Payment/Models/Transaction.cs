using System.ComponentModel.DataAnnotations;

namespace Payment.Models;

public class Transaction
{
    public int Trans_Id { get; set; }
    public int Amount { get; set; }
    public string Reference { get; set; }

}

    