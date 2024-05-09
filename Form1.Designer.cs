namespace ZooManagmentSysten
{
    partial class frmZooMainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnNoise = new System.Windows.Forms.Button();
            this.btnMoveAnimal = new System.Windows.Forms.Button();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtboxDisplay = new System.Windows.Forms.TextBox();
            this.btnSwim = new System.Windows.Forms.Button();
            this.btnDig = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Zoo!";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(215, 158);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 294);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click on an animal";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 460);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(500, 26);
            this.textBox1.TabIndex = 3;
            // 
            // btnFeed
            // 
            this.btnFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeed.Location = new System.Drawing.Point(146, 513);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(118, 45);
            this.btnFeed.TabIndex = 4;
            this.btnFeed.Text = "Feed Animal";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSleep.Location = new System.Drawing.Point(270, 513);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(121, 45);
            this.btnSleep.TabIndex = 5;
            this.btnSleep.Text = "Let Animal Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnNoise
            // 
            this.btnNoise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoise.Location = new System.Drawing.Point(397, 513);
            this.btnNoise.Name = "btnNoise";
            this.btnNoise.Size = new System.Drawing.Size(129, 45);
            this.btnNoise.TabIndex = 6;
            this.btnNoise.Text = "Animal Noise";
            this.btnNoise.UseVisualStyleBackColor = true;
            this.btnNoise.Click += new System.EventHandler(this.btnNoise_Click);
            // 
            // btnMoveAnimal
            // 
            this.btnMoveAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveAnimal.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAnimal.Location = new System.Drawing.Point(532, 513);
            this.btnMoveAnimal.Name = "btnMoveAnimal";
            this.btnMoveAnimal.Size = new System.Drawing.Size(114, 45);
            this.btnMoveAnimal.TabIndex = 7;
            this.btnMoveAnimal.Text = "Move Animal to sick bay/back to enclosure";
            this.btnMoveAnimal.UseVisualStyleBackColor = true;
            this.btnMoveAnimal.Click += new System.EventHandler(this.btnMoveAnimal_Click);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAnimal.Location = new System.Drawing.Point(537, 275);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(109, 52);
            this.btnAddAnimal.TabIndex = 8;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(270, 558);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(256, 32);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove Animal";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtboxDisplay
            // 
            this.txtboxDisplay.Location = new System.Drawing.Point(146, 616);
            this.txtboxDisplay.Name = "txtboxDisplay";
            this.txtboxDisplay.ReadOnly = true;
            this.txtboxDisplay.Size = new System.Drawing.Size(500, 26);
            this.txtboxDisplay.TabIndex = 10;
            // 
            // btnSwim
            // 
            this.btnSwim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwim.Location = new System.Drawing.Point(146, 558);
            this.btnSwim.Name = "btnSwim";
            this.btnSwim.Size = new System.Drawing.Size(118, 32);
            this.btnSwim.TabIndex = 11;
            this.btnSwim.Text = "Swim";
            this.btnSwim.UseVisualStyleBackColor = true;
            this.btnSwim.Click += new System.EventHandler(this.btnSwim_Click);
            // 
            // btnDig
            // 
            this.btnDig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDig.Location = new System.Drawing.Point(532, 558);
            this.btnDig.Name = "btnDig";
            this.btnDig.Size = new System.Drawing.Size(114, 32);
            this.btnDig.TabIndex = 12;
            this.btnDig.Text = "Dig";
            this.btnDig.UseVisualStyleBackColor = true;
            this.btnDig.Click += new System.EventHandler(this.btnDig_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(29, 463);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(111, 20);
            this.lblSelected.TabIndex = 13;
            this.lblSelected.Text = "Selected Animal:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(89, 616);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(51, 20);
            this.lblOutput.TabIndex = 14;
            this.lblOutput.Text = "Output:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Enclosure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 100);
            this.label7.TabIndex = 19;
            this.label7.Text = "Enclosure Key:\r\n1 - Jackel\r\n2 - Penguin\r\n3 - Aardvark\r\n4 - Sick Bay";
            // 
            // frmZooMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(716, 654);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnDig);
            this.Controls.Add(this.btnSwim);
            this.Controls.Add(this.txtboxDisplay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.btnMoveAnimal);
            this.Controls.Add(this.btnNoise);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmZooMainScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmZooMainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button btnNoise;
        private System.Windows.Forms.Button btnMoveAnimal;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtboxDisplay;
        private System.Windows.Forms.Button btnSwim;
        private System.Windows.Forms.Button btnDig;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}