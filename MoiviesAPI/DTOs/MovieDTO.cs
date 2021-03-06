using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoiviesAPI.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Likes { get; set; }
        public int Rating { get; set; }
        public string Summary { get; set; }
        public bool InTheaters { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Poster { get; set; }
    }
}
