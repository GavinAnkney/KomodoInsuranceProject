using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.POCOS
{
    public class DevTeam
    {
        public Developer TeamMember { get; set; }
        public string TeamName { get; set; }
        public int TeamId { get; set; }

        public DevTeam()
        {
        }

        public DevTeam(Developer teamMember, string teamName, int teamId)
        {
            TeamMember = teamMember;
            TeamName = teamName;
            TeamId = teamId;
        }
    }
}
