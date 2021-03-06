using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaProject.MVC.Models
{
    public class CinemaDetails
    {
        public int Id_CinemaPlace { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public int ZipCode { get; set; }
        public DiffusionDetails Diffusion { get; set; }
    }
}
