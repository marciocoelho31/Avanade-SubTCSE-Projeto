using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
            CreateMap<Dtos.EmployeeRole.EmployeeRoleDTO, Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("RoleName", options => options.MapFrom(src => src.Cargo));
            CreateMap<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, Dtos.EmployeeRole.EmployeeRoleDTO>()
                .ForMember("Cargo", memberOptions => memberOptions.MapFrom(src => src.RoleName));
        }
    }
}
