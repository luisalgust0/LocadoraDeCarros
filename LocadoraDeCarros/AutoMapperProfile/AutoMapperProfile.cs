using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dados.Models;
using LocadoraDeCarros.Models;
using Negocio.Models;

namespace LocadoraDeCarros.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Cliente, ClienteModel>().ReverseMap();
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<List<Cliente>, List<ClienteModel>>().ReverseMap();
            CreateMap<List<Cliente>, List<ClienteViewModel>>().ReverseMap();
        }
    }
}
