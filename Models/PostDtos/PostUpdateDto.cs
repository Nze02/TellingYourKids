﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TellingYourKids.Models.PostDtos
{
    public class PostUpdateDto
    {
        public string Name { get; set; }

        public string Story { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }
    }
}
