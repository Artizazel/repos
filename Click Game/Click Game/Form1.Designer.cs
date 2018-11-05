namespace Click_Game
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMaximise = new System.Windows.Forms.Label();
            this.lblLife1 = new System.Windows.Forms.Label();
            this.lblLife2 = new System.Windows.Forms.Label();
            this.lblLife3 = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(270, 180);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(214, 90);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 10000);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "O\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMaximise
            // 
            this.lblMaximise.AutoSize = true;
            this.lblMaximise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximise.Location = new System.Drawing.Point(175, 57);
            this.lblMaximise.Name = "lblMaximise";
            this.lblMaximise.Size = new System.Drawing.Size(417, 20);
            this.lblMaximise.TabIndex = 2;
            this.lblMaximise.Text = "Make Sure To Maximise The Window Before Clicking Start";
            this.lblMaximise.Click += new System.EventHandler(this.lblMaximise_Click);
            // 
            // lblLife1
            // 
            this.lblLife1.AutoSize = true;
            this.lblLife1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife1.ForeColor = System.Drawing.Color.Red;
            this.lblLife1.Location = new System.Drawing.Point(12, 9);
            this.lblLife1.Name = "lblLife1";
            this.lblLife1.Size = new System.Drawing.Size(54, 31);
            this.lblLife1.TabIndex = 3;
            this.lblLife1.Text = "[O]";
            this.lblLife1.Click += new System.EventHandler(this.lblLife1_Click);
            // 
            // lblLife2
            // 
            this.lblLife2.AutoSize = true;
            this.lblLife2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife2.ForeColor = System.Drawing.Color.Red;
            this.lblLife2.Location = new System.Drawing.Point(69, 9);
            this.lblLife2.Name = "lblLife2";
            this.lblLife2.Size = new System.Drawing.Size(54, 31);
            this.lblLife2.TabIndex = 4;
            this.lblLife2.Text = "[O]";
            this.lblLife2.Click += new System.EventHandler(this.lblLife2_Click);
            // 
            // lblLife3
            // 
            this.lblLife3.AutoSize = true;
            this.lblLife3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife3.ForeColor = System.Drawing.Color.Red;
            this.lblLife3.Location = new System.Drawing.Point(126, 9);
            this.lblLife3.Name = "lblLife3";
            this.lblLife3.Size = new System.Drawing.Size(54, 31);
            this.lblLife3.TabIndex = 5;
            this.lblLife3.Text = "[O]";
            this.lblLife3.Click += new System.EventHandler(this.lblLife3_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGameOver.Location = new System.Drawing.Point(790, 334);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(387, 76);
            this.lblGameOver.TabIndex = 6;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 460);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblLife3);
            this.Controls.Add(this.lblLife2);
            this.Controls.Add(this.lblLife1);
            this.Controls.Add(this.lblMaximise);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMaximise;
        private System.Windows.Forms.Label lblLife1;
        private System.Windows.Forms.Label lblLife2;
        private System.Windows.Forms.Label lblLife3;
        private System.Windows.Forms.Label lblGameOver;
    }
}

