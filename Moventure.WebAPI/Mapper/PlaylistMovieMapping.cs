﻿using AutoMapper;
using Moventure.BusinessLogic.Models;
using Moventure.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moventure.BusinessLogic.Mapper
{
    public class PlaylistMovieMapping : Profile
    {
            public PlaylistMovieMapping()
            {
                CreateMap<MovieActorAssignment, ActorsMovieAssignmentModel>();
                CreateMap<ActorsMovieAssignmentModel, MovieActorAssignment>();
            }
    }
}
