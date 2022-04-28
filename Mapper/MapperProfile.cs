using AutoMapper;
using Mapper_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper_1
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Employee, EmployeeDto>()
                        .ForMember(dest => dest.Name1, opt => opt.MapFrom(src => src.Name))
                        .ForMember(dest => dest.Age, opt => opt.MapFrom(src => int.Parse(src.Age)));
            
        }
    }
}
