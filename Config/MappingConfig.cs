using AutoMapper;
using LoginAPI.Models;
using LoginAPI.ValuesObjects;

namespace LoginAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            return new MapperConfiguration(config =>
            {
                config.CreateMap<UserVO_In, UserModel>();
                config.CreateMap<UserModel, UserVO_In>();

                config.CreateMap<UserVO_Out, UserVO_In>();
                config.CreateMap<UserVO_In, UserVO_Out>();

                config.CreateMap<UserModel, UserVO_Out>()
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => Criptografia.CripitografiaEmailEtc.Descriptografar(src.Email)));
                config.CreateMap<UserVO_Out, UserModel>();



            });
        }
    }
}
