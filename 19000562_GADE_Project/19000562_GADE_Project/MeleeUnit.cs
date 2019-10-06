using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19000562_GADE_Project
{
    class MeleeUnit : Unit//inherit from unit class
    {
        public MeleeUnit(int x, int y, int health, int speed, int attack, int range, int team, string symbol)
        {
            this.Health = health;//using varibles from unit class for this melee class
            this.Symbol = symbol;
            this.Attack = attack;
            this.X = x;
            this.Y = y;
            this.Range = range;
            this.Team = team;
            this.Speed = speed;
        }
        public override int Attack
        {
            get
            {
                return Attack;//using get and set so they dont expose unnecessary info
            }
            set
            {
                Attack = value;
            }
        }

        public override string Symbol
        {
            get
            {
                return Symbol;
            }
            set
            {
                Symbol = value;
            }
        }

        public override int Health
        {
            get
            {
                return Health;
            }
            set
            {
                Health = value;
            }
        }

        public override int Speed
        {
            get
            {
                return Speed;
            }
            set
            {
                Speed = value;
            }
        }

        public override int X
        {
            get
            {
                return X;
            }
            set
            {
                X = value;
            }
        }

        public override int Y
        {
            get
            {
                return Y;
            }
            set
            {
                Y = value;
            }
        }

        public override int Team
        {
            get
            {
                return Team;
            }
            set
            {
                Team = value;
            }
        }

        public override int Range
        {
            get
            {
                return Range;
            }
            set
            {
                Range = value;
            }
        }

        //overriding the abstract methods from the unit class
        public override void Move(ref Unit closestUnit)
        {
            if(this == closestUnit)//if melee unit is only closest unit remaining
            {
                return;//then use return to terminate the method
            }
            if(closestUnit.Team != team)//only react to enemy units - if not team
            {
                if(health < 25)//combat, run away
                {
                    Random r = new Random();//inheritance from class Random produces random sequence of numbers
                    switch(r.Next(0, 2))//generates random value between 0 and 2
                    {
                        case 0:
                            x += (1 * speed);//move one and use speed x + 1 x speed
                            break;
                        case 1:
                            x -= (1 * speed);//x - 1
                            break;
                    }

                    switch (r.Next(0, 2)) //for y
                    {
                        case 0:
                            y += (1 * speed);//speed is move distance
                            break;
                        case 1:
                            y -= (1 * speed);
                            break;
                    }

                    //bounds and reset character
                    if(x <= 0)
                    {
                        x = 0;
                    }
                    else if(x >= 20)
                    {
                        x = 20;
                    }

                    if(y <= 0)
                    {
                        y = 0;
                    }
                    else if(y >= 20)
                    {
                        y = 20;
                    }
                }
                //check if in combat
                //retunr value of number
                else if(Math.Abs(x - closestUnit.X) <= speed & Math.Abs(y - closestUnit.Y) <= speed)// distance between 2 positions
                {
                    Combat(ref closestUnit);
                }
                else//move towards closest unit
                {
                    if(x > closestUnit.X)//if ahead then go backwards
                    {
                        x -= speed;
                    }
                    else if(x < closestUnit.X)
                    {
                        x += speed;
                    }

                    if(y > closestUnit.Y)
                    {
                        y -= speed;
                    }
                    else if( y < closestUnit.Y)
                    {
                        y += speed;
                    }
                }
            }
        }

        public override void Combat(ref Unit attacker)
        {
            this.Health = this.Health - attacker.Attack;//melle unit health - attacker attack
            if (Health <= 0)
            {
                Death();
            }
        }

        public override bool InRange(ref Unit attacker)
        {
            if (DistanceTo(attacker) == range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override Unit Closest(ref Unit[] map)
        {
            Unit closest = this;
            int smallestRange = 100;
            foreach (Unit u in map)
            {
                if (u.Team != team)//if its not unit team
                {
                    if (smallestRange > DistanceTo(u) && u != this)//if bigger than smallest range and not melee unit then
                    {
                        smallestRange = DistanceTo(u);//smallest range
                        closest = u;//closest unit is u 
                    }
                }
            }
            return closest;
        }

        public override void Death()
        {
            throw new DeathException(this.ToString() + " IS DEAD");//throws a message as a string using the ToString()
        }

        public override string ToString()
        {
            return symbol + ": [" + x + "," + y + "] " + health + "hp " + attack;
        }

        private int DistanceTo(Unit unit)
        {
            int dx = Math.Abs(unit.X - x);//compare positions for x an y 
            int dy = Math.Abs(unit.Y - y);
            double part = Convert.ToDouble((dx * dx) + (dy * dy));//convert value to double then multiply the x and y positions by themselves
            return Convert.ToInt32(Math.Sqrt(part));//gets the square root of part
        }

        public class DeathException : System.Exception
        {
            public DeathException() : base()//new instrance for exception class
            {

            }

            public DeathException(string message) : base(message)//using a string message for base
            {

            }

            public DeathException(string message, System.Exception inner) : base(message, inner)//inner property calls original exception that caused problem
            {

            }

            //using contructor for serialization
            //using serialization to store the objects in memory
            protected DeathException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)//streaming context = source and destination
            {

            }
        }
    }
}
