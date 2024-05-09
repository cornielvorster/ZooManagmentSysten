namespace ZooManagmentSysten
{
    partial class addAnimal
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
            this.edtName = new System.Windows.Forms.TextBox();
            this.cmbxAnimalType = new System.Windows.Forms.ComboBox();
            this.cmbxGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Animal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(72, 39);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(121, 20);
            this.edtName.TabIndex = 1;
            // 
            // cmbxAnimalType
            // 
            this.cmbxAnimalType.FormattingEnabled = true;
            this.cmbxAnimalType.Items.AddRange(new object[] {
            "Jackel",
            "Penguin",
            "Aardvark"});
            this.cmbxAnimalType.Location = new System.Drawing.Point(72, 12);
            this.cmbxAnimalType.Name = "cmbxAnimalType";
            this.cmbxAnimalType.Size = new System.Drawing.Size(121, 21);
            this.cmbxAnimalType.TabIndex = 2;
            // 
            // cmbxGender
            // 
            this.cmbxGender.FormattingEnabled = true;
            this.cmbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbxGender.Location = new System.Drawing.Point(72, 65);
            this.cmbxGender.Name = "cmbxGender";
            this.cmbxGender.Size = new System.Drawing.Size(121, 21);
            this.cmbxGender.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            // 
            // edtAge
            // 
            this.edtAge.Location = new System.Drawing.Point(72, 92);
            this.edtAge.Name = "edtAge";
            this.edtAge.Size = new System.Drawing.Size(121, 20);
            this.edtAge.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // addAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 170);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxGender);
            this.Controls.Add(this.cmbxAnimalType);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.button1);
            this.Name = "addAnimal";
            this.Text = "Add Animal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.ComboBox cmbxAnimalType;
        private System.Windows.Forms.ComboBox cmbxGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtAge;
        private System.Windows.Forms.Label label4;
    }
}