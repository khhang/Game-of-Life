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

    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.LightGray, 1); // Pen used to draw grid lines

        // The # of rows and columns for the grid
        int row = 50;
        int col = 50;
        // Survival parameters (default values)
        int BMIN = 3;
        int BMAX = 3;
        int SMIN = 2;
        int SMAX = 3;
        int evolveRate = 100;

        // Grid class to draw grid and cells
        Grid lifeGrid;

        // Cell array to hold index of each cell
        Cell[,] cellArray;

        // Used by mouse down event to properly set state of cells when dragging
        int tempR = -1;
        int tempC = -1;

        public Form1()
        {
            InitializeComponent();
            // Set color of buttons
            startToolStripMenuItem.BackColor = Color.White;
            stepToolStripMenuItem.BackColor = Color.White;
            clearToolStripMenuItem.BackColor = Color.White;
            randomizeCellsToolStripMenuItem.BackColor = Color.White;

            BMINlbl.Text = String.Format("BMIN = {0}", BMIN);
            BMAXlbl.Text = String.Format("BMAX = {0}", BMAX);
            SMINlbl.Text = String.Format("SMIN = {0}", SMIN);
            SMAXlbl.Text = String.Format("SMAX = {0}", SMAX);
            evolveLbl.Text = String.Format("Evolve Rate = {0}", evolveRate);

            lifeGrid = new Grid(row, col);
            cellArray = new Cell[row, col];
            cellArray = lifeGrid.Randomize(cellArray); // Set random initial cell state
            UpdateCell(); // Updates cell dimensions
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics form1_graphics = e.Graphics;

            // Create the grid and draw live cells
            lifeGrid.drawCells(cellArray, form1_graphics);
            if (hideGridToolStripMenuItem.Text == "Hide Grid")
            {
                lifeGrid.createGrid(row, col, ClientSize.Width, ClientSize.Height, menuStrip1.Height, form1_graphics);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Updates the cell dimensions
            UpdateCell();
            Invalidate();
        }

        private void Form1_MouseDown(object snder, MouseEventArgs e)
        {
            float r = ((e.Y - menuStrip1.Height) / ((ClientSize.Height - menuStrip1.Height) / (float)row)); // Finds index of row
            float c = (e.X) / (ClientSize.Width / (float)col); // Finds index of col

            // Cells properties for drawing
            float cellWidth = ClientSize.Width / (float)col;
            float cellHeight = (ClientSize.Height - menuStrip1.Height) / (float)row;
            float cellX = (int)c * cellWidth;
            float cellY = (int)r * cellHeight + menuStrip1.Height;

            // Saves value of current row and col so when cell is created through
            // normal click from mouse, the cell is not set to unintended state if mouse
            // is moved on same cell
            tempR = (int)r;
            tempC = (int)c;

            // Verifies if valid row and col before creating cell
            if ((int)r < row && (int)r >= 0 && (int)c < col && (int)c >= 0)
            {
                // Change state of cell depending if cell was already created
                if (cellArray[(int)r, (int)c] != null && cellArray[(int)r, (int)c].IsAlive)
                {
                    // If the cell is already alive, change it to dead
                    cellArray[(int)r, (int)c].IsAlive = false;
                }
                else
                {
                    // If cell is empty or is dead, change state to alive
                    cellArray[(int)r, (int)c] = new Cell(true, cellWidth, cellHeight, cellX, cellY);
                }
            }
            Invalidate(); // Force repaint
        }

        // Used by the resize event and evolution method to update the dimensions of the cell
        private void UpdateCell()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (cellArray[i, j] != null)
                    {
                        // Takes the new values of the client size and assigns new dimensions to the cell
                        cellArray[i, j].CellWidth = ClientSize.Width / (float)col;
                        cellArray[i, j].CellHeight = (ClientSize.Height - menuStrip1.Height) / (float)row;
                        cellArray[i, j].CellX = j * cellArray[i, j].CellWidth;
                        cellArray[i, j].CellY = i * cellArray[i, j].CellHeight + menuStrip1.Height;
                    }
                }
            }
        }

        // Changes the # of rows of the grid
        private void editRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                row = form2.Value; // Retrieves value of form2
            }
            lifeGrid.Row = row; // Sets new row value
            cellArray = new Cell[row, col]; // Clears and creates a new cell array with new rows
            form2.Dispose();
            timer1.Enabled = false;
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.BackColor = Color.White;
            Invalidate(); // Forces paint event
        }

        // Changes the # of columns of the grid
        private void editColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog(this) == DialogResult.OK)
            {
                col = form2.Value; // Retrieves value of form2
            }
            lifeGrid.Col = col; // Sets new row value
            cellArray = new Cell[row, col]; // Clears and creates a new cell array with new rows
            form2.Dispose();
            timer1.Enabled = false;
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.BackColor = Color.White;
            Invalidate(); // Forces paint event
        }

        // Changes color of the cells
        private void cellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                lifeGrid.CellColor = colorDlg.Color; // Sets a new cell color
            }
            Invalidate(); // Forces paint event
        }

        // Changes color of the dead cells
        private void deadCellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                lifeGrid.DeadCellColor = colorDlg.Color; // Sets a new cell color
            }
            Invalidate(); // Forces paint event
        }

        // Changes the color of the grid lines
        private void gridLineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the grid is not currently hidden
            if (hideGridToolStripMenuItem.Text == "Hide Grid")
            {
                ColorDialog colorDlg = new ColorDialog();
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    lifeGrid.GridColor = colorDlg.Color; // Sets a grid color
                }
                Invalidate(); // Forces paint event
            }
            else
            {
                MessageBox.Show("Cannot change grid color\n If grid is hidden!");
            }
        }

        // Changes the background color of the form
        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                // Checks if grid is currently hidden and sets the grid color to that color
                if (hideGridToolStripMenuItem.Text == "Show Grid")
                {
                    lifeGrid.GridColor = colorDlg.Color;
                    this.BackColor = colorDlg.Color;
                }
                else
                {
                    this.BackColor = colorDlg.Color; // Sets a new background color for this form
                }
            }
        }

        /* Survival Options are described here */

        // Change value of BMIN 
        private void editBMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog(this) == DialogResult.OK && form3.Value <= BMAX)
            {
                BMIN = form3.Value; // Retrieves value of form2
                BMINlbl.Text = String.Format("BMIN = {0}", BMIN);
            }
            else if (form3.DialogResult == DialogResult.OK && form3.Value > BMAX)
            {
                MessageBox.Show("BMIN cannot be greater than BMAX");
            }
            form3.Dispose();
        }

        // Change value of BMAX
        private void editBMAXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog(this) == DialogResult.OK && form3.Value >= BMIN)
            {
                BMAX = form3.Value; // Retrieves value of form2
                BMAXlbl.Text = String.Format("BMIN = {0}", BMAX);
            }
            else if (form3.DialogResult == DialogResult.OK && form3.Value < BMIN)
            {
                MessageBox.Show("BMAX cannot be less than BMIN");
            }
            form3.Dispose();
        }

        // Change value of SMIN 
        private void editSMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog(this) == DialogResult.OK && form3.Value <= SMAX)
            {
                SMIN = form3.Value; // Retrieves value of form2
                SMINlbl.Text = String.Format("SMIN = {0}", SMIN);
            }
            else if (form3.DialogResult == DialogResult.OK && form3.Value > SMAX)
            {
                MessageBox.Show("SMIN cannot be greater than SMAX");
            }
            form3.Dispose();
        }

        // Change value of SMAX
        private void editSMAXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog(this) == DialogResult.OK && form3.Value >= SMIN)
            {
                SMAX = form3.Value; // Retrieves value of form2
                SMAXlbl.Text = String.Format("BMIN = {0}", SMAX);
            }
            else if (form3.DialogResult == DialogResult.OK && form3.Value < SMIN)
            {
                MessageBox.Show("SMAX cannot less than SMIN");
            }
            form3.Dispose();
        }

        // Shows or hides the grid lines
        private void hideGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hides the grid lines if the lines are currently visible
            if (hideGridToolStripMenuItem.Text == "Hide Grid")
            {
                lifeGrid.TempGridColor = lifeGrid.GridColor;
                lifeGrid.GridColor = this.BackColor;
                hideGridToolStripMenuItem.Text = "Show Grid";
            }
            else // Shows the grid lines if the grid lines are not visible
            {
                lifeGrid.GridColor = lifeGrid.TempGridColor;
                hideGridToolStripMenuItem.Text = "Hide Grid";
            }
            Invalidate(); // Force repaint
        }


        // Timer tick used for evolution
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Tick is on and timer is enabled by start button
            cellArray = lifeGrid.Evolve(cellArray, BMIN, BMAX, SMIN, SMAX);
            UpdateCell();
            Invalidate();

        }

        // Creates cells when mouse is down and user is dragging across the grid
        private void mouseMove(object sender, MouseEventArgs e)
        {
            // These values are compared with the temporary row and col to not change state of cell if moving in same place
            float r = ((e.Y - menuStrip1.Height) / ((ClientSize.Height - menuStrip1.Height) / (float)row)); // Finds index of row
            float c = (e.X) / (ClientSize.Width / (float)col); // Finds index of col
            // Allows creation of cells if mouse is down
            if (e.Button == MouseButtons.Left && (tempR != (int)r | tempC != (int)c))
            {
                Form1_MouseDown(sender, e);
                tempR = (int)r;
                tempC = (int)c;
            }
        }

        // Starts/Stops the simulation
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Text == "Start")
            {
                timer1.Enabled = true;
                startToolStripMenuItem.Text = "Stop";
                startToolStripMenuItem.BackColor = Color.Red;
            }
            else
            {
                timer1.Enabled = false;
                startToolStripMenuItem.Text = "Start";
                startToolStripMenuItem.BackColor = Color.White;
            }
        }

        // Steps one generation and displays it
        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Will only step if the simulation is not currently running
            cellArray = lifeGrid.Evolve(cellArray, BMIN, BMAX, SMIN, SMAX);
            UpdateCell();
            Invalidate();
        }

        // Clears entire grid and creates new cell array
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Resets the start button if it is running
            if (startToolStripMenuItem.Text == "Stop")
            {
                timer1.Enabled = false;
                startToolStripMenuItem.Text = "Start";
                startToolStripMenuItem.BackColor = Color.White;
            }
            // Create new cell array
            cellArray = new Cell[row, col];
            Invalidate();
        }

        // Clears the grid, stop the simulation if it is running, and creates a new random grid
        private void randomizeCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearToolStripMenuItem_Click(sender, e); // Calls clear grid to stop simulation and clear
            cellArray = lifeGrid.Randomize(cellArray); // Create new random grid
            UpdateCell(); // Assign dimensions to the grid
            Invalidate(); // Force paint event
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void editEvolveRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            if (form5.ShowDialog(this) == DialogResult.OK)
            {
                evolveRate = form5.Value;
                timer1.Interval = 1000 / evolveRate; // Retrieves value of form5 and divides 1000 by it for tick rate
            }
            form5.Dispose();
        }

        private void currentSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Will show or hide the current settings on the top right corner of form
            if (currentSettingsToolStripMenuItem.Text == "Show Current Settings")
            {
                evolveLbl.Show();
                SMAXlbl.Show();
                SMINlbl.Show();
                BMAXlbl.Show();
                BMINlbl.Show();
                currentSettingsToolStripMenuItem.Text = "Hide Current Settings";
            }
            else
            {
                evolveLbl.Hide();
                SMAXlbl.Hide();
                SMINlbl.Hide();
                BMAXlbl.Hide();
                BMINlbl.Hide();
                currentSettingsToolStripMenuItem.Text = "Show Current Settings";
            }
        }
    }
}
