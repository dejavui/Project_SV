
namespace Project_SV
{
    partial class frmmain_member
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
            this.btnxemdiem = new System.Windows.Forms.Button();
            this.txtnhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnxemthongtin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnxemdiem
            // 
            this.btnxemdiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnxemdiem.Image = global::Project_SV.Properties.Resources.colors;
            this.btnxemdiem.Location = new System.Drawing.Point(54, 88);
            this.btnxemdiem.Name = "btnxemdiem";
            this.btnxemdiem.Size = new System.Drawing.Size(170, 54);
            this.btnxemdiem.TabIndex = 1;
            this.btnxemdiem.Text = "Xem điểm";
            this.btnxemdiem.UseVisualStyleBackColor = false;
            this.btnxemdiem.Click += new System.EventHandler(this.btnxemdiem_Click);
            // 
            // txtnhan
            // 
            this.txtnhan.Location = new System.Drawing.Point(112, 9);
            this.txtnhan.Name = "txtnhan";
            this.txtnhan.ReadOnly = true;
            this.txtnhan.Size = new System.Drawing.Size(124, 29);
            this.txtnhan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản:";
            // 
            // btnlogout
            // 
            this.btnlogout.Image = global::Project_SV.Properties.Resources.out2;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(54, 148);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(170, 54);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "Đăng xuất";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnxemthongtin
            // 
            this.btnxemthongtin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnxemthongtin.Image = global::Project_SV.Properties.Resources.user;
            this.btnxemthongtin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxemthongtin.Location = new System.Drawing.Point(54, 28);
            this.btnxemthongtin.Name = "btnxemthongtin";
            this.btnxemthongtin.Size = new System.Drawing.Size(170, 54);
            this.btnxemthongtin.TabIndex = 0;
            this.btnxemthongtin.Text = "Xem thông tin";
            this.btnxemthongtin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxemthongtin.UseVisualStyleBackColor = true;
            this.btnxemthongtin.Click += new System.EventHandler(this.btnxemthongtin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxemthongtin);
            this.groupBox1.Controls.Add(this.btnxemdiem);
            this.groupBox1.Controls.Add(this.btnlogout);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 216);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // frmmain_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(305, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnhan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmmain_member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmmain_member_FormClosed);
            this.Load += new System.EventHandler(this.frmmain_member_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnxemthongtin;
        private System.Windows.Forms.Button btnxemdiem;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.TextBox txtnhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}