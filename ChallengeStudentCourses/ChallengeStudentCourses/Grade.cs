using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Grade
    {
        public Course Course { get; set; }
        public Student Student { get; set; }
        public int Final { get; set; }
    }
}