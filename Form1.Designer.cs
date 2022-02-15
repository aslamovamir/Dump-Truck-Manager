namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Status_LB = new System.Windows.Forms.Label();
            this.Exceeded_LB = new System.Windows.Forms.Label();
            this.Weight_Loader_LB = new System.Windows.Forms.Label();
            this.Trucks_Counter_LB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Total_LB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Current_Truck_Amount_LB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Location = new System.Drawing.Point(131, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 323);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Blackadder ITC", 29.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Truck Load Center";
            this.label1.UseWaitCursor = true;
            // 
            // Start_BTN
            // 
            this.Start_BTN.BackColor = System.Drawing.Color.Gray;
            this.Start_BTN.Font = new System.Drawing.Font("Myriad Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_BTN.ForeColor = System.Drawing.SystemColors.Window;
            this.Start_BTN.Location = new System.Drawing.Point(366, 356);
            this.Start_BTN.Name = "Start_BTN";
            this.Start_BTN.Size = new System.Drawing.Size(75, 29);
            this.Start_BTN.TabIndex = 2;
            this.Start_BTN.Text = "Start";
            this.Start_BTN.UseVisualStyleBackColor = false;
            this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dump Truck Manager";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Ivory;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(505, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 103);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label11.Location = new System.Drawing.Point(516, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total Amount Loaded:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Ivory;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(154, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(345, 188);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // Status_LB
            // 
            this.Status_LB.AutoSize = true;
            this.Status_LB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Status_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Status_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Status_LB.Location = new System.Drawing.Point(375, 300);
            this.Status_LB.Name = "Status_LB";
            this.Status_LB.Size = new System.Drawing.Size(13, 18);
            this.Status_LB.TabIndex = 22;
            this.Status_LB.Text = " ";
            // 
            // Exceeded_LB
            // 
            this.Exceeded_LB.AutoSize = true;
            this.Exceeded_LB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Exceeded_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exceeded_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Exceeded_LB.Location = new System.Drawing.Point(375, 264);
            this.Exceeded_LB.Name = "Exceeded_LB";
            this.Exceeded_LB.Size = new System.Drawing.Size(13, 18);
            this.Exceeded_LB.TabIndex = 21;
            this.Exceeded_LB.Text = " ";
            // 
            // Weight_Loader_LB
            // 
            this.Weight_Loader_LB.AutoSize = true;
            this.Weight_Loader_LB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Weight_Loader_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Weight_Loader_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Weight_Loader_LB.Location = new System.Drawing.Point(375, 194);
            this.Weight_Loader_LB.Name = "Weight_Loader_LB";
            this.Weight_Loader_LB.Size = new System.Drawing.Size(13, 18);
            this.Weight_Loader_LB.TabIndex = 20;
            this.Weight_Loader_LB.Text = " ";
            // 
            // Trucks_Counter_LB
            // 
            this.Trucks_Counter_LB.AutoSize = true;
            this.Trucks_Counter_LB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Trucks_Counter_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Trucks_Counter_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Trucks_Counter_LB.Location = new System.Drawing.Point(375, 161);
            this.Trucks_Counter_LB.Name = "Trucks_Counter_LB";
            this.Trucks_Counter_LB.Size = new System.Drawing.Size(13, 18);
            this.Trucks_Counter_LB.TabIndex = 19;
            this.Trucks_Counter_LB.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(166, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(166, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Exceeded 496 tons?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(166, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dump Weight of Loader:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(166, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Trucks Successfully Loaded:";
            // 
            // Total_LB
            // 
            this.Total_LB.AutoSize = true;
            this.Total_LB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Total_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Total_LB.Location = new System.Drawing.Point(545, 229);
            this.Total_LB.Name = "Total_LB";
            this.Total_LB.Size = new System.Drawing.Size(20, 27);
            this.Total_LB.TabIndex = 23;
            this.Total_LB.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(166, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Current Amount of Ore in Truck:";
            // 
            // Current_Truck_Amount_LB
            // 
            this.Current_Truck_Amount_LB.AutoSize = true;
            this.Current_Truck_Amount_LB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Current_Truck_Amount_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Current_Truck_Amount_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Current_Truck_Amount_LB.Location = new System.Drawing.Point(375, 229);
            this.Current_Truck_Amount_LB.Name = "Current_Truck_Amount_LB";
            this.Current_Truck_Amount_LB.Size = new System.Drawing.Size(13, 18);
            this.Current_Truck_Amount_LB.TabIndex = 25;
            this.Current_Truck_Amount_LB.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(612, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "tons";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(428, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "tons";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(428, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "tons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Current_Truck_Amount_LB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Total_LB);
            this.Controls.Add(this.Status_LB);
            this.Controls.Add(this.Exceeded_LB);
            this.Controls.Add(this.Weight_Loader_LB);
            this.Controls.Add(this.Trucks_Counter_LB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Start_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Status_LB;
        private System.Windows.Forms.Label Exceeded_LB;
        private System.Windows.Forms.Label Weight_Loader_LB;
        private System.Windows.Forms.Label Trucks_Counter_LB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Total_LB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Current_Truck_Amount_LB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

