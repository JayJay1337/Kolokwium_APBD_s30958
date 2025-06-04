using Kolokwium_APBD_s30958.data;
using Kolokwium_APBD_s30958.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium_APBD_s30958.Service;

public class CustomersService : ICustomersService
{
    private readonly DatabaseContext _context;

    public CustomersService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<CustomerDTO> GetCustomerOrder(int id)
    {
        var customer = await _context.Customers
            .Where(c => c.CustomerId == id)
            .Select(c => new CustomerDTO
            {
                FirstName = c.FirstName,
                LastName = c.LastName,
                PhoneNumber = c.PhoneNumber,
                Purchases = c.Purchased_Tickets.Select(p => new PurchaseDTO
                {
                    Date = p.PurchaseDate,
                    Price = p.Ticket_Concert.Price,
                    Ticket = new TicketDTO
                    {
                        SerialNumber= p.Ticket_Concert.Ticket.SerialNumber,
                        SeatNumber = p.Ticket_Concert.Ticket.SeatNumber,
                    },
                    Concert = new ConcertDTO
                    {
                        Name = p.Ticket_Concert.Concert.Name,
                        Date = p.Ticket_Concert.Concert.Date 
                    }
                    
                }).ToList()
            }).FirstOrDefaultAsync();

        return customer;
    }
}
