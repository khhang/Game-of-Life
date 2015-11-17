using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    // This class will hold the row and column component for the location of points on the grid
    // This will also be used to evolve the grid between generations
    class Grid
    {
        int row;
        int col;
        Color cellColor = Color.Green;
        Color gridColor = Color.LightGray;
        Color deadCellColor = Color.Red;
        Color tempGridColor = Color.LightGray;
        
        // Explicit value constructor
        public Grid(int r, int c)
        {
            row = r;
            col = c;
        }

        // Default constructor
        public Grid()
        {
            row = 0;
            col = 0;
        }

        // Creates the grid given row and col amount, width, height and drawing surface
        public void createGrid(int r, int c, int width, int height, int mHeight, Graphics g)
        {
            Pen pen = new Pen(gridColor, 1);
            float cellWidth = width / (float)c;
            float cellHeight = (height-mHeight) / (float)r;
            // Draws the rows of the grid while taking into account space of menustrip
            for (int i = 1; i < row; i++)
                g.DrawLine(pen, 0, (cellHeight * i) + mHeight, width, (cellHeight * i) + mHeight);

            // Draws the columns of the grid
            for(int i = 1; i < col; i++)
                g.DrawLine(pen, cellWidth*i, 0, cellWidth*i, height);
        }

        // Draws current state of the cells
        public void drawCells(Cell[,] cellArray, Graphics g)
        {
            Brush brush = new SolidBrush(cellColor);
            Brush deadBrush = new SolidBrush(deadCellColor);
            foreach(Cell cell in cellArray)
            {
                if (cell != null && cell.IsAlive)
                {
                    RectangleF rect = new RectangleF(cell.CellX, cell.CellY, cell.CellWidth, cell.CellHeight);
                    g.FillRectangle(brush, rect);
                }
                else if (cell != null && !(cell.IsAlive))
                {
                    RectangleF rect = new RectangleF(cell.CellX, cell.CellY, cell.CellWidth, cell.CellHeight);
                    g.FillRectangle(deadBrush, rect);
                }
            }
        }

        // Count # of neighbours to determine a birth or survival
        public int countNeighbours(Cell[,] cellArray, int r, int c)
        {
            int count = 0;
            int cN; // Used to calculate col or row loop around
            int rN;

            // These values are used to calculate col and row loop around
            if(c - 1 < 0)
            {
                cN = (col - 1);
            }
            else
            {
                cN = c - 1;
            }

            if(r - 1 < 0)
            {
                rN = (row - 1);
            }
            else
            {
                rN = r - 1;
            }

            // Neighbour 1
            if (cellArray[r, (cN) % col] != null && cellArray[r,(cN)%col].IsAlive)
                count++;
            // Neighbour 2
            if (cellArray[(rN) % row, (cN) % col] != null && cellArray[(rN)%row,(cN)%col].IsAlive)
                count++;
            // Neighbour 3
            if (cellArray[(rN) % row, c] != null && cellArray[(rN)%row,c].IsAlive)
                count++;
            // Neighbour 4
            if (cellArray[(rN) % row, (c + 1) % col] != null && cellArray[(rN)%row,(c+1)%col].IsAlive)
                count++;
            // Neighbour 5
            if (cellArray[r, (c + 1) % col] != null && cellArray[r,(c+1)%col].IsAlive)
                count++;
            // Neighbour 6
            if (cellArray[(r + 1) % row, (c+1) % col] != null && cellArray[(r+1)%row,(c+1)%col].IsAlive)
                count++;
            // Neighbour 7
            if (cellArray[(r + 1) % row, c] != null && cellArray[(r+1)%row,c].IsAlive)
                count++;
            // Neighbour 8
            if (cellArray[(r + 1) % row, (cN) % col] != null && cellArray[(r+1)%row,(cN)%col].IsAlive)
                count++;

            return count;
        }

        // Evolve to next generation
        public Cell[,] Evolve(Cell[,] cellArray, int bmin, int bmax, int smin, int smax)
        {
            Cell[,] nextGen = new Cell[row, col];
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    int count = countNeighbours(cellArray, i, j);
                    // Check Birth law if cell is empty
                    if (cellArray[i,j] == null || (cellArray[i, j] != null && !(cellArray[i, j].IsAlive)))
                    {
                        if(count >= bmin && count <= bmax)
                        {
                            // Create new Cell at location (birth)
                            nextGen[i, j] = new Cell(true, 0, 0, 0, 0);
                        }
                        else if(cellArray[i, j] != null && !(cellArray[i, j].IsAlive))
                        {
                            // If cell is dead and does not meet birth conditions, remain dead
                            nextGen[i, j] = new Cell(false, 0, 0, 0, 0);
                        }
                    }
                    // Check Survival law if cell is alive  
                    else if (cellArray[i,j] != null && cellArray[i, j].IsAlive)
                    {
                        //int count = countNeighbours(cellArray, i, j);
                        if (count >= smin && count <= smax)
                        {
                            // Survives into next generation
                            nextGen[i, j] = new Cell(true, 0, 0, 0, 0);
                        }
                        else
                        {
                            // If conditions arent met, cell dies in next generation
                            nextGen[i, j] = new Cell(false, 0, 0, 0, 0);
                        }
                    }
                    // If cell is already dead, remain dead in next generation unless exactly 3 live neighbours
                }
            }
            return nextGen;
        }

        // Will randomize the creation of cells
        public Cell[,] Randomize(Cell[,] cellArray)
        {
            Cell[,] randomCell = new Cell[row, col];
            Random r = new Random();
            int rV = 0;
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    rV = r.Next(1, 1000);
                    if(rV >= 0 && rV <= 100)
                    {
                        randomCell[i, j] = new Cell(true, 0, 0, 0, 0);
                    }
                    else if (rV > 100 && rV <= 150)
                    {
                        randomCell[i, j] = new Cell(false, 0, 0, 0, 0);
                    }
                }

            }
            return randomCell;
        }

        // Properties of Grid
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public int Col
        {
            get { return col; }
            set { col = value; }
        }

        public Color CellColor
        {
            get { return cellColor; }
            set { cellColor = value; }
        }

        public Color DeadCellColor
        {
            get { return deadCellColor; }
            set { deadCellColor = value; }
        }

        public Color GridColor
        {
            get { return gridColor; }
            set { gridColor = value; }
        }

        public Color TempGridColor
        {
            get { return tempGridColor; }
            set { tempGridColor = value; }
        }
    }
}
