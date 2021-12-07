using KomodoInsurance.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Repositories
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developer;

        public DeveloperRepo()
        {
            _developer = new List<Developer>();
        }

        private int _count = 0;


        public bool CreateNewDeveloper(Developer developer)
        {
            if (developer == null)
            {
                return false;
            }
            _count++;
            developer.DevId = _count;
            _developer.Add(developer);
            return true;
        }

        public List<Developer> ListOfDevelopers()
        {
            return _developer;
        }
    }  
}
