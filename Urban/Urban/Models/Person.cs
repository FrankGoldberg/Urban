using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Urban.Models
{
    [Serializable]
    public class Person
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        [Range(1, 120, ErrorMessage = "Age must be between 18-80 in years.")]
        public string   Nationalioty { get; set; }
        public char Gender { get; set; }
        public int Weight { get; set; }
        public string Phone { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{4})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid Phone number")]
        public string Description { get; set; }
        public string Experience { get; set; }
        public string Payment { get; set; }


    }
}
