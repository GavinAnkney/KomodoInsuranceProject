using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.POCOS
{
    public class DevTeam
    {
        public int DevId { get; set; }
        public string TeamName { get; set; }
        public int TeamId { get; set; }

        public DevTeam()
        {
        }

        public DevTeam(int devId, string teamName)
        {
            DevId = devId;
            TeamName = teamName;
        }
    }
}
