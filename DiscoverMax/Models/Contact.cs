using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverMax.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        [Required(ErrorMessage = "Got something to say/ask? Please complete the above field.")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
