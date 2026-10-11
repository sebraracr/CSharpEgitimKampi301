namespace CSharpEgitimKampi301.EFProject
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
            this.btnList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGatByID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnList.Location = new System.Drawing.Point(114, 168);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(152, 26);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rehber Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(114, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(152, 20);
            this.txtId.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 287);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rehber Adı:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(114, 114);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(152, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rehber Soyadı:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(114, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 26);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btmDelete
            // 
            this.btmDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btmDelete.Location = new System.Drawing.Point(114, 256);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(152, 26);
            this.btmDelete.TabIndex = 9;
            this.btmDelete.Text = "Sil";
            this.btmDelete.UseVisualStyleBackColor = false;
            this.btmDelete.Click += new System.EventHandler(this.btmDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(114, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(152, 26);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGatByID
            // 
            this.btnGatByID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGatByID.Location = new System.Drawing.Point(114, 352);
            this.btnGatByID.Name = "btnGatByID";
            this.btnGatByID.Size = new System.Drawing.Size(152, 26);
            this.btnGatByID.TabIndex = 11;
            this.btnGatByID.Text = "Id\'ye Göre Getir";
            this.btnGatByID.UseVisualStyleBackColor = false;
            this.btnGatByID.Click += new System.EventHandler(this.btnGatByID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGatByID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.Text = "Rehber İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGatByID;
    }
}

