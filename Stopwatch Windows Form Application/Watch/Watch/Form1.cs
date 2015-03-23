using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Watch
{
    public partial class Form1 : Form
    {
        int counter = 0;
        Boolean run = false;

        int lap_number = 1;
        String laps;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (run)
            {
                run = false;
                action.Text = "Start";
            }
            else
            {
                run = true;
                action.Text = "Stop";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (run)
            {
                counter++;
                time.Text = counter.ToString();
            }
        }

        private void lap_Click(object sender, EventArgs e)
        {
            laps = "Lap " + lap_number + ": " + counter + "\r\n" + laps;
            display.Text = laps;
            lap_number++;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            counter = 0;
            time.Text = counter.ToString();
            laps = "";
            display.Text = laps;
            lap_number = 1;
        }
    }
}
