using Microsoft.AspNetCore.Http;
using MoiviesAPI.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoiviesAPI.DTOs
{
    public class PersonCreationDTO : PersonPatchDTO
    {
        [FileSizeValidator(MaxFileSizeInMbs: 4)]
        [ContentTypeValidator(ContentTypeGroup.Image)]
        public IFormFile Picture { get; set; }
    }
}
