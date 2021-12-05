using KomodoInsurance.POCOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.UI
{
    public class ProgramUI
    {
        private readonly Developer _devRepo = new Developer();
        private readonly DevTeam _teamDevRepo = new DevTeam();

        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                RunMenu();
            }
        }

        private void RunMenu()
        {
            throw new NotImplementedException();
        }
    }
}
