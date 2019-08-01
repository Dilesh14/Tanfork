using System;
using System.Collections.Generic;
using System.Text;

namespace Filters.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public int NumOfPhotos { get; set; }
        public string Color { get; set; }
        public string Orientation { get; set; }
    }
}
