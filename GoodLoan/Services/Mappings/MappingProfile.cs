using AutoMapper;
using Domain.Entities;
using Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ForMember(dest => dest.RoleName, source => source.MapFrom(source => source.UserRole.RoleName)); ;
            CreateMap<UserRole, UserRoleDto>();
            CreateMap<Loan, LoanDto>();
            CreateMap<Payment, PaymentDto>();
            CreateMap<Installment, InstallmentDto>();
            CreateMap<UserRoleMenuAccess, UserRoleMenuAccessDto>();
            CreateMap<UserMenu, UserMenuDto>();
            CreateMap<Setting, SettingDto>();
            //Map from Developer Object to DeveloperDTO Object
        }
    }
}
