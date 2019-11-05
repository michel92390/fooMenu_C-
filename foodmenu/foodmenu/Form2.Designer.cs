namespace foodmenu
{
    partial class Form2
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
            this.textBox1f2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1f2 = new System.Windows.Forms.ListBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblReceipt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1f2
            // 
            this.textBox1f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1f2.ForeColor = System.Drawing.Color.Red;
            this.textBox1f2.Location = new System.Drawing.Point(239, 363);
            this.textBox1f2.Name = "textBox1f2";
            this.textBox1f2.Size = new System.Drawing.Size(150, 29);
            this.textBox1f2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Price";
            // 
            // listBox1f2
            // 
            this.listBox1f2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBox1f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1f2.FormattingEnabled = true;
            this.listBox1f2.ItemHeight = 16;
            this.listBox1f2.Location = new System.Drawing.Point(239, 97);
            this.listBox1f2.Name = "listBox1f2";
            this.listBox1f2.Size = new System.Drawing.Size(150, 260);
            this.listBox1f2.TabIndex = 2;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDateTime.Location = new System.Drawing.Point(12, 12);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(105, 24);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "Date/Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblReceipt
            // 
            this.lblReceipt.BackColor = System.Drawing.Color.Transparent;
            this.lblReceipt.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipt.ForeColor = System.Drawing.Color.Black;
            this.lblReceipt.Location = new System.Drawing.Point(248, 50);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReceipt.Size = new System.Drawing.Size(141, 44);
            this.lblReceipt.TabIndex = 4;
            this.lblReceipt.Text = "Receipt";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::foodmenu.Properties.Resources.high_fibre_food;
            this.ClientSize = new System.Drawing.Size(427, 401);
            this.Controls.Add(this.lblReceipt);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.listBox1f2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1f2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1f2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1f2;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblReceipt;
    }
}