namespace Project1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxStudentList = new System.Windows.Forms.ListBox();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnClearStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxStudentList
            // 
            this.lbxStudentList.FormattingEnabled = true;
            this.lbxStudentList.ItemHeight = 16;
            this.lbxStudentList.Location = new System.Drawing.Point(45, 80);
            this.lbxStudentList.Name = "lbxStudentList";
            this.lbxStudentList.Size = new System.Drawing.Size(169, 244);
            this.lbxStudentList.TabIndex = 0;
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Location = new System.Drawing.Point(42, 46);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(95, 16);
            this.lblStudentList.TabIndex = 1;
            this.lblStudentList.Text = "Öğrenci Listesi";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(351, 86);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(77, 16);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Öğrenci Adı";
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Location = new System.Drawing.Point(431, 80);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(224, 22);
            this.tbxStudentName.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(580, 120);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnClearStudent
            // 
            this.btnClearStudent.Location = new System.Drawing.Point(45, 355);
            this.btnClearStudent.Name = "btnClearStudent";
            this.btnClearStudent.Size = new System.Drawing.Size(169, 23);
            this.btnClearStudent.TabIndex = 5;
            this.btnClearStudent.Text = "Sil";
            this.btnClearStudent.UseVisualStyleBackColor = true;
            this.btnClearStudent.Click += new System.EventHandler(this.btnClearStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.tbxStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.lbxStudentList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudentList;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnClearStudent;
    }
}

