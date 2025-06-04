using Kolokwium_APBD_s30958.DTOs;

namespace Kolokwium_APBD_s30958.Service;

public interface ICustomersService
{
    public Task<CustomerDTO> GetCustomerOrder(int id);
}