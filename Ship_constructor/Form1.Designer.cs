namespace Ship_constructor
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.blockList = new System.Windows.Forms.ListBox();
            this.levelUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removoButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.shipBox = new System.Windows.Forms.ListBox();
            this.lMass = new System.Windows.Forms.Label();
            this.lEnergy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.levelUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // blockList
            // 
            this.blockList.FormattingEnabled = true;
            this.blockList.Items.AddRange(new object[] {
            "<Modul>"});
            this.blockList.Location = new System.Drawing.Point(12, 12);
            this.blockList.Name = "blockList";
            this.blockList.Size = new System.Drawing.Size(211, 173);
            this.blockList.TabIndex = 0;
            this.blockList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // levelUpDown
            // 
            this.levelUpDown.Location = new System.Drawing.Point(267, 34);
            this.levelUpDown.Name = "levelUpDown";
            this.levelUpDown.Size = new System.Drawing.Size(120, 20);
            this.levelUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Level";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(267, 104);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removoButton
            // 
            this.removoButton.Location = new System.Drawing.Point(267, 149);
            this.removoButton.Name = "removoButton";
            this.removoButton.Size = new System.Drawing.Size(75, 23);
            this.removoButton.TabIndex = 4;
            this.removoButton.Text = "Removo";
            this.removoButton.UseVisualStyleBackColor = true;
            this.removoButton.Click += new System.EventHandler(this.removoButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(267, 187);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputTextbox
            // 
            this.outputTextbox.Location = new System.Drawing.Point(12, 216);
            this.outputTextbox.Multiline = true;
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.Size = new System.Drawing.Size(252, 219);
            this.outputTextbox.TabIndex = 6;
            this.outputTextbox.TextChanged += new System.EventHandler(this.outputTextbox_TextChanged);
            // 
            // shipBox
            // 
            this.shipBox.FormattingEnabled = true;
            this.shipBox.Location = new System.Drawing.Point(524, 12);
            this.shipBox.Name = "shipBox";
            this.shipBox.Size = new System.Drawing.Size(234, 173);
            this.shipBox.TabIndex = 7;
            // 
            // lMass
            // 
            this.lMass.AutoSize = true;
            this.lMass.Location = new System.Drawing.Point(545, 311);
            this.lMass.Name = "lMass";
            this.lMass.Size = new System.Drawing.Size(34, 13);
            this.lMass.TabIndex = 8;
            this.lMass.Text = "lMass";
            // 
            // lEnergy
            // 
            this.lEnergy.AutoSize = true;
            this.lEnergy.Location = new System.Drawing.Point(545, 324);
            this.lEnergy.Name = "lEnergy";
            this.lEnergy.Size = new System.Drawing.Size(42, 13);
            this.lEnergy.TabIndex = 9;
            this.lEnergy.Text = "lEnergy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hmotnost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Energie:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lEnergy);
            this.Controls.Add(this.lMass);
            this.Controls.Add(this.shipBox);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.removoButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelUpDown);
            this.Controls.Add(this.blockList);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Sestavení lodi";
            ((System.ComponentModel.ISupportInitialize)(this.levelUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox blockList;
        private System.Windows.Forms.NumericUpDown levelUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removoButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.ListBox shipBox;
        private System.Windows.Forms.Label lMass;
        private System.Windows.Forms.Label lEnergy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

