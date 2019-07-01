using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roullete
{
    class master
    {
        public int Gunspin;
        public int Winloss = 0;
        public int Fire = 0;
        public int Away = 2;
        public int Totalbullets = 6;//totalbullets tha u can use in game 
        
        public int Shootaway()
        {
            
            if (Gunspin == 1 && Away == 2 && Totalbullets > 0 )
            {

                Winloss = 10;


            }
            if (Gunspin == 1 && Away == 1 && Totalbullets > 0 )
            {

                Winloss = 5;

            }

            else if (Totalbullets > 0 && Gunspin != 1)
            {
                Winloss = 0;
                Totalbullets = Totalbullets - 1;
                Gunspin = BulleteChange(Gunspin);//loades the bullete to next shot



            }
            return Winloss;
        }
        public int BulleteChange(int spingun)
        {
            if (spingun == 6)
            {
                spingun = 1;
            }
            else
            {
                spingun++;
            }
            return spingun;
        }

        public int Shootbullete()
        {
            if (Totalbullets > 0 && Gunspin == 1)
            {

                Fire = 1;
                



            }
            else if (Totalbullets > 0 && Gunspin != 1)
            {
                Fire = 2;

            }
            return Fire;
        }
    }
}
