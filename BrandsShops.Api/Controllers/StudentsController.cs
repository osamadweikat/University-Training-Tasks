using BrandsShops.Api.Interfaces;
using BrandsShops.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BrandsShops.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<StudentsController> _logger;

        public StudentsController(IUnitOfWork unitOfWork, ILogger<StudentsController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("📥 Getting all students at {Time}", DateTime.UtcNow);
            var students = await _unitOfWork.Students.GetAllAsync();
            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Student student)
        {
            if (student.EnrollmentDate == default)
            {
                student.EnrollmentDate = DateTime.UtcNow;
                _logger.LogInformation("ℹ️ EnrollmentDate was not provided. Defaulted to: {Date}", student.EnrollmentDate);
            }

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("❌ Invalid student model posted at {Time}", DateTime.UtcNow);
                return BadRequest(ModelState);
            }

            await _unitOfWork.Students.AddAsync(student);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation("✅ Student created: {Email} at {Time}", student.Email, DateTime.UtcNow);
            return CreatedAtAction(nameof(GetAll), new { id = student.Id }, student);
        }
    }
}
