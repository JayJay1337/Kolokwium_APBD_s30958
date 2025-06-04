namespace Kolokwium_APBD_s30958.DTOs;

public class CustomerDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public List<PurchaseDTO> Purchases { get; set; }
}

public class PurchaseDTO
{
    public DateTime Date { get; set; }
    public decimal Price { get; set; }
    public TicketDTO Ticket { get; set; }
    public ConcertDTO Concert { get; set; }
}

public class TicketDTO
{
    public string SerialNumber { get; set; }
    public int SeatNumber { get; set; }
}

public class ConcertDTO
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
}