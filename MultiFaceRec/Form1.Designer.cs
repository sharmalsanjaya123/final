namespace MultiFaceRec
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textnum = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textcontnum = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textacunum = new System.Windows.Forms.TextBox();
            this.textidnum = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button2.Location = new System.Drawing.Point(36, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 3;
            this.button2.Text = "Match";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::MultiFaceRec.Properties.Resources.background_gradient_blue_05_jpg_max;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.textnum);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Californian FB", 21.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(478, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 519);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Face Recognition";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textnum
            // 
            this.textnum.Location = new System.Drawing.Point(36, 106);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(207, 41);
            this.textnum.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Navy;
            this.textBox5.Location = new System.Drawing.Point(60, 428);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(61, 41);
            this.textBox5.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button3.Location = new System.Drawing.Point(36, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(302, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start camera";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BackgroundImage = global::MultiFaceRec.Properties.Resources.background_gradient_blue_05_jpg_max;
            this.imageBoxFrameGrabber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(16, 44);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(417, 276);
            this.imageBoxFrameGrabber.TabIndex = 11;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::MultiFaceRec.Properties.Resources.background_gradient_blue_05_jpg_max;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.imageBoxFrameGrabber);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Californian FB", 21.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Location = new System.Drawing.Point(14, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 518);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Face Recognition";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MintCream;
            this.groupBox4.BackgroundImage = global::MultiFaceRec.Properties.Resources.background_gradient_blue_05_jpg_max;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textcontnum);
            this.groupBox4.Controls.Add(this.textid);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textacunum);
            this.groupBox4.Controls.Add(this.textidnum);
            this.groupBox4.Controls.Add(this.textname);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox4.Location = new System.Drawing.Point(755, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 518);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(14, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(14, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Contact Number";
            // 
            // textcontnum
            // 
            this.textcontnum.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textcontnum.Location = new System.Drawing.Point(179, 416);
            this.textcontnum.Multiline = true;
            this.textcontnum.Name = "textcontnum";
            this.textcontnum.Size = new System.Drawing.Size(249, 24);
            this.textcontnum.TabIndex = 16;
            // 
            // textid
            // 
            this.textid.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textid.Location = new System.Drawing.Point(179, 228);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(249, 29);
            this.textid.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(18, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(410, 37);
            this.button4.TabIndex = 14;
            this.button4.Text = " Account Access";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(14, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Database Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(210, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(14, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Account Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(14, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "ID Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(14, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Name";
            // 
            // textacunum
            // 
            this.textacunum.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textacunum.Location = new System.Drawing.Point(179, 370);
            this.textacunum.Multiline = true;
            this.textacunum.Name = "textacunum";
            this.textacunum.Size = new System.Drawing.Size(249, 24);
            this.textacunum.TabIndex = 2;
            // 
            // textidnum
            // 
            this.textidnum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textidnum.Location = new System.Drawing.Point(179, 323);
            this.textidnum.Multiline = true;
            this.textidnum.Name = "textidnum";
            this.textidnum.Size = new System.Drawing.Size(249, 24);
            this.textidnum.TabIndex = 1;
            // 
            // textname
            // 
            this.textname.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textname.Location = new System.Drawing.Point(179, 276);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(249, 24);
            this.textname.TabIndex = 0;
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.imageBox1.BackgroundImage = global::MultiFaceRec.Properties.Resources.background_gradient_blue_05_jpg_max;
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(20, 459);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(10, 10);
            this.imageBox1.TabIndex = 18;
            this.imageBox1.TabStop = false;
            this.imageBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Californian FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(33, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "Match Found";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiFaceRec.Properties.Resources.background_gradient_blue_05_jpg_max;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1213, 546);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Recognition";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textacunum;
        private System.Windows.Forms.TextBox textidnum;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textnum;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textcontnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label1;
    }
}