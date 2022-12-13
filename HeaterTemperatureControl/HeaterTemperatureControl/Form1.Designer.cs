namespace HeaterTemperatureControl
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.actionOutputLbl = new System.Windows.Forms.Label();
            this.roomTempLbl = new System.Windows.Forms.Label();
            this.desiredTempLbl = new System.Windows.Forms.Label();
            this.initialTempLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Desired Temperature";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "1 click process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Initial Temperature";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 23;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.actionOutputLbl);
            this.panel1.Controls.Add(this.roomTempLbl);
            this.panel1.Controls.Add(this.desiredTempLbl);
            this.panel1.Controls.Add(this.initialTempLbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(13, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 131);
            this.panel1.TabIndex = 22;
            // 
            // actionOutputLbl
            // 
            this.actionOutputLbl.AutoSize = true;
            this.actionOutputLbl.Location = new System.Drawing.Point(150, 87);
            this.actionOutputLbl.Name = "actionOutputLbl";
            this.actionOutputLbl.Size = new System.Drawing.Size(10, 13);
            this.actionOutputLbl.TabIndex = 28;
            this.actionOutputLbl.Text = " ";
            // 
            // roomTempLbl
            // 
            this.roomTempLbl.AutoSize = true;
            this.roomTempLbl.Location = new System.Drawing.Point(150, 65);
            this.roomTempLbl.Name = "roomTempLbl";
            this.roomTempLbl.Size = new System.Drawing.Size(10, 13);
            this.roomTempLbl.TabIndex = 27;
            this.roomTempLbl.Text = " ";
            // 
            // desiredTempLbl
            // 
            this.desiredTempLbl.AutoSize = true;
            this.desiredTempLbl.Location = new System.Drawing.Point(150, 41);
            this.desiredTempLbl.Name = "desiredTempLbl";
            this.desiredTempLbl.Size = new System.Drawing.Size(10, 13);
            this.desiredTempLbl.TabIndex = 26;
            this.desiredTempLbl.Text = " ";
            // 
            // initialTempLbl
            // 
            this.initialTempLbl.AutoSize = true;
            this.initialTempLbl.Location = new System.Drawing.Point(150, 18);
            this.initialTempLbl.Name = "initialTempLbl";
            this.initialTempLbl.Size = new System.Drawing.Size(10, 13);
            this.initialTempLbl.TabIndex = 25;
            this.initialTempLbl.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Current Room Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Action Output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Desired Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Initial Temperature";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(317, 46);
            this.button3.TabIndex = 24;
            this.button3.Text = "Initialize";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 353);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Heater Temperature Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label actionOutputLbl;
        private System.Windows.Forms.Label roomTempLbl;
        private System.Windows.Forms.Label desiredTempLbl;
        private System.Windows.Forms.Label initialTempLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}

