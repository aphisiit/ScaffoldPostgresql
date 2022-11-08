using System;
using ScaffoldPostgresql.Models;
using ScaffoldPostgresql.PostgreSQL;

namespace ScaffoldPostgresql.Service
{
	public class StudentService : IStudentService
	{
		private readonly TestDbContext context;

		public StudentService(TestDbContext _context)
		{
			this.context = _context;
		}

		public Student AddStudent(Student student)
		{
			context.Students.Add(student);
			context.SaveChanges();
			return student;
		}

		public List<Student> GetStudents()
		{
			List<Student> students = context.Students.ToList();
			return students;
		}
	}
}

