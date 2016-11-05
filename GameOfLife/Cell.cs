using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PA_06
{
    class Cell      // Cell class that defines what a cell is, size of the cell, the state of the cell, cell color...
    {

        public int x1;
        public int y1;

        public Cell(Point cellLocation) 
        {
            cellState = false;
            cellPosition = cellLocation;

        }
        public bool cellState
        {
            set;
            get;
        }

        public Point cellPosition
        {
            set;
            get;
        }

        public Cell()
        {
            x1 = 0;
            y1 = 0;

            cellState = false;
        }

        /// <summary>
        /// Used to tell if the cell is 
        /// alive or dead in the Game Grid
        /// </summary>

    }
}
