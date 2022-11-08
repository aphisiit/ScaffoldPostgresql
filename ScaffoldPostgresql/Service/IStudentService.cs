using System;
using ScaffoldPostgresql.Models;

namespace ScaffoldPostgresql.Service
{
	public interface IStudentService
	{
		List<Student> GetStudents();
		Student AddStudent(Student student);
	}
}

