namespace MvcBase.Logic.AutoMappings.Common
{
    public interface IAutoMapper
    {
        T Map<T>(object toMap);
    }
}