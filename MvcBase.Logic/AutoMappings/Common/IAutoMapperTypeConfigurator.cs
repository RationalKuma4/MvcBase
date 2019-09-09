using AutoMapper;

namespace MvcBase.Logic.AutoMappings.Common
{
    public interface IAutoMapperTypeConfigurator
    {
        void Configure(IMapperConfigurationExpression configuration);
    }
}
