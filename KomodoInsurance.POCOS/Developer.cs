using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.POCOS
{
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasAccessToPluralsight { get; set; }
        public int DevId { get; set; }

        public Developer()
        {
        }

        public Developer(string firstName, string lastName, bool hasAccessToPluralsight)
        {
            FirstName = firstName;
            LastName = lastName;
            HasAccessToPluralsight = hasAccessToPluralsight;
        }
    }
}
