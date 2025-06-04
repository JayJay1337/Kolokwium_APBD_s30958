using Kolokwium_APBD_s30958.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium_APBD_s30958.data;

public class DatabaseContext : DbContext
{
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Ticket_Concert> Ticket_Concerts { get; set; }
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Purchased_Ticket> PurchasedTickets { get; set; }
    public DbSet<Customer> Customers { get; set; }
    
    protected DatabaseContext()    
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>().HasData(new List<Ticket>
        {
            new Ticket(){TicketId = 1, SeatNumber = 2, SerialNumber = "123456789"},
            new Ticket(){TicketId = 2, SeatNumber = 15, SerialNumber = "892324324"},
        });
        modelBuilder.Entity<Ticket_Concert>().HasData(new List<Ticket_Concert>
        {
            new Ticket_Concert(){TicketConcertId = 1, TicketId = 1, ConcertId =2, Price=50},
            new Ticket_Concert(){TicketConcertId = 2, TicketId = 2, ConcertId =1, Price=75},
        });
        modelBuilder.Entity<Concert>().HasData(new List<Concert>
        {
            new Concert(){ConcertId = 1, Name = "Koncert1", Date = DateTime.Parse("2020-09-01")},
            new Concert(){ConcertId = 2, Name = "Koncert2", Date = DateTime.Parse("2021-09-01")},
        });
        modelBuilder.Entity<Purchased_Ticket>().HasData(new List<Purchased_Ticket>
        {
            new Purchased_Ticket(){TicketConcertId = 1, CustomerId = 1, PurchaseDate = DateTime.Parse("2020-08-02")},
            new Purchased_Ticket(){TicketConcertId = 2, CustomerId = 2, PurchaseDate =DateTime.Parse("2021-08-02")},
        });
        modelBuilder.Entity<Customer>().HasData(new List<Customer>
        {
            new Customer(){CustomerId = 1, FirstName = "Jan", LastName = "Kowalski", PhoneNumber = ""},
            new Customer(){CustomerId = 2, FirstName = "Kacper", LastName = "Nowak", PhoneNumber = "999-000-999"},
        });
    }
}