namespace Dice_Simulater
{
    partial class diceSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diceSimulator));
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.dice4 = new System.Windows.Forms.PictureBox();
            this.dice5 = new System.Windows.Forms.PictureBox();
            this.dice6 = new System.Windows.Forms.PictureBox();
            this.roll = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice6)).BeginInit();
            this.SuspendLayout();
            // 
            // dice1
            // 
            this.dice1.Image = ((System.Drawing.Image)(resources.GetObject("dice1.Image")));
            this.dice1.Location = new System.Drawing.Point(38, 39);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(114, 135);
            this.dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice1.TabIndex = 0;
            this.dice1.TabStop = false;
            // 
            // dice2
            // 
            this.dice2.Image = ((System.Drawing.Image)(resources.GetObject("dice2.Image")));
            this.dice2.Location = new System.Drawing.Point(187, 39);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(116, 135);
            this.dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice2.TabIndex = 1;
            this.dice2.TabStop = false;
            this.dice2.Visible = false;
            // 
            // dice3
            // 
            this.dice3.Image = ((System.Drawing.Image)(resources.GetObject("dice3.Image")));
            this.dice3.Location = new System.Drawing.Point(331, 39);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(116, 135);
            this.dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice3.TabIndex = 2;
            this.dice3.TabStop = false;
            this.dice3.Visible = false;
            // 
            // dice4
            // 
            this.dice4.Image = ((System.Drawing.Image)(resources.GetObject("dice4.Image")));
            this.dice4.Location = new System.Drawing.Point(476, 39);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(116, 135);
            this.dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice4.TabIndex = 3;
            this.dice4.TabStop = false;
            this.dice4.Visible = false;
            // 
            // dice5
            // 
            this.dice5.Image = ((System.Drawing.Image)(resources.GetObject("dice5.Image")));
            this.dice5.Location = new System.Drawing.Point(612, 39);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(116, 135);
            this.dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice5.TabIndex = 4;
            this.dice5.TabStop = false;
            this.dice5.Visible = false;
            // 
            // dice6
            // 
            this.dice6.Image = ((System.Drawing.Image)(resources.GetObject("dice6.Image")));
            this.dice6.Location = new System.Drawing.Point(750, 39);
            this.dice6.Name = "dice6";
            this.dice6.Size = new System.Drawing.Size(116, 135);
            this.dice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dice6.TabIndex = 5;
            this.dice6.TabStop = false;
            this.dice6.Visible = false;
            // 
            // roll
            // 
            this.roll.Location = new System.Drawing.Point(259, 220);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(114, 66);
            this.roll.TabIndex = 6;
            this.roll.Text = "Roll";
            this.roll.UseVisualStyleBackColor = true;
            this.roll.Click += new System.EventHandler(this.roll_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(632, 220);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(96, 66);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // diceSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 346);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.roll);
            this.Controls.Add(this.dice6);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Name = "diceSimulator";
            this.Text = "Dice Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.PictureBox dice4;
        private System.Windows.Forms.PictureBox dice5;
        private System.Windows.Forms.PictureBox dice6;
        private System.Windows.Forms.Button roll;
        private System.Windows.Forms.Button exit;
    }
}

