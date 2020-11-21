namespace FruitIshido
{
    partial class Top10UpdateForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatement = new System.Windows.Forms.Label();
            this.dgvTop10Update = new System.Windows.Forms.DataGridView();
            this.lblNickName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNickName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop10Update)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(116, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 59);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Congratulation !";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatement
            // 
            this.lblStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement.Location = new System.Drawing.Point(144, 90);
            this.lblStatement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(195, 28);
            this.lblStatement.TabIndex = 1;
            this.lblStatement.Text = "You are in TOP 10";
            this.lblStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTop10Update
            // 
            this.dgvTop10Update.AllowUserToDeleteRows = false;
            this.dgvTop10Update.AllowUserToResizeColumns = false;
            this.dgvTop10Update.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dgvTop10Update.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTop10Update.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop10Update.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTop10Update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop10Update.Location = new System.Drawing.Point(111, 139);
            this.dgvTop10Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTop10Update.Name = "dgvTop10Update";
            this.dgvTop10Update.ReadOnly = true;
            this.dgvTop10Update.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTop10Update.RowHeadersVisible = false;
            this.dgvTop10Update.Size = new System.Drawing.Size(272, 300);
            this.dgvTop10Update.TabIndex = 2;
            // 
            // lblNickName
            // 
            this.lblNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickName.Location = new System.Drawing.Point(41, 517);
            this.lblNickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(239, 28);
            this.lblNickName.TabIndex = 3;
            this.lblNickName.Text = "Please enter your nickname:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(180, 610);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 59);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNickName
            // 
            this.txtNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickName.Location = new System.Drawing.Point(288, 518);
            this.txtNickName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(132, 26);
            this.txtNickName.TabIndex = 5;
            // 
            // Top10UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 684);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.dgvTop10Update);
            this.Controls.Add(this.lblStatement);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Top10UpdateForm";
            this.Text = "Top10UpdateForm";
            this.Load += new System.EventHandler(this.Top10UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop10Update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.DataGridView dgvTop10Update;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNickName;
    }
}