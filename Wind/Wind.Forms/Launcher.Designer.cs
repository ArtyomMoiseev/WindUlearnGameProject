
using System.Windows.Forms;

namespace Wind.Forms
{
    partial class Launcher
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
            this.levelSelector = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.Levels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resolutionSelector = new System.Windows.Forms.ComboBox();
            this.Scale = new System.Windows.Forms.Label();
            this.scaleSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // levelSelector
            // 
            this.levelSelector.FormattingEnabled = true;
            this.levelSelector.ItemHeight = 20;
            this.levelSelector.Items.AddRange(new object[] {
            "LevelOne"});
            this.levelSelector.Location = new System.Drawing.Point(16, 59);
            this.levelSelector.Name = "levelSelector";
            this.levelSelector.Size = new System.Drawing.Size(354, 424);
            this.levelSelector.TabIndex = 0;
            this.levelSelector.SelectedIndexChanged += new System.EventHandler(this.levels_SelectedIndexChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(548, 501);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(108, 47);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Levels
            // 
            this.Levels.AutoSize = true;
            this.Levels.Location = new System.Drawing.Point(12, 26);
            this.Levels.Name = "Levels";
            this.Levels.Size = new System.Drawing.Size(54, 20);
            this.Levels.TabIndex = 2;
            this.Levels.Text = "Levels";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resolution";
            // 
            // resolutionSelector
            // 
            this.resolutionSelector.FormattingEnabled = true;
            this.resolutionSelector.Items.AddRange(new object[] {
            "1280x720",
            "1920x1080"});
            this.resolutionSelector.Location = new System.Drawing.Point(504, 126);
            this.resolutionSelector.Name = "resolutionSelector";
            this.resolutionSelector.Size = new System.Drawing.Size(121, 28);
            this.resolutionSelector.TabIndex = 5;
            this.resolutionSelector.SelectedIndexChanged += new System.EventHandler(this.resolution_SelectedIndexChanged);
            // 
            // Scale
            // 
            this.Scale.AutoSize = true;
            this.Scale.Location = new System.Drawing.Point(400, 173);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(49, 20);
            this.Scale.TabIndex = 6;
            this.Scale.Text = "Scale";
            // 
            // scaleSelector
            // 
            this.scaleSelector.FormattingEnabled = true;
            this.scaleSelector.Items.AddRange(new object[] {
            "Small",
            "Normal",
            "High"});
            this.scaleSelector.Location = new System.Drawing.Point(504, 173);
            this.scaleSelector.Name = "scaleSelector";
            this.scaleSelector.Size = new System.Drawing.Size(121, 28);
            this.scaleSelector.TabIndex = 7;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 559);
            this.Controls.Add(this.scaleSelector);
            this.Controls.Add(this.Scale);
            this.Controls.Add(this.resolutionSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Levels);
            this.Controls.Add(this.start);
            this.Controls.Add(this.levelSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Launcher";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox levelSelector;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label Levels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox resolutionSelector;
        private System.Windows.Forms.Label Scale;
        private System.Windows.Forms.ComboBox scaleSelector;
    }
}