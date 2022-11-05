using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dados.Models;
using LocadoraDeCarros.Models;
using LocadoraDeCarros.Models.Base;
using Negocio.Models;

namespace LocadoraDeCarros.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Cliente, ClienteModel>().ReverseMap();
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Telefone, TelefoneModel>().ReverseMap();
        }
    }
}
