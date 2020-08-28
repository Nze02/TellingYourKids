using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TellingYourKids.Models.PostDtos
{
    public class PostOutputDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Story { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public string Status { get; set; }
    }
}
