using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flights_manager.Models;
using Flights_manager.Models.Shared;

namespace Flights_manager
{
    public class EmployeeListViewModel
    {
        public PagerViewModel Pager { get; set; }
        public ICollection<SingleEmployeeViewModel> RegisteredEmployees { get; set; }
    }
}
