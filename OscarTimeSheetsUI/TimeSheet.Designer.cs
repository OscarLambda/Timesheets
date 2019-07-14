namespace OscarTimeSheetsUI
{
    partial class TimeSheet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.clockin = new System.Windows.Forms.Button();
            this.breakin = new System.Windows.Forms.Button();
            this.breakout = new System.Windows.Forms.Button();
            this.clockout = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.endtime = new System.Windows.Forms.Label();
            this.startbreak = new System.Windows.Forms.Label();
            this.endbreak = new System.Windows.Forms.Label();
            this.totaltime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(538, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(644, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(115, 25);
            this.name.TabIndex = 1;
            this.name.Text = "Welcome!";
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(719, 37);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(83, 43);
            this.logout.TabIndex = 2;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // clockin
            // 
            this.clockin.Location = new System.Drawing.Point(556, 69);
            this.clockin.Name = "clockin";
            this.clockin.Size = new System.Drawing.Size(102, 65);
            this.clockin.TabIndex = 3;
            this.clockin.Text = "Clock In";
            this.clockin.UseVisualStyleBackColor = true;
            this.clockin.Click += new System.EventHandler(this.clockin_Click);
            // 
            // breakin
            // 
            this.breakin.Location = new System.Drawing.Point(556, 159);
            this.breakin.Name = "breakin";
            this.breakin.Size = new System.Drawing.Size(102, 65);
            this.breakin.TabIndex = 4;
            this.breakin.Text = "Break In";
            this.breakin.UseVisualStyleBackColor = true;
            this.breakin.Visible = false;
            this.breakin.Click += new System.EventHandler(this.breakin_Click);
            // 
            // breakout
            // 
            this.breakout.Location = new System.Drawing.Point(556, 257);
            this.breakout.Name = "breakout";
            this.breakout.Size = new System.Drawing.Size(102, 65);
            this.breakout.TabIndex = 5;
            this.breakout.Text = "Break Out";
            this.breakout.UseVisualStyleBackColor = true;
            this.breakout.Visible = false;
            this.breakout.Click += new System.EventHandler(this.breakout_Click);
            // 
            // clockout
            // 
            this.clockout.Location = new System.Drawing.Point(556, 363);
            this.clockout.Name = "clockout";
            this.clockout.Size = new System.Drawing.Size(102, 65);
            this.clockout.TabIndex = 6;
            this.clockout.Text = "Clock Out";
            this.clockout.UseVisualStyleBackColor = true;
            this.clockout.Visible = false;
            this.clockout.Click += new System.EventHandler(this.clockout_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(675, 95);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 13);
            this.time.TabIndex = 7;
            // 
            // endtime
            // 
            this.endtime.AutoSize = true;
            this.endtime.Location = new System.Drawing.Point(665, 389);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(0, 13);
            this.endtime.TabIndex = 8;
            // 
            // startbreak
            // 
            this.startbreak.AutoSize = true;
            this.startbreak.Location = new System.Drawing.Point(664, 185);
            this.startbreak.Name = "startbreak";
            this.startbreak.Size = new System.Drawing.Size(0, 13);
            this.startbreak.TabIndex = 9;
            // 
            // endbreak
            // 
            this.endbreak.AutoSize = true;
            this.endbreak.Location = new System.Drawing.Point(665, 283);
            this.endbreak.Name = "endbreak";
            this.endbreak.Size = new System.Drawing.Size(0, 13);
            this.endbreak.TabIndex = 10;
            // 
            // totaltime
            // 
            this.totaltime.AutoSize = true;
            this.totaltime.Location = new System.Drawing.Point(639, 233);
            this.totaltime.Name = "totaltime";
            this.totaltime.Size = new System.Drawing.Size(0, 13);
            this.totaltime.TabIndex = 11;
            // 
            // TimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 459);
            this.Controls.Add(this.totaltime);
            this.Controls.Add(this.endbreak);
            this.Controls.Add(this.startbreak);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.time);
            this.Controls.Add(this.clockout);
            this.Controls.Add(this.breakout);
            this.Controls.Add(this.breakin);
            this.Controls.Add(this.clockin);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TimeSheet";
            this.Text = "TimeSheet";
            this.Load += new System.EventHandler(this.TimeSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button clockin;
        private System.Windows.Forms.Button breakin;
        private System.Windows.Forms.Button breakout;
        private System.Windows.Forms.Button clockout;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label endtime;
        private System.Windows.Forms.Label startbreak;
        private System.Windows.Forms.Label endbreak;
        private System.Windows.Forms.Label totaltime;
    }
}