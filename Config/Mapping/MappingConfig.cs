using AutoMapper;
using LoginAPI.Models;
using LoginAPI.ValuesObjects;
using LoginAPI.Criptografia;

namespace LoginAPI.Config.Mapping
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
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => CripitografiaEmailEtc.Descriptografar(src.Email)));
                config.CreateMap<UserVO_Out, UserModel>();



            });
        }

        public static UserVO_Out Retorno_Out(UserModel userModel)
        {
            UserVO_Out user_Out = new UserVO_Out(userModel.Nome, CripitografiaEmailEtc.Descriptografar(userModel.Email));
            return user_Out;
        }
    }
}
