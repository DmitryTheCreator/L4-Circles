using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4_Circles
{
    public partial class Form1 : Form
    {
        CCircle circle;
        List<CCircle> dcircles;

        public Form1()
        {
            InitializeComponent();
            circle = new CCircle();
            dcircles = new List<CCircle>();
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dcircles.Add(new CCircle { x = e.X, y = e.Y });
            RoundButton btn = new RoundButton();
            btn.Location = new Point(e.X, e.Y);
            btn.Size = new Size(circle.get_rad(), circle.get_rad());
            this.Controls.Add(btn);
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            foreach (CCircle circle in dcircles)
            {
                RoundButton btn = new RoundButton();
                btn.Location = new Point(circle.x + 30, circle.y + 30);
                btn.Size = new Size(circle.get_rad(), circle.get_rad());
                this.Controls.Add(btn);
            }
        }
    }




}

