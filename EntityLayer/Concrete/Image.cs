﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
