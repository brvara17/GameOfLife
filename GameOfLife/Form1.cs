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
        Cell [,] currGameField, nextGameField;
        int rows = 50;
        int cols = 50;

        public float cellHeight;
        public float cellWidth;

        float real_Height;

        string generationUpdate;

        ColorDialog backgroundColorBox = new ColorDialog();
        ColorDialog gridColorBox = new ColorDialog();
        ColorDialog creatureColorBox = new ColorDialog();

        Color gridLineColor = Color.Black;
        Color creatureColor = Color.Blue;

        Pen pen = new Pen(Color.Black, 1);
        Pen gridTogglePen = new Pen(Color.LightGray, 1);
        Pen penMouseDown = new Pen(Color.Blue, 1);

        Brush aliveBrush = new SolidBrush(Color.Blue);
        Brush deadBrush = new SolidBrush(Color.WhiteSmoke);
        
        

        bool gridToggleOnOff = true;

        private void SetCell()
        {
            real_Height = ClientSize.Height - menuStrip_Heading.Height;
            cellHeight = ClientSize.Height / (float)rows;
            cellWidth = ClientSize.Width / (float)cols;

            currGameField = new Cell[rows, cols];
            SetGameFieldArray();
        }

        public Form1()
        {
            InitializeComponent();
            SetCell();
            backgroundColorBox.Color = Color.WhiteSmoke;
            gridColorBox.Color = Color.Black;

        }

        /// <summary>
        /// Populates an Array with the grid properties.
        /// Each cell in the game field will have the top left corner point coordinates
        /// in its x1 and y1 variables. 
        /// </summary>
        private void SetGameFieldArray()
        {

            int tempYValue;
            int tempXValue;
            int r = 0;
            int c = 0;
            for (r = 0; r < rows; r++)
            {
                tempYValue = (int)(menuStrip_Heading.Height + (cellHeight * r));

                for (c = 0; c < cols; c++)
                {
                    tempXValue = (int)cellWidth * c;
                    Cell temp = new Cell();
                    currGameField[r, c] = temp;
                    currGameField[r, c].x1 = tempYValue;
                    currGameField[r, c].y1 = tempXValue;
                }
            }

            //Just for visual confirmation that the function is working correctly
            //foreach (Cell field in currGameField)
            //{
            //    Console.WriteLine(field.x1 + " " + field.y1);
            //}

            //Console.WriteLine(currGameField.Length);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Paint Called");
            Graphics g = e.Graphics;

            //Toggles the grid On/Off
            if (!gridToggleOnOff)
            {
                pen = new Pen(backgroundColorBox.Color, 1);
            }
            else
            {
                pen = new Pen(gridLineColor, 1);
            }
        
                        

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
            //Sets all cells to false and resets the color to background but should be changed
            //to reset all colors in each cell since each cell will be colored not the background
            Console.WriteLine("Clear Grid");
            // SetCell();

            BackColor = backgroundColorBox.Color;

            int r = 0;
            int c = 0;
            for (r = 0; r < rows; r++)
            {
                for (c = 0; c < cols; c++)
                {
                    currGameField[r, c].cellState = false;
                }
            }
            
            Invalidate();

        }

        private void gridOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Toggles the grid on or off
            if (gridOToolStripMenuItem.Checked)
                gridToggleOnOff = true;
            else
                gridToggleOnOff = false;
            Invalidate();
        }

        private void setBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stores color chosen by user
           backgroundColorBox.ShowDialog();
            BackColor = backgroundColorBox.Color;

        }

        private void setCreatureColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creatureColorBox.ShowDialog();
            creatureColor = creatureColorBox.Color;
            
        }

        private void setTooStriplGridColor_Click(object sender, EventArgs e)
        {
            //Display color box and user selects grid color
            gridColorBox.ShowDialog();
            gridLineColor = gridColorBox.Color;
            Invalidate();
        }

       
    }
}
