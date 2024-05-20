﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialMigration.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string? SectionName { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; } = null!;

        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<SectionSchedule> SectionShedules { get; set; } = new List<SectionSchedule>();

        public ICollection<Student> Students { get; set; } = new List<Student>();

    }
}
