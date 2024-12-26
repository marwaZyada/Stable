using Stable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stable.Specifications
{
    public class OwnerSpecification:BaseSpecification<Owner>
    {
        public OwnerSpecification() : base()

        {
            Includes.Add(o => o.Horses);


        }
        public OwnerSpecification(string id):base(o=>o.Id==id)
        {
            Includes.Add(o => o.Horses);
           
        }
    }
}
