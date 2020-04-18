using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulette
{
    class Gun
    {
        private int[] chamber =  new int[]{ 0, 0, 0, 0, 0, 0};
        private Random MyRandom = new Random();
        private int chances = 2;

        public int ChamberPos { get; private set; } = 0;

        public int get_chances()
        {
            return chances;
        }

        public void update_chances()
        {
                chances--;
        }

        public void emptyChamber()
        {
            for (int i = 0; i < chamber.Length; i++)
                chamber[i] = 0;
            ChamberPos = 0;
            chances = 2;
            
        }
        public void loadBullet(){
            chamber[0] = 1;
        
        }
        public void spinChambers()
        {
            int pos = MyRandom.Next(0, 6);
            if (pos != 0)
            {
                chamber[0] = 0;
                chamber[pos] = 1;
            }

        }
        public bool Fire()
        {
            if (chamber[ChamberPos] == 1)
            return true;
            else
            {
                ChamberPos++;
                return false;
            }
        }

    }
    
}
