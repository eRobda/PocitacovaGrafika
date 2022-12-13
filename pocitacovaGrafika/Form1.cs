using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pocitacovaGrafika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zobrazitFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitovaMapa bm = new BitovaMapa();
            bm.ZobrazitBitovouMapu(0, 0, this);
        }

        private void přehrávatFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Enabled = true;
            int cas = 0;
            int index = 1;

            timer.Tick += Timer_Tick;
            void Timer_Tick(object senderr, EventArgs ee)
            {
                cas++;
                Console.WriteLine(cas);

            }

            while (true)
            {
                if (cas >= 1000)
                {
                    cas = 0;

                    if (index + 1 == 6)
                        index = 1;
                    else
                        index++;


                    BitovaMapa bm = new BitovaMapa(index.ToString() + ".jpg");
                    bm.ZobrazitBitovouMapu(0, 0, this);
                }
                
            }
        }

        
    }
}
