using System;
using System.Collections.Generic;

namespace ScaffoldPostgresql.Models
{
    public partial class Teacher
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int? Age { get; set; }
        public string? Subject { get; set; }
        public double? Salary { get; set; }
    }
}
