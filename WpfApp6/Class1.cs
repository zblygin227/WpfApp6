using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{

    public partial class podgotovkaEntities : DbContext
    {
        private static podgotovkaEntities context;
        public static podgotovkaEntities GetContext()
        {
            if (context == null) context = new podgotovkaEntities();
            return context;
        }
    }
}
