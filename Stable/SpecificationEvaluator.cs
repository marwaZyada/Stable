using Microsoft.EntityFrameworkCore;
using Stable.Models;
using Stable.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Stable
{
    public static class SpecificationEvaluator<T> where T : BaseEntity
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputquery,ISpecification<T> spec)
        {
            var query = inputquery;
            if (spec.Cretiria is not null)
         
                query=query.Where(spec.Cretiria);
            
            query = spec.Includes.Aggregate(query, (currentquery, incudesexpressions) => currentquery.Include(incudesexpressions));
            return query;
            
        }
    }
}
