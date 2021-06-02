using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recap_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int left = 0;
            int top = 0;
            Button[,] button1= new Button[8, 8];
            for (int i = 0; i < button1.GetUpperBound(0) ; i++)
            {
                for (int j = 0; j < button1.GetUpperBound(1); j++)
                {
                    button1[i, j].Width = 50;
                    button1[i, j].Height = 50;
                    button1[i, j].Left = left;
                    left += 50;
                    this.Controls.Add(button1[i,j]);
                }
            }


        }
    }
}
