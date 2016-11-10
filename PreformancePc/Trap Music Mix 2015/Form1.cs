using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Trap_Music_Mix_2015
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;

        public Form1()
        {          
            InitializeComponent();
            InitialiseCPUCounter();
            InitializeRAMCounter();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            cpu_text.BackColor = Color.LimeGreen;
            ram_text.BackColor = Color.LimeGreen;
            disk_text.BackColor = Color.LimeGreen;
            wifi_text.BackColor = Color.LimeGreen;
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.FromPoint(this.Location).WorkingArea.Right - this.Width, 0);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LimeGreen, e.ClipRectangle);
        }
        private void InitialiseCPUCounter()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time","_Total",true);
        }
        private void InitializeRAMCounter()
        {
            ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.cpu_text.Text = Convert.ToInt32(cpuCounter.NextValue()).ToString() + "%";

            this.ram_text.Text = Convert.ToInt32(ramCounter.NextValue()).ToString() + "Mb";
        }
    }      
    }

