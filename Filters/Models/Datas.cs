using System;
using System.Collections.Generic;
using System.Text;

namespace Filters.Models
{
    class Datas
    {
        public Theme t1;
        public Theme t2;
        public Theme t3;
        public Theme t4;
        public Theme t5;
        public Theme t6;
        public Datas()
        {
            LoadAllData();
        }
        public void LoadAllData()
        {
            t1 = new Theme { Color = "Red", NumOfPhotos = 3, Orientation = "Land" ,Id=1};
            t2 = new Theme { Color = "Black", NumOfPhotos = 1, Orientation = "Port" ,Id=2};
            t3 = new Theme { Color = "Blue", NumOfPhotos = 3, Orientation = "Land" ,Id=3};
            t4 = new Theme { Color = "Purple", NumOfPhotos = 6, Orientation = "Port",Id =4 };
            t5 = new Theme { Color = "White", NumOfPhotos = 7, Orientation = "Land" ,Id=5};
            t6 = new Theme { Color = "Gray", NumOfPhotos = 1, Orientation = "Port" ,Id=6};
        }
    }
}
