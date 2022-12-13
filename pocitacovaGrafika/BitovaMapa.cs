using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pocitacovaGrafika
{
    public class BitovaMapa
    {
        public string CestaKBitmape { get; set; }
        public Bitmap Bitmapa { get; set; }
        private Point rozliseni;
        private const double svetelnostR = 0.3;
        private const double svetelnostG = 0.6;
        private const double svetelnostB = 0.1;

        public BitovaMapa()
        {
            this.CestaKBitmape = Environment.CurrentDirectory + @"\1.jpg";
            this.Bitmapa = new Bitmap(this.CestaKBitmape);

            this.rozliseni.X = this.Bitmapa.Width;
            this.rozliseni.Y = this.Bitmapa.Height;
        }

        public BitovaMapa(string cesta)
        {
            this.CestaKBitmape = cesta;
            this.Bitmapa = new Bitmap(this.CestaKBitmape);

            this.rozliseni.X = this.Bitmapa.Width;
            this.rozliseni.Y = this.Bitmapa.Height;
        }

        public void ZobrazitBitovouMapu(int x, int y, Form f)
        {
            Form form = f;
            Graphics grafickyObejkt = form.CreateGraphics();
            grafickyObejkt.DrawImage(this.Bitmapa, x, y, form.Width, form.Height);
            grafickyObejkt.Dispose();
        }

        public void NacistBitovouMapu(string cesta)
        {
            this.Bitmapa = new Bitmap(cesta);
        }
    }
}
