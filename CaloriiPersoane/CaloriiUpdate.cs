



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriiPersoane
{
    public class CaloriiUpdate
    {

        private int CalRamase { get; set; }

        private float ProtTot { get; set; }

        private float CarbTot { get; set; }

        private float GrasimiTot { get; set; }

        public void UpdateCall(int call)
        {
            CalRamase -= call;
        }
        public void UpdateProt(float prot)
        {
            ProtTot += prot;
        }

        public void UpdateFats(float fat)
        {
            GrasimiTot += fat;
        }

        public void UpdateCarbs(float carb)
        {
            CarbTot += carb;
        }


    }
}
