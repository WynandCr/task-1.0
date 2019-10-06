using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19000562_GADE_Project
{
    public partial class Form1 : Form
    {
        GameEngine engine;
        int count = 0;//timer counter start at 0
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            engine = new GameEngine(this, this.grpBox);//engine object is instantiated
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            engine.UpdateMap();//everytime the timer ticks the engine updates the map and the display to allow for unit movement info to display and timer is increased
            engine.UpdateDisplay();
            lblTimeStamp.Text = (++count).ToString();
        }

        public void displayInfo(string message)
        {
            listBox.Items.Add(message);//updating the listbox with desired message
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            engine.UpdateMap();//when button is click the engine updates the map and display and timer begins
            engine.UpdateDisplay();
            lblTimeStamp.Text = (++count).ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;//when button is clicked timer is disabled until pressed again
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;//when clicked timer is disabled and program is exited
            Environment.Exit(0);
        }
    }
}
