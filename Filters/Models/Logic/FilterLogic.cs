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
        public bool IsNum1(Theme theme)
        {
            return theme.NumOfPhotos == 1;
        }
        public bool IsNum2(Theme theme)
        {
            return theme.NumOfPhotos == 2;
        }
        public bool IsNum3(Theme theme)
        {
            return theme.NumOfPhotos == 3;
        }
        public bool IsNum4plus(Theme theme)
        {
            return theme.NumOfPhotos >= 4;
        }
        public bool IsRed(Theme theme)
        {
            return theme.Color == "Red";
        }
    }
}
