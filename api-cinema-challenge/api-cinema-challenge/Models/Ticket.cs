﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [Column("id")]
        public int TicketId { get; set; }
        [Column("num_seats")]
        public int NumSeats { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        // Foreign key for User (Customer)
        public int UserId { get; set; }
        public User User { get; set; }

        // Foreign key for Screening
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

        
    }
}
