namespace PersuitSimulation
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.lblbomber = new System.Windows.Forms.Label();
            this.lblfighter = new System.Windows.Forms.Label();
            this.simoutput = new System.Windows.Forms.GroupBox();
            this.btnescape = new System.Windows.Forms.RadioButton();
            this.btndestroy = new System.Windows.Forms.RadioButton();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.StartSimMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TargetDestroyedMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TargetEscapedMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetSimulatorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Rocket = new System.Windows.Forms.PictureBox();
            this.Bomber = new System.Windows.Forms.PictureBox();
            this.Fighter = new System.Windows.Forms.PictureBox();
            this.btnstartsim = new System.Windows.Forms.Button();
            this.bg = new System.ComponentModel.BackgroundWorker();
            this.simoutput.SuspendLayout();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fighter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtoutput
            // 
            this.txtoutput.BackColor = System.Drawing.Color.Black;
            this.txtoutput.ForeColor = System.Drawing.Color.White;
            this.txtoutput.Location = new System.Drawing.Point(58, 261);
            this.txtoutput.MaxLength = 1000000;
            this.txtoutput.Multiline = true;
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.ReadOnly = true;
            this.txtoutput.ShortcutsEnabled = false;
            this.txtoutput.Size = new System.Drawing.Size(309, 69);
            this.txtoutput.TabIndex = 0;
            this.txtoutput.TabStop = false;
            this.txtoutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblbomber
            // 
            this.lblbomber.AutoSize = true;
            this.lblbomber.ForeColor = System.Drawing.Color.DimGray;
            this.lblbomber.Location = new System.Drawing.Point(212, 332);
            this.lblbomber.Name = "lblbomber";
            this.lblbomber.Size = new System.Drawing.Size(45, 15);
            this.lblbomber.TabIndex = 15;
            this.lblbomber.Text = "Bomber";
            // 
            // lblfighter
            // 
            this.lblfighter.AutoSize = true;
            this.lblfighter.Location = new System.Drawing.Point(168, 332);
            this.lblfighter.Name = "lblfighter";
            this.lblfighter.Size = new System.Drawing.Size(44, 15);
            this.lblfighter.TabIndex = 14;
            this.lblfighter.Text = "Fighter";
            // 
            // simoutput
            // 
            this.simoutput.Controls.Add(this.btnescape);
            this.simoutput.Controls.Add(this.btndestroy);
            this.simoutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.simoutput.Location = new System.Drawing.Point(58, 175);
            this.simoutput.Name = "simoutput";
            this.simoutput.Size = new System.Drawing.Size(309, 41);
            this.simoutput.TabIndex = 16;
            this.simoutput.TabStop = false;
            this.simoutput.Text = "Simulation Output";
            // 
            // btnescape
            // 
            this.btnescape.AutoSize = true;
            this.btnescape.ForeColor = System.Drawing.Color.Red;
            this.btnescape.Location = new System.Drawing.Point(169, 16);
            this.btnescape.Name = "btnescape";
            this.btnescape.Size = new System.Drawing.Size(104, 19);
            this.btnescape.TabIndex = 1;
            this.btnescape.TabStop = true;
            this.btnescape.Text = "Target Escaped";
            this.btnescape.UseVisualStyleBackColor = true;
            this.btnescape.CheckedChanged += new System.EventHandler(this.SimulationOutput_CheckedChanged);
            // 
            // btndestroy
            // 
            this.btndestroy.AutoSize = true;
            this.btndestroy.ForeColor = System.Drawing.Color.Lime;
            this.btndestroy.Location = new System.Drawing.Point(36, 16);
            this.btndestroy.Name = "btndestroy";
            this.btndestroy.Size = new System.Drawing.Size(114, 19);
            this.btndestroy.TabIndex = 0;
            this.btndestroy.TabStop = true;
            this.btndestroy.Text = "Target Destroyed";
            this.btndestroy.UseVisualStyleBackColor = true;
            this.btndestroy.CheckedChanged += new System.EventHandler(this.SimulationOutput_CheckedChanged);
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartSimMenu,
            this.ResetSimulatorMenu,
            this.DetailsMenu,
            this.QuitMenu,
            this.AboutMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(35, 6, 0, 2);
            this.MainMenu.ShowItemToolTips = true;
            this.MainMenu.Size = new System.Drawing.Size(424, 27);
            this.MainMenu.TabIndex = 17;
            this.MainMenu.Text = "MainMenu";
            // 
            // StartSimMenu
            // 
            this.StartSimMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TargetDestroyedMenu,
            this.TargetEscapedMenu});
            this.StartSimMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartSimMenu.Name = "StartSimMenu";
            this.StartSimMenu.Size = new System.Drawing.Size(103, 19);
            this.StartSimMenu.Text = "&Start Simulation";
            this.StartSimMenu.ToolTipText = "Begin simulation with built in data.";
            // 
            // TargetDestroyedMenu
            // 
            this.TargetDestroyedMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TargetDestroyedMenu.Name = "TargetDestroyedMenu";
            this.TargetDestroyedMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.TargetDestroyedMenu.Size = new System.Drawing.Size(206, 22);
            this.TargetDestroyedMenu.Text = "&Target Destroyed";
            this.TargetDestroyedMenu.ToolTipText = "Simulate a target destroyed solution";
            this.TargetDestroyedMenu.Click += new System.EventHandler(this.TargetDestroyedMenu_Click);
            // 
            // TargetEscapedMenu
            // 
            this.TargetEscapedMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TargetEscapedMenu.Name = "TargetEscapedMenu";
            this.TargetEscapedMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.TargetEscapedMenu.Size = new System.Drawing.Size(206, 22);
            this.TargetEscapedMenu.Text = "&Target Escaped";
            this.TargetEscapedMenu.ToolTipText = "Simulate a target escaped solution";
            this.TargetEscapedMenu.Click += new System.EventHandler(this.TargetEscapedMenu_Click);
            // 
            // ResetSimulatorMenu
            // 
            this.ResetSimulatorMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ResetSimulatorMenu.Name = "ResetSimulatorMenu";
            this.ResetSimulatorMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ResetSimulatorMenu.Size = new System.Drawing.Size(101, 19);
            this.ResetSimulatorMenu.Text = "&Reset Simulator";
            this.ResetSimulatorMenu.ToolTipText = "Reset the simulator to it\'s default state";
            this.ResetSimulatorMenu.Click += new System.EventHandler(this.ResetSimulatorMenu_Click);
            // 
            // DetailsMenu
            // 
            this.DetailsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DetailsMenu.Name = "DetailsMenu";
            this.DetailsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.DetailsMenu.Size = new System.Drawing.Size(54, 19);
            this.DetailsMenu.Text = "&Details";
            this.DetailsMenu.ToolTipText = "Simulation Model ( Assumptions, Calculations, Flowchart, C++ code )";
            this.DetailsMenu.Click += new System.EventHandler(this.DetailsMenu_Click);
            // 
            // QuitMenu
            // 
            this.QuitMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.QuitMenu.Name = "QuitMenu";
            this.QuitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.QuitMenu.Size = new System.Drawing.Size(42, 19);
            this.QuitMenu.Text = "&Quit";
            this.QuitMenu.ToolTipText = "Exit Persuit Simulator";
            this.QuitMenu.Click += new System.EventHandler(this.QuitMenu_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(52, 19);
            this.AboutMenu.Text = "About";
            this.AboutMenu.ToolTipText = "About Persit Simulator";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // Rocket
            // 
            this.Rocket.Image = global::PersuitSimulator.Properties.Resources.Rocket;
            this.Rocket.Location = new System.Drawing.Point(193, 86);
            this.Rocket.Name = "Rocket";
            this.Rocket.Size = new System.Drawing.Size(35, 27);
            this.Rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Rocket.TabIndex = 13;
            this.Rocket.TabStop = false;
            // 
            // Bomber
            // 
            this.Bomber.Image = ((System.Drawing.Image)(resources.GetObject("Bomber.Image")));
            this.Bomber.Location = new System.Drawing.Point(257, 74);
            this.Bomber.Name = "Bomber";
            this.Bomber.Size = new System.Drawing.Size(64, 64);
            this.Bomber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bomber.TabIndex = 12;
            this.Bomber.TabStop = false;
            // 
            // Fighter
            // 
            this.Fighter.Image = ((System.Drawing.Image)(resources.GetObject("Fighter.Image")));
            this.Fighter.Location = new System.Drawing.Point(104, 74);
            this.Fighter.Name = "Fighter";
            this.Fighter.Size = new System.Drawing.Size(64, 64);
            this.Fighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Fighter.TabIndex = 11;
            this.Fighter.TabStop = false;
            // 
            // btnstartsim
            // 
            this.btnstartsim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnstartsim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstartsim.Location = new System.Drawing.Point(147, 222);
            this.btnstartsim.Name = "btnstartsim";
            this.btnstartsim.Size = new System.Drawing.Size(131, 33);
            this.btnstartsim.TabIndex = 1;
            this.btnstartsim.Text = "Start Simulation";
            this.btnstartsim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstartsim.UseVisualStyleBackColor = true;
            this.btnstartsim.Click += new System.EventHandler(this.btnStartSim_Click);
            // 
            // bg
            // 
            this.bg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_DoWork);
            this.bg.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_RunWorkerCompleted);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 350);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Rocket);
            this.Controls.Add(this.simoutput);
            this.Controls.Add(this.lblbomber);
            this.Controls.Add(this.lblfighter);
            this.Controls.Add(this.Bomber);
            this.Controls.Add(this.Fighter);
            this.Controls.Add(this.btnstartsim);
            this.Controls.Add(this.txtoutput);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persuit Simulator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.simoutput.ResumeLayout(false);
            this.simoutput.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fighter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.Button btnstartsim;
        private System.Windows.Forms.PictureBox Bomber;
        private System.Windows.Forms.PictureBox Rocket;
        private System.Windows.Forms.PictureBox Fighter;
        private System.Windows.Forms.Label lblbomber;
        private System.Windows.Forms.Label lblfighter;
        private System.Windows.Forms.GroupBox simoutput;
        private System.Windows.Forms.RadioButton btnescape;
        private System.Windows.Forms.RadioButton btndestroy;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem StartSimMenu;
        private System.Windows.Forms.ToolStripMenuItem ResetSimulatorMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.ToolStripMenuItem TargetDestroyedMenu;
        private System.Windows.Forms.ToolStripMenuItem TargetEscapedMenu;
        private System.Windows.Forms.ToolStripMenuItem DetailsMenu;
        private System.Windows.Forms.ToolStripMenuItem QuitMenu;
        private System.ComponentModel.BackgroundWorker bg;
    }
}

