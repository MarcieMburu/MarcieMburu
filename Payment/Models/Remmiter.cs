using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payment.Models

{
    public class Remmiter
    {


        public int Id { get; set; }
        public string? Rem_Name { get; set; }
        public int Rem_Phone { get; set; }
        public int Rem_ID_NO { get; set; }
        public string? Rem_Src_Acc { get; set; }
    }
}




