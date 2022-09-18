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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(this.ClientRectangle);
            Region rgn = new Region(path);
            this.Region = rgn;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
