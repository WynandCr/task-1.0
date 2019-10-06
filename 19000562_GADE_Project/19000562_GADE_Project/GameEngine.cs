using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _19000562_GADE_Project
{
    class GameEngine
    {
        public Map myMap = new Map();//new map object
        private Form1 form;//making form
        private GroupBox messageGroup;//new groupbox object

        public GameEngine(Form1 form, GroupBox messageGroup)
        {
            this.form = form;//making the new form equal to the form1
            this.messageGroup = messageGroup;
            foreach (Unit u in myMap.units)
            {
                Button b = new Button();//new button with size 30 by 30
                b.Location = new Point(u.X * 35, u.Y * 35);
                b.Size = new Size(30, 30);
                b.Text = u.Symbol;
                
                if(u.Team == 0)//if team equal 0 the background is red otherwise background is green
                {
                    b.BackColor = Color.Red;
                }
                else
                {
                    b.BackColor = Color.Green;
                }

                if(u.GetType() == typeof(MeleeUnit))//testing is its range or melee unit
                {
                    b.ForeColor = Color.White;//text on button can be black or white depending on which unit it is
                }
                else
                {
                    b.ForeColor = Color.Black;
                }

                b.Click += buttonClick;//if button is clicked it updates button method info
                this.form.Controls.Add(b);
            }
        }

        public void UpdateDisplay()
        {
            
            form.Controls.Clear();
            form.Controls.Add(messageGroup);
            foreach (Unit u in myMap.units)
            {
                Button b = new Button();//new button with size of button
                b.Location = new Point(u.X * 35, u.Y * 35);
                b.Size = new Size(30, 30);
                b.Text = u.Symbol;

                if(u.Team == 0)
                {
                    b.BackColor = Color.Red;//if team equal 0 the background is red otherwise background is green
                }
                else
                {
                    b.BackColor = Color.Green;
                }

                if(u.GetType() == typeof(MeleeUnit))//testing is its range or melee unit
                {
                    b.ForeColor = Color.White;//if button is clicked it updates button method info
                }
                else
                {
                    b.ForeColor = Color.Black;
                }

                b.Click += buttonClick;//if button is clicked it updates button method info
                form.Controls.Add(b);
            }                     
        }

        public void UpdateMap()
        {
            //updating the map after each round
            foreach (Unit u in myMap.units)
            {
                Unit closestUnit = u.Closest(ref myMap.units);//finding the closest unit
                try
                {
                    u.Move(ref closestUnit);
                }
                catch(MeleeUnit.DeathException d)//if it doesnt move its death
                {
                    form.displayInfo(d.Message);
                    Unit[] temp = new Unit[myMap.units.Count() - 1];
                    int j = 0;
                    for(int i = 0; i < myMap.units.Count(); i++)
                    {
                        if(u != myMap.units[i])
                        {
                            temp[j++] = myMap.units[i];
                        }
                    }
                    myMap.units = temp;
                }
            }           
        }

        public void buttonClick(object sender, EventArgs args)
        {
            foreach (Unit u in myMap.units)
            {
                if(((Button)sender).Text == u.Symbol)//if btn is click then display info in textlist
                {
                    form.displayInfo(u.ToString());
                    break;
                }
            }
        }
    }
}
