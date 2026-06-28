using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.Controllers;

[ApiController]
[Route("[controller]")]
public class MedicationController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(MedicationData.Medications);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(MedicationData.Medications.Where(x => x.Id == id));
    }
}
