using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
    public class EmployeeTerritories
    {
        public int EmployeeID { get; set; }
        public int TerritoryID { get; set; }


        public virtual Territories Territories { get; set; }
        public virtual Employees Employees { get; set; }
    }
}
