using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_06
{
    class Cell      // Cell class that defines what a cell is, size of the cell, the state of the cell, cell color...
    {
        private int x;
        private int y;


        /// <summary>
        /// Used to tell if the cell is 
        /// alive or dead in the Game Grid
        /// </summary>
        private bool cellAlive
        {
            set;
            get;
        }
             
    }
}
