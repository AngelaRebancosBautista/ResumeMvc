using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResumeMvc.Models
{
    public class Resume
    {

        public int Id { get; set; }

        [Required] public string FullName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public string Aboutme { get; set; }
        public string PhotoUrl { get; set; } // relative path to photo

        public List<Ilike> Ilike { get; set; } = new();
        public List<Education> Educations { get; set; } = new();
        public List<My_Skills> My_Skills { get; set; } = new();
    }
}

  

