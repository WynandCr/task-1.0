using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19000562_GADE_Project
{
    class Map
    {
        public Unit[] units = new Unit[10];//new array with 10 elements

        public Map()
        {
            Random r = new Random();//creating new random number
            for(int i = 0; i < 10; i++)//looping through each element
            {
                int newX = r.Next(0, 20);//randomise x and y position 
                int newY = r.Next(0, 20);
                int team = i % 2;
                int tempAttack = 0;
                switch(r.Next(0,4))//getting random number betweeen 0 and 3 included
                {
                    case 0://if 0 then attack equal to 5
                        tempAttack = 5;
                        break;
                    case 1:
                        tempAttack = 10;
                        break;
                    case 2:
                        tempAttack = 15;
                        break;
                    case 3:
                        tempAttack = 20;
                        break;     
                }

                switch (r.Next(0, 2))//getting random number between 0 and 1 included
                {
                    case 0://if its 0 then do meleeunit
                        units[i] = new MeleeUnit(newX, newY, 100, 1, tempAttack, 1, team, i.ToString());//updates the unit based on its changing x and y cord
                        break;
                    case 1://if its 1 then do rangeunit
                        units[i] = new RangeUnit(newX, newY, 100, 1, tempAttack, 4, team, i.ToString());
                        break;
                }
            }
        }
    }
}
