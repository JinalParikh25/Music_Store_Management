using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Music_Store_Management.context;
using Music_Store_Management.Dtos;
using Music_Store_Management.Models;
using System.Net;

namespace Music_Store_Management.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerApiController : ControllerBase
    {
        private MusicStoreContext _musicStoreContext;
        private readonly IMapper _mapper;
        public CustomerApiController(MusicStoreContext musicStoreContext, IMapper mapper)
        {
            this._musicStoreContext = musicStoreContext;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerDto>> GetCustomerList()
         {

            List<Customer> customer =  _musicStoreContext.Customers.ToList();
            return _mapper.Map<List<CustomerDto>>(customer);
 
            //    return BadRequest("Value must be passed in the request body.");
            //return Ok(repository[id]);
        }

        [HttpGet]
        [Route("getCustomer/{id}")]
        public ActionResult<CustomerDto> GetCustomer(int id) 
        {
           Customer customer = _musicStoreContext.Customers.SingleOrDefault(x => x.Id == id);


            if (customer == null)
            {
                return BadRequest(HttpStatusCode.NotFound);
            }
            return Ok(_mapper.Map<CustomerDto>(customer));
        }

        [HttpPost]
        [Route("createCustomer")]
        public ActionResult<CustomerDto> CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(HttpStatusCode.BadRequest);
            }

            Customer customer = _mapper.Map<Customer>(customerDto);
            _musicStoreContext.Customers.Add(customer);
            _musicStoreContext.SaveChanges();

            customerDto.Id = customer.Id;

            return customerDto;
        }

        [HttpPost]
        [Route("updateCustomer")]
        public ActionResult<CustomerDto> updateCustomer(int id,CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(HttpStatusCode.BadRequest);
            }

            var customerInDb = _musicStoreContext.Customers.FirstOrDefault(x => x.Id == id);

            if (customerInDb == null)
                return BadRequest(HttpStatusCode.NotFound);

            _mapper.Map(customerDto,customerInDb);
           
            
            _musicStoreContext.SaveChanges();

            return customerDto;
        }

        [HttpDelete]
        [Route("DeleteCustomer")]
        public ActionResult DeleteCustomer(int id)
        {
            Customer customer =  _musicStoreContext.Customers.FirstOrDefault(x => x.Id == id);

            if(customer == null)
            {
                return BadRequest(HttpStatusCode.NotFound);
            }

            _musicStoreContext.Customers.Remove(customer);
            _musicStoreContext.SaveChanges();
            return Ok();
        }

    }
}
