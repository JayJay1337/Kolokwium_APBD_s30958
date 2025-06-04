using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium_APBD_s30958.Models;
[Table("Ticket")]
public class Ticket
{
    [Key]
    public int TicketId { get; set; }
    [MaxLength(50)]
    public string SerialNumber { get; set; }
    public int SeatNumber { get; set; }
    
    public ICollection<Ticket_Concert> TicketConcerts { get; set; }
}