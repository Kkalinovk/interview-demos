﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    interface IStaticCountriesService
    {
        List<Tuple<string, int>> GetCountryPopulations();
        Task<List<Tuple<string, int>>> GetCountryPopulationsAsync();
    }
}
