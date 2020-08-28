using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TellingYourKids.Models.PostDtos
{
    public class PostInputDto
    {
        private DateTime now = DateTime.Now;

        public string Name { get; set; }

        public string Story { get; set; }

        public DateTime Date { get { return now; } set { } }

        public string Location { get; set; }
    }
}
