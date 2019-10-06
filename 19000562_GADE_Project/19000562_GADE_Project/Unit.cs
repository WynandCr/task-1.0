using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19000562_GADE_Project
{
    abstract class Unit//abstract base class
    {
        protected int x, y, health, speed, attack, range, team;//different varibles for the different type of fields
        protected string symbol;       

        public abstract int Attack
        {
            get;
            set;
        }

        public abstract int X
        {
            get;
            set;
        }

        public abstract int Y
        {
            get;
            set;
        }

        public abstract string Symbol
        {
            get;
            set;
        }

        public abstract int Team
        {
            get;
            set;
        }

        public abstract int Health
        {
            get;
            set;
        }

        public abstract int Speed
        {
            get;
            set;
        }

        public abstract int Range
        {
            get;
            set;
        }

        //these are abtract methods
        public abstract void Move(ref Unit closestUnit);//method that will be used to move to a new position

        public abstract void Combat(ref Unit attacker);//method that will handle the combat

        public abstract bool InRange(ref Unit attacker);//method that will be used to determine whether another unit is within attack range

        public abstract Unit Closest(ref Unit[] map);//method that will return position of closest other unit to this unit

        public abstract void Death();//method that will be used to handle the death of this unit

        public abstract override string ToString();//method that will return a neatly formatted string showing all the info
    }
}
 