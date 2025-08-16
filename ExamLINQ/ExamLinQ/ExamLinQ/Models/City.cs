using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLinQ.Models
{
    internal class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
