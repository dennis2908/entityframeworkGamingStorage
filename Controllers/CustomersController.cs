using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_crud_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
  private readonly CustomerContext _context;

  public CustomersController(CustomerContext context)
  {
    _context = context;
  }

  // GET: api/customers
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
  {
    return await _context.Customers.ToListAsync();
  }

  // GET: api/customers/5
  [HttpGet("{id}")]
  public async Task<ActionResult<Customer>> GetCustomer(int id)
  {
    var customer = await _context.Customers.FindAsync(id);

    if (customer == null)
    {
      return NotFound();
    }

    return customer;
  }

  // POST api/customers
  [HttpPost]
  public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
  {
    _context.Customers.Add(customer);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
  }

  // PUT api/customers/5
  [HttpPut("{id}")]
  public async Task<IActionResult> PutCustomer(int id, Customer customer)
  {
    if (id != customer.Id)
    {
      return BadRequest();
    }

    _context.Entry(customer).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
  }

  // DELETE api/customers/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteCustomer(int id)
  {
    var customer = await _context.Customers.FindAsync(id);

    if (customer == null)
    {
      return NotFound();
    }

    _context.Customers.Remove(customer);
    await _context.SaveChangesAsync();

    return NoContent();
  }

  // dummy endpoint to test the database connection
  [HttpGet("test")]
  public string Test()
  {
    return "Hello World!";
  }
}