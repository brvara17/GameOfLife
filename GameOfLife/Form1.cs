using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_06
{
    public partial class Form1 : Form
    {

        Cell [][] gameField;

        int rows = 50;
        int cols = 50;

        float cellHeight;
        float cellWidth;

        float real_Height;

        string generationUpdate;

        Pen pen = new Pen(Color.Black, 1);
        Pen penMouseDown = new Pen(Color.Blue, 1);

        private void SetCell()
        {
            real_Height = ClientSize.Height - menuStrip_Heading.Height;
            cellHeight = ClientSize.Height / (float)rows;
            cellWidth = ClientSize.Width / (float)cols;
        }

        public Form1()
        {
            InitializeComponent();
            SetCell();       
        }
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Paint Called");
            Graphics g = e.Graphics;

            //Draws Rows on Grid
            for (int i = 0; i < rows; i++)
                g.DrawLine(pen, 0, cellHeight * i + (float)menuStrip_Heading.Height, ClientSize.Width, cellHeight * i + (float)menuStrip_Heading.Height);
            
            //Draws Columns on Grid
            for (int i = 1; i < cols; i++)
                g.DrawLine(pen, cellWidth * i, menuStrip_Heading.Height, cellWidth * i, ClientSize.Height);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetCell();
            Invalidate();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           // if(e.Location 
        }
      

        private void toolStripEvolRate_Click(object sender, EventArgs e)
        {
            toolStripEvolRate.Text = "";
        }

        private void toolStripTextBoxSetGridRows_Click(object sender, EventArgs e)
        {
            toolStripTextBoxSetGridRows.Clear();
        }

        private void toolStripTextBoxSetGridRows_TextChanged(object sender, EventArgs e)
        {
            int temprows;

            if (int.TryParse(toolStripTextBoxSetGridRows.Text, out temprows))
            {
                if (temprows > 0 && temprows < 1001)
                {
                    rows = temprows;
                    SetCell();
                    Invalidate();
                }
                else
                {
                    toolStripTextBoxSetGridRows.Text = "0<rows<1001";
                }
            }
            else
            {
                if(!(toolStripTextBoxSetGridRows.Text == ""))
                    toolStripTextBoxSetGridRows.Text = "Enter an Integer";
            }
        }

        private void toolStripTextBoxSetGridColumns_Click(object sender, EventArgs e)
        {
            toolStripTextBoxSetGridColumns.Clear();
        }

        private void toolStripTextBoxSetGridColumns_TextChanged(object sender, EventArgs e)
        {
            int tempcols;

            if (int.TryParse(toolStripTextBoxSetGridColumns.Text, out tempcols))
            {
                if (tempcols > 0 && tempcols < 1001)
                {
                    cols = tempcols;
                    SetCell();
                    Invalidate();
                }
                else
                {
                    toolStripTextBoxSetGridColumns.Text = "0<columns<1001";
                }
            }
            else
            {
                if (!(toolStripTextBoxSetGridColumns.Text == ""))
                    toolStripTextBoxSetGridColumns.Text = "Error an Integer";
            }

        }

        private void clearGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Clear Grid");
            SetCell();
        }

        private void gridOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Grid On");
            SetCell();
        }
    }
}
