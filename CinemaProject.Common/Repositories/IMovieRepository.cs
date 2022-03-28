﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.Common.Repositories
{
    public interface IMovieRepository<TMovie> : IRepositories<TMovie, int>
    {
    }
}
