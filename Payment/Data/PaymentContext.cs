using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Payment.Models;

namespace Payment.Data
{
    public class PaymentContext : DbContext
    {
        public PaymentContext (DbContextOptions<PaymentContext> options)
            : base(options)
        {
        }

        public DbSet<Payment.Models.Remmiter> Remmiter { get; set; } = default!;

        public DbSet<Payment.Models.Receiver> Receiver { get; set; } = default!;

        public DbSet<Payment.Models.Transaction> Transaction { get; set; } = default!;
    }
}
