using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            textBox1.Text = String.Format(
                @"Welcome to the Game of Life!
In order to start, follow these steps:

1. Click or drag mouse on the grid or click 'Randomize Cells' to populate with alive/dead cells.
2. Click start to run the simulation or step to step through each generation.
3. Pressing 'Clear' will stop the simulation and clear the grid.

SHORTCUTS:
1. CTRL + A to start/stop the simulation
2. CTRL + S to step the evolution
3. CTRL + D to change the evolution rate

The grid and survival options allow customization of the simulation. You may change the birth/survival
parameters and the colors of the grid, background, and cells.");
        }
    }
}
