
namespace App.Business.Logic
{
    using Common;
    using Data.Entity;
    using DataAccess;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RegionBusinessLogic : BusinessLogicBase
    {
        public RegionBusinessLogic()
            : base()
        {
        }
        public List<Region> Load()
        {
            var result = new List<Region>();

            result = Context.Regions.ToList();

            return result;
        }
    }
}
