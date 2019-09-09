using AutoMapper;

namespace MvcBase.Logic.AutoMappings.Common
{
    public class AutoMapperAdapter : IAutoMapper
    {
        private readonly IMapper _mapper;

        public AutoMapperAdapter(IMapper mapper)
        {
            _mapper = mapper;
        }

        public T Map<T>(object toMap)
        {
            return _mapper.Map<T>(toMap);
        }
    }
}
