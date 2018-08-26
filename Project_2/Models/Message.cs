using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Project_2.Enums;

namespace Project_2.Models {
    public class Message {
        [Key]
        [Required]
        public int MessageId { get; set; }
        public string Body { get; set; }

        [Required]
        public int SenderId { get; set; }

        [Required]
        public int RecieverId { get; set; }
        public DateTime DateSent { get; set; }
        public Enums.Message.WasRead WasRead { get; set; }

        [NotMapped]
        [ForeignKey ("UserId")]
        public User Sender { get; set; }

        [NotMapped]
        [ForeignKey ("UserId")]
        public User Reciever { get; set; }
    }
}