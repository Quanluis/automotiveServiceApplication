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
            this.oilLabel = new System.Windows.Forms.Label();
            this.flushesLabel = new System.Windows.Forms.Label();
            this.miscLabel = new System.Windows.Forms.Label();
            this.partsAndLaborLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.oilChangeBox = new System.Windows.Forms.CheckBox();
            this.lubeJobBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushBox = new System.Windows.Forms.CheckBox();
            this.TransmissionFlushBox = new System.Windows.Forms.CheckBox();
            this.inspectionBox = new System.Windows.Forms.CheckBox();
            this.mufflerBox = new System.Windows.Forms.CheckBox();
            this.tireRotationBox = new System.Windows.Forms.CheckBox();
            this.partsCost = new System.Windows.Forms.TextBox();
            this.laborCost = new System.Windows.Forms.TextBox();
            this.partLabel = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.serviceAndLaborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.partsTaxLabel = new System.Windows.Forms.Label();
            this.totalFeesLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.serviceAndLaborTotal = new System.Windows.Forms.TextBox();
            this.partsTotal = new System.Windows.Forms.TextBox();
            this.taxTotal = new System.Windows.Forms.TextBox();
            this.finalTotal = new System.Windows.Forms.TextBox();
            this.nonRoutineInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oilLabel
            // 
            this.oilLabel.AutoSize = true;
            this.oilLabel.Location = new System.Drawing.Point(104, 28);
            this.oilLabel.Name = "oilLabel";
            this.oilLabel.Size = new System.Drawing.Size(67, 13);
            this.oilLabel.TabIndex = 1;
            this.oilLabel.Text = "Oil and Lube";
            // 
            // flushesLabel
            // 
            this.flushesLabel.AutoSize = true;
            this.flushesLabel.Location = new System.Drawing.Point(581, 28);
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
            this.partsAndLaborLabel.Location = new System.Drawing.Point(563, 165);
            this.partsAndLaborLabel.Name = "partsAndLaborLabel";
            this.partsAndLaborLabel.Size = new System.Drawing.Size(82, 13);
            this.partsAndLaborLabel.TabIndex = 4;
            this.partsAndLaborLabel.Text = "Parts and Labor";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(357, 215);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(50, 13);
            this.summaryLabel.TabIndex = 5;
            this.summaryLabel.Text = "Summary";
            // 
            // oilChangeBox
            // 
            this.oilChangeBox.AutoSize = true;
            this.oilChangeBox.Location = new System.Drawing.Point(91, 69);
            this.oilChangeBox.Name = "oilChangeBox";
            this.oilChangeBox.Size = new System.Drawing.Size(120, 17);
            this.oilChangeBox.TabIndex = 6;
            this.oilChangeBox.Text = "Oil Change ($26.00)";
            this.oilChangeBox.UseVisualStyleBackColor = true;
            // 
            // lubeJobBox
            // 
            this.lubeJobBox.AutoSize = true;
            this.lubeJobBox.Location = new System.Drawing.Point(91, 115);
            this.lubeJobBox.Name = "lubeJobBox";
            this.lubeJobBox.Size = new System.Drawing.Size(112, 17);
            this.lubeJobBox.TabIndex = 7;
            this.lubeJobBox.Text = "Lube Job ($18.00)";
            this.lubeJobBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushBox
            // 
            this.radiatorFlushBox.AutoSize = true;
            this.radiatorFlushBox.Location = new System.Drawing.Point(565, 69);
            this.radiatorFlushBox.Name = "radiatorFlushBox";
            this.radiatorFlushBox.Size = new System.Drawing.Size(136, 17);
            this.radiatorFlushBox.TabIndex = 8;
            this.radiatorFlushBox.Text = "Radiator Flush ($30.00)";
            this.radiatorFlushBox.UseVisualStyleBackColor = true;
            // 
            // TransmissionFlushBox
            // 
            this.TransmissionFlushBox.AutoSize = true;
            this.TransmissionFlushBox.Location = new System.Drawing.Point(566, 115);
            this.TransmissionFlushBox.Name = "TransmissionFlushBox";
            this.TransmissionFlushBox.Size = new System.Drawing.Size(157, 17);
            this.TransmissionFlushBox.TabIndex = 9;
            this.TransmissionFlushBox.Text = "Transmission Flush ($80.00)";
            this.TransmissionFlushBox.UseVisualStyleBackColor = true;
            // 
            // inspectionBox
            // 
            this.inspectionBox.AutoSize = true;
            this.inspectionBox.Location = new System.Drawing.Point(91, 215);
            this.inspectionBox.Name = "inspectionBox";
            this.inspectionBox.Size = new System.Drawing.Size(117, 17);
            this.inspectionBox.TabIndex = 10;
            this.inspectionBox.Text = "Inspection ($15.00)";
            this.inspectionBox.UseVisualStyleBackColor = true;
            // 
            // mufflerBox
            // 
            this.mufflerBox.AutoSize = true;
            this.mufflerBox.Location = new System.Drawing.Point(91, 256);
            this.mufflerBox.Name = "mufflerBox";
            this.mufflerBox.Size = new System.Drawing.Size(149, 17);
            this.mufflerBox.TabIndex = 11;
            this.mufflerBox.Text = "Replace Muffler ($100.00)";
            this.mufflerBox.UseVisualStyleBackColor = true;
            // 
            // tireRotationBox
            // 
            this.tireRotationBox.AutoSize = true;
            this.tireRotationBox.Location = new System.Drawing.Point(91, 298);
            this.tireRotationBox.Name = "tireRotationBox";
            this.tireRotationBox.Size = new System.Drawing.Size(129, 17);
            this.tireRotationBox.TabIndex = 12;
            this.tireRotationBox.Text = "Tire Rotation ($20.00)";
            this.tireRotationBox.UseVisualStyleBackColor = true;
            // 
            // partsCost
            // 
            this.partsCost.Location = new System.Drawing.Point(623, 215);
            this.partsCost.Name = "partsCost";
            this.partsCost.Size = new System.Drawing.Size(100, 20);
            this.partsCost.TabIndex = 13;
            // 
            // laborCost
            // 
            this.laborCost.Location = new System.Drawing.Point(623, 256);
            this.laborCost.Name = "laborCost";
            this.laborCost.ReadOnly = true;
            this.laborCost.Size = new System.Drawing.Size(100, 20);
            this.laborCost.TabIndex = 14;
            // 
            // partLabel
            // 
            this.partLabel.AutoSize = true;
            this.partLabel.Location = new System.Drawing.Point(552, 215);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(52, 13);
            this.partLabel.TabIndex = 17;
            this.partLabel.Text = "Part price";
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(552, 256);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(49, 13);
            this.laborLabel.TabIndex = 19;
            this.laborLabel.Text = "Labor ($)";
            // 
            // serviceAndLaborLabel
            // 
            this.serviceAndLaborLabel.AutoSize = true;
            this.serviceAndLaborLabel.Location = new System.Drawing.Point(285, 256);
            this.serviceAndLaborLabel.Name = "serviceAndLaborLabel";
            this.serviceAndLaborLabel.Size = new System.Drawing.Size(94, 13);
            this.serviceAndLaborLabel.TabIndex = 20;
            this.serviceAndLaborLabel.Text = "Service and Labor";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(285, 298);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(31, 13);
            this.partsLabel.TabIndex = 21;
            this.partsLabel.Text = "Parts";
            // 
            // partsTaxLabel
            // 
            this.partsTaxLabel.AutoSize = true;
            this.partsTaxLabel.Location = new System.Drawing.Point(285, 338);
            this.partsTaxLabel.Name = "partsTaxLabel";
            this.partsTaxLabel.Size = new System.Drawing.Size(72, 13);
            this.partsTaxLabel.TabIndex = 22;
            this.partsTaxLabel.Text = "Tax (on parts)";
            // 
            // totalFeesLabel
            // 
            this.totalFeesLabel.AutoSize = true;
            this.totalFeesLabel.Location = new System.Drawing.Point(285, 382);
            this.totalFeesLabel.Name = "totalFeesLabel";
            this.totalFeesLabel.Size = new System.Drawing.Size(57, 13);
            this.totalFeesLabel.TabIndex = 23;
            this.totalFeesLabel.Text = "Total Fees";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(508, 338);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 24;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(605, 338);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(700, 338);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // serviceAndLaborTotal
            // 
            this.serviceAndLaborTotal.Location = new System.Drawing.Point(385, 253);
            this.serviceAndLaborTotal.Name = "serviceAndLaborTotal";
            this.serviceAndLaborTotal.ReadOnly = true;
            this.serviceAndLaborTotal.Size = new System.Drawing.Size(100, 20);
            this.serviceAndLaborTotal.TabIndex = 27;
            // 
            // partsTotal
            // 
            this.partsTotal.Location = new System.Drawing.Point(385, 295);
            this.partsTotal.Name = "partsTotal";
            this.partsTotal.ReadOnly = true;
            this.partsTotal.Size = new System.Drawing.Size(100, 20);
            this.partsTotal.TabIndex = 28;
            // 
            // taxTotal
            // 
            this.taxTotal.Location = new System.Drawing.Point(385, 338);
            this.taxTotal.Name = "taxTotal";
            this.taxTotal.ReadOnly = true;
            this.taxTotal.Size = new System.Drawing.Size(100, 20);
            this.taxTotal.TabIndex = 29;
            // 
            // finalTotal
            // 
            this.finalTotal.Location = new System.Drawing.Point(385, 382);
            this.finalTotal.Name = "finalTotal";
            this.finalTotal.ReadOnly = true;
            this.finalTotal.Size = new System.Drawing.Size(100, 20);
            this.finalTotal.TabIndex = 30;
            // 
            // nonRoutineInfo
            // 
            this.nonRoutineInfo.AutoSize = true;
            this.nonRoutineInfo.Location = new System.Drawing.Point(552, 299);
            this.nonRoutineInfo.Name = "nonRoutineInfo";
            this.nonRoutineInfo.Size = new System.Drawing.Size(235, 13);
            this.nonRoutineInfo.TabIndex = 31;
            this.nonRoutineInfo.Text = "* Each $60 part = 1 Hour of labor = $20 per hour";
            this.nonRoutineInfo.Click += new System.EventHandler(this.nonRoutineInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nonRoutineInfo);
            this.Controls.Add(this.finalTotal);
            this.Controls.Add(this.taxTotal);
            this.Controls.Add(this.partsTotal);
            this.Controls.Add(this.serviceAndLaborTotal);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalFeesLabel);
            this.Controls.Add(this.partsTaxLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.serviceAndLaborLabel);
            this.Controls.Add(this.laborLabel);
            this.Controls.Add(this.partLabel);
            this.Controls.Add(this.laborCost);
            this.Controls.Add(this.partsCost);
            this.Controls.Add(this.tireRotationBox);
            this.Controls.Add(this.mufflerBox);
            this.Controls.Add(this.inspectionBox);
            this.Controls.Add(this.TransmissionFlushBox);
            this.Controls.Add(this.radiatorFlushBox);
            this.Controls.Add(this.lubeJobBox);
            this.Controls.Add(this.oilChangeBox);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.partsAndLaborLabel);
            this.Controls.Add(this.miscLabel);
            this.Controls.Add(this.flushesLabel);
            this.Controls.Add(this.oilLabel);
            this.Name = "Form1";
            this.Text = "Automotive Service Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label oilLabel;
        private System.Windows.Forms.Label flushesLabel;
        private System.Windows.Forms.Label miscLabel;
        private System.Windows.Forms.Label partsAndLaborLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.CheckBox oilChangeBox;
        private System.Windows.Forms.CheckBox lubeJobBox;
        private System.Windows.Forms.CheckBox radiatorFlushBox;
        private System.Windows.Forms.CheckBox TransmissionFlushBox;
        private System.Windows.Forms.CheckBox inspectionBox;
        private System.Windows.Forms.CheckBox mufflerBox;
        private System.Windows.Forms.CheckBox tireRotationBox;
        private System.Windows.Forms.TextBox partsCost;
        private System.Windows.Forms.TextBox laborCost;
        private System.Windows.Forms.Label partLabel;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label serviceAndLaborLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label partsTaxLabel;
        private System.Windows.Forms.Label totalFeesLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox serviceAndLaborTotal;
        private System.Windows.Forms.TextBox partsTotal;
        private System.Windows.Forms.TextBox taxTotal;
        private System.Windows.Forms.TextBox finalTotal;
        private System.Windows.Forms.Label nonRoutineInfo;
    }
}

