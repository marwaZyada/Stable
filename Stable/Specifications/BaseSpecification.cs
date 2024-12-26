using Stable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Stable.Specifications
{
    public class BaseSpecification<T> : ISpecification<T> where T : BaseEntity
    {
        public Expression<Func<T, bool>> Cretiria { get ; set ; }
        public List<Expression<Func<T, object>>> Includes { get ; set; }= new List<Expression<Func<T, object>>>();
    
        public BaseSpecification()
        {
           
        }
        public BaseSpecification(Expression<Func<T, bool>> cretiria)
        {
            Cretiria=cretiria;
           
        }

       
    }
}
