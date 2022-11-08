using System;
using Microsoft.AspNetCore.Mvc;
using ScaffoldPostgresql.Models;
using ScaffoldPostgresql.Service;

namespace ScaffoldPostgresql.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class StudentController : ControllerBase
	{

		private readonly IStudentService service;

		public StudentController(IStudentService _service)
		{
			this.service = _service;
		}

		[HttpPost]
		public Student AddStudent([FromBody] Student student)
		{
			return service.AddStudent(student);
		}

		[HttpGet]
		public List<Student> GetStudents()
		{
			return service.GetStudents();
		}
	}
}

