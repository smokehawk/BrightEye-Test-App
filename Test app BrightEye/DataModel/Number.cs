using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test_app_BrightEye.DataModel
{
    public class Number
    {
        public int NumberId { get; set; }

        [Required]
        public int Value { get; set; }
    }
}
