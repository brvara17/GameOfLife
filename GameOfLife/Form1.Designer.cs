namespace PA_06
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
            this.menuStrip_Heading = new System.Windows.Forms.MenuStrip();
            this.displaySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSetGridRows = new System.Windows.Forms.ToolStripTextBox();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSetGridColumns = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gridOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorGray = new System.Windows.Forms.ToolStripMenuItem();
            this.setTooStriplGridColor = new System.Windows.Forms.ToolStripMenuItem();
            this.setCreatureColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEvolSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEvolRate = new System.Windows.Forms.ToolStripTextBox();
            this.evolutionParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopEvolutionProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.singleStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeCellStatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Heading.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Heading
            // 
            this.menuStrip_Heading.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip_Heading.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_Heading.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaySettingsToolStripMenuItem,
            this.toolStripEvolSetting,
            this.simulationToolStripMenuItem});
            this.menuStrip_Heading.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Heading.Name = "menuStrip_Heading";
            this.menuStrip_Heading.Size = new System.Drawing.Size(759, 33);
            this.menuStrip_Heading.TabIndex = 0;
            this.menuStrip_Heading.Text = "Evolution Settings";
            // 
            // displaySettingsToolStripMenuItem
            // 
            this.displaySettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowsToolStripMenuItem,
            this.columnsToolStripMenuItem,
            this.toolStripSeparator3,
            this.gridOToolStripMenuItem,
            this.clearGridToolStripMenuItem,
            this.toolStripSeparator2,
            this.setBackgroundColorToolStripMenuItem,
            this.setTooStriplGridColor,
            this.setCreatureColorToolStripMenuItem});
            this.displaySettingsToolStripMenuItem.Name = "displaySettingsToolStripMenuItem";
            this.displaySettingsToolStripMenuItem.Size = new System.Drawing.Size(151, 29);
            this.displaySettingsToolStripMenuItem.Text = "Display Settings";
            // 
            // rowsToolStripMenuItem
            // 
            this.rowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSetGridRows});
            this.rowsToolStripMenuItem.Name = "rowsToolStripMenuItem";
            this.rowsToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.rowsToolStripMenuItem.Text = "Rows";
            // 
            // toolStripTextBoxSetGridRows
            // 
            this.toolStripTextBoxSetGridRows.Name = "toolStripTextBoxSetGridRows";
            this.toolStripTextBoxSetGridRows.Size = new System.Drawing.Size(100, 31);
            this.toolStripTextBoxSetGridRows.Click += new System.EventHandler(this.toolStripTextBoxSetGridRows_Click);
            this.toolStripTextBoxSetGridRows.TextChanged += new System.EventHandler(this.toolStripTextBoxSetGridRows_TextChanged);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSetGridColumns});
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.columnsToolStripMenuItem.Text = "Columns";
            // 
            // toolStripTextBoxSetGridColumns
            // 
            this.toolStripTextBoxSetGridColumns.Name = "toolStripTextBoxSetGridColumns";
            this.toolStripTextBoxSetGridColumns.Size = new System.Drawing.Size(100, 31);
            this.toolStripTextBoxSetGridColumns.Click += new System.EventHandler(this.toolStripTextBoxSetGridColumns_Click);
            this.toolStripTextBoxSetGridColumns.TextChanged += new System.EventHandler(this.toolStripTextBoxSetGridColumns_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(267, 6);
            // 
            // gridOToolStripMenuItem
            // 
            this.gridOToolStripMenuItem.CheckOnClick = true;
            this.gridOToolStripMenuItem.Name = "gridOToolStripMenuItem";
            this.gridOToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.gridOToolStripMenuItem.Text = "Grid On";
            this.gridOToolStripMenuItem.Click += new System.EventHandler(this.gridOToolStripMenuItem_Click);
            // 
            // clearGridToolStripMenuItem
            // 
            this.clearGridToolStripMenuItem.Name = "clearGridToolStripMenuItem";
            this.clearGridToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.clearGridToolStripMenuItem.Text = "Clear Grid";
            this.clearGridToolStripMenuItem.Click += new System.EventHandler(this.clearGridToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // setBackgroundColorToolStripMenuItem
            // 
            this.setBackgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorWhite,
            this.backgroundColorGray});
            this.setBackgroundColorToolStripMenuItem.Name = "setBackgroundColorToolStripMenuItem";
            this.setBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.setBackgroundColorToolStripMenuItem.Text = "Set Background Color";
            // 
            // backgroundColorWhite
            // 
            this.backgroundColorWhite.CheckOnClick = true;
            this.backgroundColorWhite.Name = "backgroundColorWhite";
            this.backgroundColorWhite.Size = new System.Drawing.Size(143, 30);
            this.backgroundColorWhite.Text = "White";
            // 
            // backgroundColorGray
            // 
            this.backgroundColorGray.Name = "backgroundColorGray";
            this.backgroundColorGray.Size = new System.Drawing.Size(143, 30);
            this.backgroundColorGray.Text = "Gray";
            // 
            // setTooStriplGridColor
            // 
            this.setTooStriplGridColor.Name = "setTooStriplGridColor";
            this.setTooStriplGridColor.Size = new System.Drawing.Size(270, 30);
            this.setTooStriplGridColor.Text = "Set Grid Color";
            // 
            // setCreatureColorToolStripMenuItem
            // 
            this.setCreatureColorToolStripMenuItem.Name = "setCreatureColorToolStripMenuItem";
            this.setCreatureColorToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.setCreatureColorToolStripMenuItem.Text = "Set Creature Color";
            // 
            // toolStripEvolSetting
            // 
            this.toolStripEvolSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.evolutionParametersToolStripMenuItem});
            this.toolStripEvolSetting.Name = "toolStripEvolSetting";
            this.toolStripEvolSetting.Size = new System.Drawing.Size(167, 29);
            this.toolStripEvolSetting.Text = "Evolution Settings";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEvolRate});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 30);
            this.toolStripMenuItem1.Text = "Evolution Rate";
            // 
            // toolStripEvolRate
            // 
            this.toolStripEvolRate.Name = "toolStripEvolRate";
            this.toolStripEvolRate.Size = new System.Drawing.Size(100, 31);
            this.toolStripEvolRate.Text = "Insert Rate";
            this.toolStripEvolRate.Click += new System.EventHandler(this.toolStripEvolRate_Click);
            // 
            // evolutionParametersToolStripMenuItem
            // 
            this.evolutionParametersToolStripMenuItem.Name = "evolutionParametersToolStripMenuItem";
            this.evolutionParametersToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.evolutionParametersToolStripMenuItem.Text = "Evolution Parameters";
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startEToolStripMenuItem,
            this.stopEvolutionProcessToolStripMenuItem,
            this.toolStripSeparator1,
            this.singleStepToolStripMenuItem,
            this.randomizeCellStatesToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // startEToolStripMenuItem
            // 
            this.startEToolStripMenuItem.Name = "startEToolStripMenuItem";
            this.startEToolStripMenuItem.Size = new System.Drawing.Size(279, 30);
            this.startEToolStripMenuItem.Text = "Start Evolution Process";
            // 
            // stopEvolutionProcessToolStripMenuItem
            // 
            this.stopEvolutionProcessToolStripMenuItem.Name = "stopEvolutionProcessToolStripMenuItem";
            this.stopEvolutionProcessToolStripMenuItem.Size = new System.Drawing.Size(279, 30);
            this.stopEvolutionProcessToolStripMenuItem.Text = "Stop Evolution Process";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(276, 6);
            // 
            // singleStepToolStripMenuItem
            // 
            this.singleStepToolStripMenuItem.Name = "singleStepToolStripMenuItem";
            this.singleStepToolStripMenuItem.Size = new System.Drawing.Size(279, 30);
            this.singleStepToolStripMenuItem.Text = "Single-Step Evolution";
            // 
            // randomizeCellStatesToolStripMenuItem
            // 
            this.randomizeCellStatesToolStripMenuItem.Name = "randomizeCellStatesToolStripMenuItem";
            this.randomizeCellStatesToolStripMenuItem.Size = new System.Drawing.Size(279, 30);
            this.randomizeCellStatesToolStripMenuItem.Text = "Randomize Cell States";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 552);
            this.Controls.Add(this.menuStrip_Heading);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip_Heading;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip_Heading.ResumeLayout(false);
            this.menuStrip_Heading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Heading;
        private System.Windows.Forms.ToolStripMenuItem toolStripEvolSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displaySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCreatureColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTooStriplGridColor;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorWhite;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorGray;
        private System.Windows.Forms.ToolStripMenuItem evolutionParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopEvolutionProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleStepToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripEvolRate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem randomizeCellStatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSetGridRows;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSetGridColumns;
        
    }
}

