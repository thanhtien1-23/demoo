namespace Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnXoaphantudau = new System.Windows.Forms.Button();
            this.btnChonchandau = new System.Windows.Forms.Button();
            this.btnXoaphantudangchon = new System.Windows.Forms.Button();
            this.btnXoaphantucuoi = new System.Windows.Forms.Button();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.btnLecuoi = new System.Windows.Forms.Button();
            this.txtSonguyen = new System.Windows.Forms.TextBox();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức năng";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(527, 34);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 2;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(414, 123);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(166, 29);
            this.btnTang2.TabIndex = 3;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnXoaphantudau
            // 
            this.btnXoaphantudau.Location = new System.Drawing.Point(414, 302);
            this.btnXoaphantudau.Name = "btnXoaphantudau";
            this.btnXoaphantudau.Size = new System.Drawing.Size(166, 29);
            this.btnXoaphantudau.TabIndex = 4;
            this.btnXoaphantudau.Text = "Xóa phần tử đầu";
            this.btnXoaphantudau.UseVisualStyleBackColor = true;
            this.btnXoaphantudau.Click += new System.EventHandler(this.btnXoaphantudau_Click);
            // 
            // btnChonchandau
            // 
            this.btnChonchandau.Location = new System.Drawing.Point(414, 171);
            this.btnChonchandau.Name = "btnChonchandau";
            this.btnChonchandau.Size = new System.Drawing.Size(166, 28);
            this.btnChonchandau.TabIndex = 5;
            this.btnChonchandau.Text = "Chọn số chẳn đầu";
            this.btnChonchandau.UseVisualStyleBackColor = true;
            this.btnChonchandau.Click += new System.EventHandler(this.btnChonchandau_Click);
            // 
            // btnXoaphantudangchon
            // 
            this.btnXoaphantudangchon.Location = new System.Drawing.Point(414, 264);
            this.btnXoaphantudangchon.Name = "btnXoaphantudangchon";
            this.btnXoaphantudangchon.Size = new System.Drawing.Size(166, 32);
            this.btnXoaphantudangchon.TabIndex = 6;
            this.btnXoaphantudangchon.Text = "Xóa phần tử đang chọn";
            this.btnXoaphantudangchon.UseVisualStyleBackColor = true;
            this.btnXoaphantudangchon.Click += new System.EventHandler(this.btnXoaphantudangchon_Click);
            // 
            // btnXoaphantucuoi
            // 
            this.btnXoaphantucuoi.Location = new System.Drawing.Point(414, 346);
            this.btnXoaphantucuoi.Name = "btnXoaphantucuoi";
            this.btnXoaphantucuoi.Size = new System.Drawing.Size(166, 27);
            this.btnXoaphantucuoi.TabIndex = 7;
            this.btnXoaphantucuoi.Text = "Xóa phần tử cuối";
            this.btnXoaphantucuoi.UseVisualStyleBackColor = true;
            this.btnXoaphantucuoi.Click += new System.EventHandler(this.btnXoaphantucuoi_Click);
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Location = new System.Drawing.Point(318, 401);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetthuc.TabIndex = 8;
            this.btnKetthuc.Text = "kết thúc";
            this.btnKetthuc.UseVisualStyleBackColor = true;
            // 
            // btnLecuoi
            // 
            this.btnLecuoi.Location = new System.Drawing.Point(414, 219);
            this.btnLecuoi.Name = "btnLecuoi";
            this.btnLecuoi.Size = new System.Drawing.Size(166, 27);
            this.btnLecuoi.TabIndex = 9;
            this.btnLecuoi.Text = "chọn số lẻ cuối";
            this.btnLecuoi.UseVisualStyleBackColor = true;
            this.btnLecuoi.Click += new System.EventHandler(this.btnLecuoi_Click);
            // 
            // txtSonguyen
            // 
            this.txtSonguyen.Location = new System.Drawing.Point(136, 31);
            this.txtSonguyen.Name = "txtSonguyen";
            this.txtSonguyen.Size = new System.Drawing.Size(271, 22);
            this.txtSonguyen.TabIndex = 10;
            this.txtSonguyen.TextChanged += new System.EventHandler(this.txtSonguyen_TextChanged);
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 16;
            this.lstKetqua.Location = new System.Drawing.Point(51, 81);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(247, 292);
            this.lstKetqua.TabIndex = 11;
            this.lstKetqua.SelectedIndexChanged += new System.EventHandler(this.lstKetqua_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstKetqua);
            this.Controls.Add(this.txtSonguyen);
            this.Controls.Add(this.btnLecuoi);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.btnXoaphantucuoi);
            this.Controls.Add(this.btnXoaphantudangchon);
            this.Controls.Add(this.btnChonchandau);
            this.Controls.Add(this.btnXoaphantudau);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnXoaphantudau;
        private System.Windows.Forms.Button btnChonchandau;
        private System.Windows.Forms.Button btnXoaphantudangchon;
        private System.Windows.Forms.Button btnXoaphantucuoi;
        private System.Windows.Forms.Button btnKetthuc;
        private System.Windows.Forms.Button btnLecuoi;
        private System.Windows.Forms.TextBox txtSonguyen;
        private System.Windows.Forms.ListBox lstKetqua;
    }
}

