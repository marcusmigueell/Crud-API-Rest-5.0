using AutoMapper;
using FilmesAPI.Data.Dtos.Gerente;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles {

    public class GerenteProfile : Profile {

        public GerenteProfile() {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<GerenteProfile, ReadGerenteDto>();
        }
    }
}
