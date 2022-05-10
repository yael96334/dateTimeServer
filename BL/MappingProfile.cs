using AutoMapper;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<GroupRegistration, GroupRegistrationDTO>();
            CreateMap<GroupRegistrationDTO, GroupRegistration> ();
            CreateMap<GroupsDTO, Group>();
            CreateMap<Group, GroupsDTO>();
            CreateMap<GroupTypeDTO, GroupType>();
            CreateMap<GroupType,GroupTypeDTO >();
            CreateMap<weighing, weightingsDTO>();
            CreateMap<weightingsDTO,weighing >();








        }
    }
}
