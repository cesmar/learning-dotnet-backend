using ApiEcommerce.Models;
using ApiEcommerce.Models.Dtos;
using Mapster;

namespace ApiEcommerce.Mapping;

public static class MapsterConfig
{
    public static void Register()
    {
        var config = TypeAdapterConfig.GlobalSettings;

        config.NewConfig<User, UserDto>().TwoWays();
        config.NewConfig<User, CreateUserDto>().TwoWays();
        config.NewConfig<User, UserLoginDto>().TwoWays();
        config.NewConfig<User, UserLoginResponseDto>().TwoWays();
        config.NewConfig<ApplicationUser, UserDataDto>().TwoWays();
        config.NewConfig<ApplicationUser, UserDto>().TwoWays();

        config.NewConfig<Product, ProductDto>()
            .Map(destination => destination.CategoryName, source => source.Category.Name)
            .TwoWays();
        config.NewConfig<Product, CreateProductDto>().TwoWays();
        config.NewConfig<Product, UpdateProductDto>().TwoWays();

        config.NewConfig<Category, CategoryDto>().TwoWays();
        config.NewConfig<Category, CreateCategoryDto>().TwoWays();
    }
}
