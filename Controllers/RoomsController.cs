using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_crud_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoomsController : ControllerBase
{
  private readonly RoomContext _context;

  public RoomsController(RoomContext context)
  {
    _context = context;
  }

  // GET: api/rooms
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
  {
    return await _context.Rooms.ToListAsync();
  }

  // GET: api/rooms/5
  [HttpGet("{id}")]
  public async Task<ActionResult<Room>> GetRoom(int id)
  {
    var room = await _context.Rooms.FindAsync(id);

    if (room == null)
    {
      return NotFound();
    }

    return room;
  }

  // POST api/rooms
  [HttpPost]
  public async Task<ActionResult<Room>> PostRoom(Room room)
  {
    _context.Rooms.Add(room);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetRoom), new { id = room.Id }, room);
  }

  // PUT api/Rooms/5
  [HttpPut("{id}")]
  public async Task<IActionResult> PutRoom(int id, Room room)
  {
    if (id != room.Id)
    {
      return BadRequest();
    }

    _context.Entry(room).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
  }

  // DELETE api/rooms/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteRoom(int id)
  {
    var room = await _context.Rooms.FindAsync(id);

    if (room == null)
    {
      return NotFound();
    }

    _context.Rooms.Remove(room);
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