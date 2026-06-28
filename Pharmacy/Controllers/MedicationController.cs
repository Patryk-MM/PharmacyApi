using Microsoft.AspNetCore.Mvc;
using Pharmacy.Database;

namespace Pharmacy.Controllers;

[ApiController]
[Route("[controller]")]
public class MedicationController : ControllerBase
{
    private readonly PharmacyDbContext _context;

    public MedicationController(PharmacyDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Medication);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(_context.Medication.Where(x => x.Id == id));
    }
}
