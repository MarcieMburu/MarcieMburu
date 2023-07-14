using System.ComponentModel.DataAnnotations;

namespace Payment.Models
{
    public class Receiver
    {
    

        public int Rec_Id { get; set; }
        public string? Rec_Name { get; set; }
        public int Rec_Phone { get; set; }
        public int Rec_ID_NO { get; set; }
        public string? Rec_Dst_Acc { get; set; }

    }
}
