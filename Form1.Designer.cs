namespace automotiveServiceApplication
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
            this.button1 = new System.Windows.Forms.Button();
            this.oilLabel = new System.Windows.Forms.Label();
            this.flushesLabel = new System.Windows.Forms.Label();
            this.miscLabel = new System.Windows.Forms.Label();
            this.partsAndLaborLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // oilLabel
            // 
            this.oilLabel.AutoSize = true;
            this.oilLabel.Location = new System.Drawing.Point(104, 28);
            this.oilLabel.Name = "oilLabel";
            this.oilLabel.Size = new System.Drawing.Size(67, 13);
            this.oilLabel.TabIndex = 1;
            this.oilLabel.Text = "Oil and Lube";
            this.oilLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // flushesLabel
            // 
            this.flushesLabel.AutoSize = true;
            this.flushesLabel.Location = new System.Drawing.Point(586, 28);
            this.flushesLabel.Name = "flushesLabel";
            this.flushesLabel.Size = new System.Drawing.Size(43, 13);
            this.flushesLabel.TabIndex = 2;
            this.flushesLabel.Text = "Flushes";
            // 
            // miscLabel
            // 
            this.miscLabel.AutoSize = true;
            this.miscLabel.Location = new System.Drawing.Point(107, 165);
            this.miscLabel.Name = "miscLabel";
            this.miscLabel.Size = new System.Drawing.Size(29, 13);
            this.miscLabel.TabIndex = 3;
            this.miscLabel.Text = "Misc";
            // 
            // partsAndLaborLabel
            // 
            this.partsAndLaborLabel.AutoSize = true;
            this.partsAndLaborLabel.Location = new System.Drawing.Point(589, 165);
            this.partsAndLaborLabel.Name = "partsAndLaborLabel";
            this.partsAndLaborLabel.Size = new System.Drawing.Size(82, 13);
            this.partsAndLaborLabel.TabIndex = 4;
            this.partsAndLaborLabel.Text = "Parts and Labor";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(380, 203);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(50, 13);
            this.summaryLabel.TabIndex = 5;
            this.summaryLabel.Text = "Summary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.partsAndLaborLabel);
            this.Controls.Add(this.miscLabel);
            this.Controls.Add(this.flushesLabel);
            this.Controls.Add(this.oilLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Automotive Service Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label oilLabel;
        private System.Windows.Forms.Label flushesLabel;
        private System.Windows.Forms.Label miscLabel;
        private System.Windows.Forms.Label partsAndLaborLabel;
        private System.Windows.Forms.Label summaryLabel;
    }
}

