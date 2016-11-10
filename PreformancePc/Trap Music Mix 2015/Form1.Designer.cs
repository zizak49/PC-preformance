namespace Trap_Music_Mix_2015
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
            this.label1 = new System.Windows.Forms.Label();
            this.cpu_text = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ram_text = new System.Windows.Forms.TextBox();
            this.disk_text = new System.Windows.Forms.TextBox();
            this.wifi_text = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU status:";
            // 
            // cpu_text
            // 
            this.cpu_text.BackColor = System.Drawing.Color.White;
            this.cpu_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpu_text.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_text.ForeColor = System.Drawing.Color.Black;
            this.cpu_text.Location = new System.Drawing.Point(95, 9);
            this.cpu_text.Name = "cpu_text";
            this.cpu_text.ReadOnly = true;
            this.cpu_text.Size = new System.Drawing.Size(86, 15);
            this.cpu_text.TabIndex = 1;
            this.cpu_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cpu_text.WordWrap = false;
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(12, 42);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(63, 16);
            this.lable2.TabIndex = 2;
            this.lable2.Text = "Memory:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Disk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "WI-FI:";
            // 
            // ram_text
            // 
            this.ram_text.BackColor = System.Drawing.Color.White;
            this.ram_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ram_text.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_text.Location = new System.Drawing.Point(95, 42);
            this.ram_text.Name = "ram_text";
            this.ram_text.ReadOnly = true;
            this.ram_text.Size = new System.Drawing.Size(86, 15);
            this.ram_text.TabIndex = 5;
            this.ram_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ram_text.WordWrap = false;
            // 
            // disk_text
            // 
            this.disk_text.BackColor = System.Drawing.Color.White;
            this.disk_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disk_text.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disk_text.Location = new System.Drawing.Point(95, 73);
            this.disk_text.Name = "disk_text";
            this.disk_text.ReadOnly = true;
            this.disk_text.Size = new System.Drawing.Size(86, 15);
            this.disk_text.TabIndex = 6;
            this.disk_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.disk_text.WordWrap = false;
            // 
            // wifi_text
            // 
            this.wifi_text.BackColor = System.Drawing.Color.White;
            this.wifi_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wifi_text.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wifi_text.Location = new System.Drawing.Point(95, 106);
            this.wifi_text.Name = "wifi_text";
            this.wifi_text.ReadOnly = true;
            this.wifi_text.Size = new System.Drawing.Size(86, 15);
            this.wifi_text.TabIndex = 7;
            this.wifi_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wifi_text.WordWrap = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(183, 144);
            this.ControlBox = false;
            this.Controls.Add(this.wifi_text);
            this.Controls.Add(this.disk_text);
            this.Controls.Add(this.ram_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.cpu_text);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(500, 200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cpu_text;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ram_text;
        private System.Windows.Forms.TextBox disk_text;
        private System.Windows.Forms.TextBox wifi_text;
        private System.Windows.Forms.Timer timer1;
    }
}

