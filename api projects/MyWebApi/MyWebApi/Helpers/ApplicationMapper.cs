using AutoMapper;
using MyWebApi.Data;
using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Helpers
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Conference, ConferencesModel>().ReverseMap();
        }
    }
}
