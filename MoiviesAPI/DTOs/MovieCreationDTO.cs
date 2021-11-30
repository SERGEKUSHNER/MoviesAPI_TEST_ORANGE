using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoiviesAPI.Helpers;
using MoiviesAPI.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoiviesAPI.DTOs
{
    public class MovieCreationDTO : MoviePatchDTO
    {
        [FileSizeValidator(MaxFileSizeInMbs: 4)]
        [ContentTypeValidator(ContentTypeGroup.Image)]
        public IFormFile Poster { get; set; }

        [ModelBinder(BinderType = typeof(TypeBinder<List<int>>))]
        public List<int> GenresIds { get; set; }

        [ModelBinder(BinderType = typeof(TypeBinder<List<ActorCreationDTO>>))]
        public List<ActorCreationDTO> Actors { get; set; }
    }
}
