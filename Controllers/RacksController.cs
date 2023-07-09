using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_crud_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RacksController : ControllerBase
{
  private readonly RackContext _context;

  public RacksController(RackContext context)
  {
    _context = context;
  }

  // public class RackRoomsController : RacksController
  //       {
  //           public RackRoomsController(RackRoomContext context)
  //           :base(context)
  //           {

  //           }
  //   }

  // GET: api/Racks
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Rack>>> GetRacks()
  {
    return await _context.Racks.FromSqlRaw<Rack>("Select racks.*,rooms.id as room_id,rooms.name as room_name From Racks Join Rooms On room_no = Rooms.Id").AsNoTracking()
    .ToListAsync();
    // return await _context.Racks.ToListAsync();
  }

  // GET: api/racks/5
  [HttpGet("{id}")]
  public async Task<ActionResult<Rack>> GetRack(int id)
  {
    var rack = await _context.Racks.FindAsync(id);

    if (rack == null)
    {
      return NotFound();
    }

    return rack;
  }

  // POST api/racks
  [HttpPost]
  public async Task<ActionResult<Rack>> PostRack(Rack rack)
  {
    _context.Racks.Add(rack);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetRack), new { id = rack.Id }, rack);
  }

  // PUT api/racks/5
  [HttpPut("{id}")]
  public async Task<IActionResult> PutRack(int id, Rack rack)
  {
    if (id != rack.Id)
    {
      return BadRequest();
    }

    _context.Entry(rack).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
  }

  // DELETE api/racks/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteRack(int id)
  {
    var rack = await _context.Racks.FindAsync(id);

    if (rack == null)
    {
      return NotFound();
    }

    _context.Racks.Remove(rack);
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