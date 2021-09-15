using AutoMapper;
using DataAnnotationDemo.Models;
using DataAnnotationDemo.ViewModels;

namespace DataAnnotationDemo.Mapper
{
    public class UserMapper
    {
        private static IMapper _instance;

        public static IMapper Instance
        {
            get
            {
                if (_instance != null) return _instance;

                MapperConfiguration config = new MapperConfiguration(
                    pC => { pC.CreateMap<Player, PlayerViewModel>(); });

                _instance = config.CreateMapper();

                return _instance;
            }
            
        }

    }
}