using AutoMapper;
using Music_Store_Management.Dtos;
using Music_Store_Management.Models;

namespace Music_Store_Management.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}
