namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dimensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deadCellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridLineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.survivalOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBMAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSMAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEvolveRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.evolveLbl = new System.Windows.Forms.Label();
            this.SMAXlbl = new System.Windows.Forms.Label();
            this.SMINlbl = new System.Windows.Forms.Label();
            this.BMAXlbl = new System.Windows.Forms.Label();
            this.BMINlbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dimensionsToolStripMenuItem,
            this.survivalOptionsToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stepToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.randomizeCellsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dimensionsToolStripMenuItem
            // 
            this.dimensionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowsToolStripMenuItem,
            this.columnsToolStripMenuItem,
            this.hideGridToolStripMenuItem});
            this.dimensionsToolStripMenuItem.Name = "dimensionsToolStripMenuItem";
            this.dimensionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.dimensionsToolStripMenuItem.Text = "Grid Options";
            // 
            // rowsToolStripMenuItem
            // 
            this.rowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRowsToolStripMenuItem,
            this.editColumnsToolStripMenuItem});
            this.rowsToolStripMenuItem.Name = "rowsToolStripMenuItem";
            this.rowsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.rowsToolStripMenuItem.Text = "Dimensions";
            // 
            // editRowsToolStripMenuItem
            // 
            this.editRowsToolStripMenuItem.Name = "editRowsToolStripMenuItem";
            this.editRowsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.editRowsToolStripMenuItem.Text = "Edit Rows";
            this.editRowsToolStripMenuItem.Click += new System.EventHandler(this.editRowsToolStripMenuItem_Click);
            // 
            // editColumnsToolStripMenuItem
            // 
            this.editColumnsToolStripMenuItem.Name = "editColumnsToolStripMenuItem";
            this.editColumnsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.editColumnsToolStripMenuItem.Text = "Edit Columns";
            this.editColumnsToolStripMenuItem.Click += new System.EventHandler(this.editColumnsToolStripMenuItem_Click);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cellColorToolStripMenuItem,
            this.deadCellColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.gridLineColorToolStripMenuItem});
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.columnsToolStripMenuItem.Text = "Color Options";
            // 
            // cellColorToolStripMenuItem
            // 
            this.cellColorToolStripMenuItem.Name = "cellColorToolStripMenuItem";
            this.cellColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cellColorToolStripMenuItem.Text = "Cell Color";
            this.cellColorToolStripMenuItem.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
            // 
            // deadCellColorToolStripMenuItem
            // 
            this.deadCellColorToolStripMenuItem.Name = "deadCellColorToolStripMenuItem";
            this.deadCellColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.deadCellColorToolStripMenuItem.Text = "Dead Cell Color";
            this.deadCellColorToolStripMenuItem.Click += new System.EventHandler(this.deadCellColorToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // gridLineColorToolStripMenuItem
            // 
            this.gridLineColorToolStripMenuItem.Name = "gridLineColorToolStripMenuItem";
            this.gridLineColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gridLineColorToolStripMenuItem.Text = "Grid Line Color";
            this.gridLineColorToolStripMenuItem.Click += new System.EventHandler(this.gridLineColorToolStripMenuItem_Click);
            // 
            // hideGridToolStripMenuItem
            // 
            this.hideGridToolStripMenuItem.Name = "hideGridToolStripMenuItem";
            this.hideGridToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.hideGridToolStripMenuItem.Text = "Hide Grid";
            this.hideGridToolStripMenuItem.Click += new System.EventHandler(this.hideGridToolStripMenuItem_Click);
            // 
            // survivalOptionsToolStripMenuItem
            // 
            this.survivalOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBMINToolStripMenuItem,
            this.editBMAXToolStripMenuItem,
            this.editSMINToolStripMenuItem,
            this.editSMAXToolStripMenuItem,
            this.editEvolveRateToolStripMenuItem,
            this.currentSettingsToolStripMenuItem});
            this.survivalOptionsToolStripMenuItem.Name = "survivalOptionsToolStripMenuItem";
            this.survivalOptionsToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.survivalOptionsToolStripMenuItem.Text = "Survival Options";
            // 
            // editBMINToolStripMenuItem
            // 
            this.editBMINToolStripMenuItem.Name = "editBMINToolStripMenuItem";
            this.editBMINToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.editBMINToolStripMenuItem.Text = "Edit BMIN";
            this.editBMINToolStripMenuItem.Click += new System.EventHandler(this.editBMINToolStripMenuItem_Click);
            // 
            // editBMAXToolStripMenuItem
            // 
            this.editBMAXToolStripMenuItem.Name = "editBMAXToolStripMenuItem";
            this.editBMAXToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.editBMAXToolStripMenuItem.Text = "Edit BMAX";
            this.editBMAXToolStripMenuItem.Click += new System.EventHandler(this.editBMAXToolStripMenuItem_Click);
            // 
            // editSMINToolStripMenuItem
            // 
            this.editSMINToolStripMenuItem.Name = "editSMINToolStripMenuItem";
            this.editSMINToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.editSMINToolStripMenuItem.Text = "Edit SMIN";
            this.editSMINToolStripMenuItem.Click += new System.EventHandler(this.editSMINToolStripMenuItem_Click);
            // 
            // editSMAXToolStripMenuItem
            // 
            this.editSMAXToolStripMenuItem.Name = "editSMAXToolStripMenuItem";
            this.editSMAXToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.editSMAXToolStripMenuItem.Text = "Edit SMAX";
            this.editSMAXToolStripMenuItem.Click += new System.EventHandler(this.editSMAXToolStripMenuItem_Click);
            // 
            // editEvolveRateToolStripMenuItem
            // 
            this.editEvolveRateToolStripMenuItem.Name = "editEvolveRateToolStripMenuItem";
            this.editEvolveRateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.editEvolveRateToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.editEvolveRateToolStripMenuItem.Text = "Edit Evolve Rate";
            this.editEvolveRateToolStripMenuItem.Click += new System.EventHandler(this.editEvolveRateToolStripMenuItem_Click);
            // 
            // currentSettingsToolStripMenuItem
            // 
            this.currentSettingsToolStripMenuItem.Name = "currentSettingsToolStripMenuItem";
            this.currentSettingsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.currentSettingsToolStripMenuItem.Text = "Show Current Settings";
            this.currentSettingsToolStripMenuItem.Click += new System.EventHandler(this.currentSettingsToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.stepToolStripMenuItem.Text = "Step";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // randomizeCellsToolStripMenuItem
            // 
            this.randomizeCellsToolStripMenuItem.Name = "randomizeCellsToolStripMenuItem";
            this.randomizeCellsToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.randomizeCellsToolStripMenuItem.Text = "Randomize Cells";
            this.randomizeCellsToolStripMenuItem.Click += new System.EventHandler(this.randomizeCellsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // evolveLbl
            // 
            this.evolveLbl.AutoSize = true;
            this.evolveLbl.BackColor = System.Drawing.Color.Transparent;
            this.evolveLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.evolveLbl.Location = new System.Drawing.Point(631, 24);
            this.evolveLbl.Name = "evolveLbl";
            this.evolveLbl.Size = new System.Drawing.Size(35, 13);
            this.evolveLbl.TabIndex = 1;
            this.evolveLbl.Text = "label1";
            this.evolveLbl.Visible = false;
            // 
            // SMAXlbl
            // 
            this.SMAXlbl.AutoSize = true;
            this.SMAXlbl.BackColor = System.Drawing.Color.Transparent;
            this.SMAXlbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.SMAXlbl.Location = new System.Drawing.Point(596, 24);
            this.SMAXlbl.Name = "SMAXlbl";
            this.SMAXlbl.Size = new System.Drawing.Size(35, 13);
            this.SMAXlbl.TabIndex = 2;
            this.SMAXlbl.Text = "label2";
            this.SMAXlbl.Visible = false;
            // 
            // SMINlbl
            // 
            this.SMINlbl.AutoSize = true;
            this.SMINlbl.BackColor = System.Drawing.Color.Transparent;
            this.SMINlbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.SMINlbl.Location = new System.Drawing.Point(561, 24);
            this.SMINlbl.Name = "SMINlbl";
            this.SMINlbl.Size = new System.Drawing.Size(35, 13);
            this.SMINlbl.TabIndex = 3;
            this.SMINlbl.Text = "label3";
            this.SMINlbl.Visible = false;
            // 
            // BMAXlbl
            // 
            this.BMAXlbl.AutoSize = true;
            this.BMAXlbl.BackColor = System.Drawing.Color.Transparent;
            this.BMAXlbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.BMAXlbl.Location = new System.Drawing.Point(526, 24);
            this.BMAXlbl.Name = "BMAXlbl";
            this.BMAXlbl.Size = new System.Drawing.Size(35, 13);
            this.BMAXlbl.TabIndex = 4;
            this.BMAXlbl.Text = "label4";
            this.BMAXlbl.Visible = false;
            // 
            // BMINlbl
            // 
            this.BMINlbl.AutoSize = true;
            this.BMINlbl.BackColor = System.Drawing.Color.Transparent;
            this.BMINlbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.BMINlbl.Location = new System.Drawing.Point(491, 24);
            this.BMINlbl.Name = "BMINlbl";
            this.BMINlbl.Size = new System.Drawing.Size(35, 13);
            this.BMINlbl.TabIndex = 5;
            this.BMINlbl.Text = "label5";
            this.BMINlbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 393);
            this.Controls.Add(this.BMINlbl);
            this.Controls.Add(this.BMAXlbl);
            this.Controls.Add(this.SMINlbl);
            this.Controls.Add(this.SMAXlbl);
            this.Controls.Add(this.evolveLbl);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game of Life - Brian Pham (817196725)";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dimensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem survivalOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBMAXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSMAXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridLineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideGridToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem deadCellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEvolveRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentSettingsToolStripMenuItem;
        private System.Windows.Forms.Label evolveLbl;
        private System.Windows.Forms.Label SMAXlbl;
        private System.Windows.Forms.Label SMINlbl;
        private System.Windows.Forms.Label BMAXlbl;
        private System.Windows.Forms.Label BMINlbl;
    }
}

