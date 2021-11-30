using MoiviesAPI.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoiviesAPI.DTOs
{
    public class GenreCreationDTO
    {
        [Required]
        [StringLength(40)]
        [FirstLetterUppercase]
        public string Name { get; set; }
    }
}
