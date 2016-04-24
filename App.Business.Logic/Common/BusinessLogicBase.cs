using App.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Logic.Common
{
    public class BusinessLogicBase
    {
        private DataContext _context;

        public DataContext Context
        {
            get
            {
                if (_context == null)
                    _context = new DataContext();

                return _context;
            }
        }

        public BusinessLogicBase()
        {

        }
    }
}
