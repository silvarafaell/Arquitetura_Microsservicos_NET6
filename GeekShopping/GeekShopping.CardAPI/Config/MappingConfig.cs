using AutoMapper;
using GeekShopping.CardAPI.Model;

namespace GeekShopping.CardAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig =  new MapperConfiguration(config => {
                //config.CreateMap<ProductVO, Product>();
                //config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
