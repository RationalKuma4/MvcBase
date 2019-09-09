using AutoMapper;
using MvcBase.Logic.AutoMappings.Common;

namespace MvcBase.Logic.AutoMappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMappings();
        }

        private void CreateMappings()
        {
            var configurators = new IAutoMapperTypeConfigurator[]
            {
                #region Map configurations
                new ApplicationUserMapperConfigurator()
                #endregion
            };
        }
    }
}
