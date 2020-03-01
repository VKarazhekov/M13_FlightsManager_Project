using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Shared
{
    public class PagerViewModel
    {
        public int CurrentPage { get; set; }

        public int PagesCount { get; set; }
    }
}
