using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium_APBD_s30958.Models;
[Table("Ticket_Concert")]
public class Ticket_Concert
{
   [Key]
   public int TicketConcertId { get; set; }
   [ForeignKey(nameof(Ticket))]
   public int TicketId { get; set; }
   [ForeignKey(nameof(Concert))]
   public int ConcertId { get; set; }
   [Precision(10,2)]
   public decimal Price { get; set; }
   public Ticket Ticket { get; set; }
   public Concert Concert { get; set; }
   public ICollection<Purchased_Ticket> Purchased_Tickets { get; set; }
}