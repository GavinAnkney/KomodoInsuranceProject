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

        // Create
        public void CreateNewDeveloper(Developer developer)
        {
            _count++;
            developer.DevId = _count;
            _developer.Add(developer);
        }
        // Read
        public List<Developer> ListOfDevelopers()
        {
            return _developer;
        }
        // Update

        // Delete
        public void RemoveDeveloper(Developer developer)
        {
            foreach (var devPoco in _developer)
            {
                if (devPoco == developer)
                {
                    _developer.Remove(devPoco);
                    break;
                }
            }
        }
        // Private or helper methods
    }
}
