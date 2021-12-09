using KomodoInsurance.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Repositories
{
    public class DevTeamRepo
    {
        private readonly List<DevTeam> _devTeam;

        public DevTeamRepo()
        {
            _devTeam = new List<DevTeam>();
        }

        private int _count = 0;

        // Create 
        public bool CreateDevTeam(DevTeam devTeam)
        {
            if(devTeam == null)
            {
                return false;
            }
            _count++;
            devTeam.TeamId = _count;
            _devTeam.Add(devTeam);
            
            return true;
        }
        // Read
        public List<DevTeam> GetDevTeams()
        {
            return _devTeam;
        }

        // Private or "helper" methods
    }
}
