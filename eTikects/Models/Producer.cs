using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTikects.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //relationship

        public List<Movie> Movies { get; set; }

    }
}
