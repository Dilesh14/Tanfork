using System;
using System.Collections.Generic;
using System.Text;

namespace Filters.Models.Logic
{
    public class FilterLogic
    {
        public FilterLogic()
        {
        }
        public bool IsLand(Theme theme)
        {
            return theme.Orientation == "Land";
        }
        public bool IsPort(Theme theme)
        {
            return theme.Orientation == "Port";
        }
    }
}
