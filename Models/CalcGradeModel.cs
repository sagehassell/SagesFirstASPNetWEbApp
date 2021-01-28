using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SagesFirstASPNetWEbApp.Models
{
    public class CalcGradeModel
    {
        [Range(0,100,
            ErrorMessage ="You must enter a number between 0 and 100")]
        public float Assignments { get; set; }

        [Range(0, 100,
            ErrorMessage = "You must enter a number between 0 and 100")]
        public float Gp { get; set; }

        [Range(0, 100,
            ErrorMessage = "You must enter a number between 0 and 100")]
        public float Quiz { get; set; }

        [Range(0, 100,
            ErrorMessage = "You must enter a number between 0 and 100")]
        public float Exam { get; set; }

        [Range(0, 100,
            ErrorMessage = "You must enter a number between 0 and 100")]
        public float INTEX { get; set; }
    }
}
