﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appsCLI
{
    internal class ContentRating
    {
        public int ContentRatingId { get; set; }
        public string ContentRatingName { get; set; }

        public ContentRating(int id, string name)
        {
            ContentRatingId = id;
            ContentRatingName = name;
        }
    }
}
