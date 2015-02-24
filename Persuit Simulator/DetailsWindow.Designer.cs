namespace PersuitSimulator
{
    partial class DetailsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsWindow));
            this.DetailsTab = new System.Windows.Forms.TabControl();
            this.AssumptionsTab = new System.Windows.Forms.TabPage();
            this.txtassumptions = new System.Windows.Forms.RichTextBox();
            this.CalculationsTab = new System.Windows.Forms.TabPage();
            this.TriangleBox = new System.Windows.Forms.PictureBox();
            this.txtcalculations = new System.Windows.Forms.RichTextBox();
            this.FlowchartTab = new System.Windows.Forms.TabPage();
            this.FlowchartBox = new System.Windows.Forms.PictureBox();
            this.CodeTab = new System.Windows.Forms.TabPage();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.DetailsTab.SuspendLayout();
            this.AssumptionsTab.SuspendLayout();
            this.CalculationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleBox)).BeginInit();
            this.FlowchartTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlowchartBox)).BeginInit();
            this.CodeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailsTab
            // 
            this.DetailsTab.Controls.Add(this.AssumptionsTab);
            this.DetailsTab.Controls.Add(this.CalculationsTab);
            this.DetailsTab.Controls.Add(this.FlowchartTab);
            this.DetailsTab.Controls.Add(this.CodeTab);
            this.DetailsTab.Location = new System.Drawing.Point(1, 0);
            this.DetailsTab.Multiline = true;
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.SelectedIndex = 0;
            this.DetailsTab.Size = new System.Drawing.Size(617, 453);
            this.DetailsTab.TabIndex = 3;
            // 
            // AssumptionsTab
            // 
            this.AssumptionsTab.Controls.Add(this.txtassumptions);
            this.AssumptionsTab.Location = new System.Drawing.Point(4, 22);
            this.AssumptionsTab.Name = "AssumptionsTab";
            this.AssumptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AssumptionsTab.Size = new System.Drawing.Size(609, 427);
            this.AssumptionsTab.TabIndex = 0;
            this.AssumptionsTab.Text = "Assumptions";
            this.AssumptionsTab.UseVisualStyleBackColor = true;
            // 
            // txtassumptions
            // 
            this.txtassumptions.BackColor = System.Drawing.SystemColors.Window;
            this.txtassumptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtassumptions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtassumptions.Location = new System.Drawing.Point(-4, 6);
            this.txtassumptions.Name = "txtassumptions";
            this.txtassumptions.ReadOnly = true;
            this.txtassumptions.Size = new System.Drawing.Size(613, 421);
            this.txtassumptions.TabIndex = 0;
            this.txtassumptions.Text = resources.GetString("txtassumptions.Text");
            // 
            // CalculationsTab
            // 
            this.CalculationsTab.AutoScroll = true;
            this.CalculationsTab.Controls.Add(this.TriangleBox);
            this.CalculationsTab.Controls.Add(this.txtcalculations);
            this.CalculationsTab.Location = new System.Drawing.Point(4, 22);
            this.CalculationsTab.Name = "CalculationsTab";
            this.CalculationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CalculationsTab.Size = new System.Drawing.Size(609, 427);
            this.CalculationsTab.TabIndex = 1;
            this.CalculationsTab.Text = "Calculations";
            this.CalculationsTab.UseVisualStyleBackColor = true;
            // 
            // TriangleBox
            // 
            this.TriangleBox.Image = global::PersuitSimulator.Properties.Resources.Triangle;
            this.TriangleBox.Location = new System.Drawing.Point(80, 454);
            this.TriangleBox.Name = "TriangleBox";
            this.TriangleBox.Size = new System.Drawing.Size(432, 284);
            this.TriangleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TriangleBox.TabIndex = 4;
            this.TriangleBox.TabStop = false;
            // 
            // txtcalculations
            // 
            this.txtcalculations.BackColor = System.Drawing.SystemColors.Window;
            this.txtcalculations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcalculations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtcalculations.Location = new System.Drawing.Point(5, 6);
            this.txtcalculations.Name = "txtcalculations";
            this.txtcalculations.ReadOnly = true;
            this.txtcalculations.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtcalculations.Size = new System.Drawing.Size(582, 382);
            this.txtcalculations.TabIndex = 1;
            this.txtcalculations.Text = resources.GetString("txtcalculations.Text");
            // 
            // FlowchartTab
            // 
            this.FlowchartTab.AutoScroll = true;
            this.FlowchartTab.Controls.Add(this.FlowchartBox);
            this.FlowchartTab.Location = new System.Drawing.Point(4, 22);
            this.FlowchartTab.Name = "FlowchartTab";
            this.FlowchartTab.Padding = new System.Windows.Forms.Padding(3);
            this.FlowchartTab.Size = new System.Drawing.Size(609, 427);
            this.FlowchartTab.TabIndex = 2;
            this.FlowchartTab.Text = "Flowchart";
            this.FlowchartTab.UseVisualStyleBackColor = true;
            // 
            // FlowchartBox
            // 
            this.FlowchartBox.Image = global::PersuitSimulator.Properties.Resources.PersuitFlowchart;
            this.FlowchartBox.Location = new System.Drawing.Point(22, 31);
            this.FlowchartBox.Name = "FlowchartBox";
            this.FlowchartBox.Size = new System.Drawing.Size(548, 630);
            this.FlowchartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlowchartBox.TabIndex = 3;
            this.FlowchartBox.TabStop = false;
            // 
            // CodeTab
            // 
            this.CodeTab.AutoScroll = true;
            this.CodeTab.Controls.Add(this.txtCode);
            this.CodeTab.Location = new System.Drawing.Point(4, 22);
            this.CodeTab.Name = "CodeTab";
            this.CodeTab.Padding = new System.Windows.Forms.Padding(3);
            this.CodeTab.Size = new System.Drawing.Size(609, 427);
            this.CodeTab.TabIndex = 3;
            this.CodeTab.Text = "C++ Code";
            this.CodeTab.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCode.Location = new System.Drawing.Point(0, 0);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(592, 777);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = resources.GetString("txtCode.Text");
            this.txtCode.WordWrap = false;
            // 
            // DetailsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 455);
            this.Controls.Add(this.DetailsTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetailsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Simulation Details";
            this.DetailsTab.ResumeLayout(false);
            this.AssumptionsTab.ResumeLayout(false);
            this.CalculationsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TriangleBox)).EndInit();
            this.FlowchartTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FlowchartBox)).EndInit();
            this.CodeTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DetailsTab;
        private System.Windows.Forms.TabPage AssumptionsTab;
        private System.Windows.Forms.TabPage CalculationsTab;
        private System.Windows.Forms.TabPage FlowchartTab;
        private System.Windows.Forms.TabPage CodeTab;
        private System.Windows.Forms.PictureBox FlowchartBox;
        private System.Windows.Forms.RichTextBox txtassumptions;
        private System.Windows.Forms.RichTextBox txtcalculations;
        private System.Windows.Forms.PictureBox TriangleBox;
        private System.Windows.Forms.RichTextBox txtCode;
    }
}