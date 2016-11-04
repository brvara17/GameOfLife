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


        /// <summary>
        /// Used to tell if the cell is 
        /// alive or dead in the Game Grid
        /// </summary>

    }
}
