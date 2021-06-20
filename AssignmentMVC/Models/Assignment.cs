﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using AssignmentMVC.Models.Validations;
using FluentValidation.Attributes;

namespace AssignmentMVC.Models
{
    [Validator(typeof(AssignmentValidator))]
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DisplayName("Submission Date")]
        public DateTime SubDateTime { get; set; }
        [DisplayName("Oral Mark")]
        public int OralMark { get; set; }
        [DisplayName("Total Mark")]
        public int TotalMark { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Assignment()
        {
            Courses = new HashSet<Course>();
            Students = new HashSet<Student>();
        }
    }
}