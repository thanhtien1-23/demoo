namespace lab4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lstBandau = new System.Windows.Forms.ListBox();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnPhaisangtrai = new System.Windows.Forms.Button();
            this.btnTatcaphaisangtrai = new System.Windows.Forms.Button();
            this.btnTraisangphai = new System.Windows.Forms.Button();
            this.btnKetqua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTatcatraisangphai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp B:";
            // 
            // txtHoten
            // 
            this.txtHoten.AcceptsReturn = true;
            this.txtHoten.Location = new System.Drawing.Point(161, 68);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(357, 22);
            this.txtHoten.TabIndex = 4;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
            // 
            // lstBandau
            // 
            this.lstBandau.FormattingEnabled = true;
            this.lstBandau.ItemHeight = 16;
            this.lstBandau.Location = new System.Drawing.Point(61, 178);
            this.lstBandau.Name = "lstBandau";
            this.lstBandau.Size = new System.Drawing.Size(193, 196);
            this.lstBandau.TabIndex = 5;
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 16;
            this.lstKetqua.Location = new System.Drawing.Point(435, 178);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(207, 196);
            this.lstKetqua.TabIndex = 6;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(558, 67);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(84, 23);
            this.btnCapnhat.TabIndex = 7;
            this.btnCapnhat.Text = "Cập nhật:";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnPhaisangtrai
            // 
            this.btnPhaisangtrai.Location = new System.Drawing.Point(337, 208);
            this.btnPhaisangtrai.Name = "btnPhaisangtrai";
            this.btnPhaisangtrai.Size = new System.Drawing.Size(47, 23);
            this.btnPhaisangtrai.TabIndex = 8;
            this.btnPhaisangtrai.Text = "<";
            this.btnPhaisangtrai.UseVisualStyleBackColor = true;
            this.btnPhaisangtrai.Click += new System.EventHandler(this.btnPhaisangtrai_Click);
            // 
            // btnTatcaphaisangtrai
            // 
            this.btnTatcaphaisangtrai.Location = new System.Drawing.Point(337, 279);
            this.btnTatcaphaisangtrai.Name = "btnTatcaphaisangtrai";
            this.btnTatcaphaisangtrai.Size = new System.Drawing.Size(47, 22);
            this.btnTatcaphaisangtrai.TabIndex = 9;
            this.btnTatcaphaisangtrai.Text = "<<";
            this.btnTatcaphaisangtrai.UseVisualStyleBackColor = true;
            this.btnTatcaphaisangtrai.Click += new System.EventHandler(this.btnTatcaphaisangtrai_Click);
            // 
            // btnTraisangphai
            // 
            this.btnTraisangphai.Location = new System.Drawing.Point(283, 208);
            this.btnTraisangphai.Name = "btnTraisangphai";
            this.btnTraisangphai.Size = new System.Drawing.Size(47, 23);
            this.btnTraisangphai.TabIndex = 10;
            this.btnTraisangphai.Text = ">";
            this.btnTraisangphai.UseVisualStyleBackColor = true;
            this.btnTraisangphai.Click += new System.EventHandler(this.btnTraisangphai_Click);
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(494, 380);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(84, 23);
            this.btnKetqua.TabIndex = 11;
            this.btnKetqua.Text = "Kết thúc";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(105, 380);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTatcatraisangphai
            // 
            this.btnTatcatraisangphai.Location = new System.Drawing.Point(283, 278);
            this.btnTatcatraisangphai.Name = "btnTatcatraisangphai";
            this.btnTatcatraisangphai.Size = new System.Drawing.Size(47, 23);
            this.btnTatcatraisangphai.TabIndex = 13;
            this.btnTatcatraisangphai.Text = ">>";
            this.btnTatcatraisangphai.UseVisualStyleBackColor = true;
            this.btnTatcatraisangphai.Click += new System.EventHandler(this.btnTatcatraisangphai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.btnTatcatraisangphai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.btnTraisangphai);
            this.Controls.Add(this.btnTatcaphaisangtrai);
            this.Controls.Add(this.btnPhaisangtrai);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.lstKetqua);
            this.Controls.Add(this.lstBandau);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Quản lí sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ListBox lstBandau;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.Button btnPhaisangtrai;
        private System.Windows.Forms.Button btnTatcaphaisangtrai;
        private System.Windows.Forms.Button btnTraisangphai;
        private System.Windows.Forms.Button btnKetqua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTatcatraisangphai;
        private System.Windows.Forms.Button btnCapnhat;
    }
}

