using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MVCPracticeDataAnnotations.CustomAttributes;

namespace MVCPracticeDataAnnotations.Models
{
    public class dataAnnotationTestModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        [AgeValidation(10)]
        public string age { get; set; }
    }
}
