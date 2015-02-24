namespace About
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.txtinfo = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCopyRight = new System.Windows.Forms.Label();
            this.border.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtinfo
            // 
            this.txtinfo.BackColor = System.Drawing.Color.Transparent;
            this.txtinfo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtinfo.ForeColor = System.Drawing.Color.Blue;
            this.txtinfo.Location = new System.Drawing.Point(35, 27);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(79, 120);
            this.txtinfo.TabIndex = 1;
            this.txtinfo.Text = "Name\r\nSubject\r\nCompiler\r\nLanguage\r\nDeveloper\r\nSupervisor";
            this.txtinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtinfo.Click += new System.EventHandler(this.abouttxt_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Transparent;
            this.txtname.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtname.Location = new System.Drawing.Point(111, -4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(134, 32);
            this.txtname.TabIndex = 2;
            this.txtname.Text = "Persuit Simulator";
            this.txtname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtname.Click += new System.EventHandler(this.abouttxt_Click);
            // 
            // border
            // 
            this.border.Controls.Add(this.label1);
            this.border.Controls.Add(this.txtCopyRight);
            this.border.Controls.Add(this.txtinfo);
            this.border.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.border.Location = new System.Drawing.Point(4, 3);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(348, 192);
            this.border.TabIndex = 3;
            this.border.TabStop = false;
            this.border.Enter += new System.EventHandler(this.abouttxt_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(111, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 120);
            this.label1.TabIndex = 3;
            this.label1.Text = "Persuit Study Case Simulator\r\nModeling and Simulation\r\nMicrosoft Visual C# 2008\r\n" +
                "Visual C#\r\nMohamed Ahmed Abdel Fattah\r\nDr.Mohamed Abdel Fattah";
            this.label1.Click += new System.EventHandler(this.abouttxt_Click);
            // 
            // txtCopyRight
            // 
            this.txtCopyRight.AutoSize = true;
            this.txtCopyRight.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCopyRight.Location = new System.Drawing.Point(24, 167);
            this.txtCopyRight.Name = "txtCopyRight";
            this.txtCopyRight.Size = new System.Drawing.Size(319, 20);
            this.txtCopyRight.TabIndex = 2;
            this.txtCopyRight.Text = "Copyright © - DarkOS 2011, All Rights Reserved.";
            this.txtCopyRight.Click += new System.EventHandler(this.abouttxt_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(356, 201);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.border);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Persuit Simulator";
            this.Click += new System.EventHandler(this.abouttxt_Click);
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtinfo;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.GroupBox border;
        private System.Windows.Forms.Label txtCopyRight;
        private System.Windows.Forms.Label label1;

    }
}