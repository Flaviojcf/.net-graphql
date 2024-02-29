using graphqlAPI.Context;
using graphqlAPI.Models;

namespace graphqlAPI
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<SuperHeroi> GetSuperherois([Service] MyDbContext context) =>
        context.SuperHerois;
    }
}
