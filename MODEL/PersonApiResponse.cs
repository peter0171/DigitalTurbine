using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class PersonApiResponse
    {
        public int NumberOfPeople { get; set; }
        public double AverageOfAge { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }

        public int NumberOfAngles { get; set; }
        public int NumberOfSaxons { get; set; }
        public int NumberOfJutes { get; set; }
        public int NumberOfAsians { get; set; }
    }
}
