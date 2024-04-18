using Mapster;

namespace GalaxyExpress.BLL.Mapping
{
    public static class MappingFunctions
    {
        public static TDestination MapSourceToDestination<TSource, TDestination>(TSource entity)
        {
            return entity!.Adapt<TDestination>();
        }
        public static IQueryable<TDestination> MapListSourceToDestination<TSource, TDestination>
            (IEnumerable<TSource> entities)
        {
            var entitiesQueryable = entities.AsQueryable();

            return entitiesQueryable.ProjectToType<TDestination>();
        }
    }
}
