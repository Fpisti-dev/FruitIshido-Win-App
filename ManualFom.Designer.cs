namespace FruitIshido
{
    partial class ManualForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblManualFirstPage = new System.Windows.Forms.Label();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.panSecondPage = new System.Windows.Forms.Panel();
            this.panThirdPage = new System.Windows.Forms.Panel();
            this.panFourthPage = new System.Windows.Forms.Panel();
            this.panFifthPage = new System.Windows.Forms.Panel();
            this.btnHomeFifthPage = new System.Windows.Forms.Button();
            this.btnPrevFifthPage = new System.Windows.Forms.Button();
            this.lblManualFifthPage = new System.Windows.Forms.Label();
            this.lblReferences = new System.Windows.Forms.Label();
            this.picFourthPage = new System.Windows.Forms.PictureBox();
            this.btnNextFourthPage = new System.Windows.Forms.Button();
            this.btnPrevFourthPage = new System.Windows.Forms.Button();
            this.lblManualFourthPage = new System.Windows.Forms.Label();
            this.lblScoring = new System.Windows.Forms.Label();
            this.btnPrevThirdPage = new System.Windows.Forms.Button();
            this.btnNextThirdPage = new System.Windows.Forms.Button();
            this.lblManualThirdPage = new System.Windows.Forms.Label();
            this.picThirdPage = new System.Windows.Forms.PictureBox();
            this.lblTheGame = new System.Windows.Forms.Label();
            this.btnPrevSecondPage = new System.Windows.Forms.Button();
            this.btnNextSecondPage = new System.Windows.Forms.Button();
            this.lblManualSecondPage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblManual2 = new System.Windows.Forms.Label();
            this.pictFirstPage = new System.Windows.Forms.PictureBox();
            this.panSecondPage.SuspendLayout();
            this.panThirdPage.SuspendLayout();
            this.panFourthPage.SuspendLayout();
            this.panFifthPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFourthPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThirdPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictFirstPage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manual";
            // 
            // lblManualFirstPage
            // 
            this.lblManualFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualFirstPage.Location = new System.Drawing.Point(80, 320);
            this.lblManualFirstPage.Name = "lblManualFirstPage";
            this.lblManualFirstPage.Size = new System.Drawing.Size(620, 160);
            this.lblManualFirstPage.TabIndex = 1;
            this.lblManualFirstPage.Text = "-";
            // 
            // btnNext1
            // 
            this.btnNext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext1.Location = new System.Drawing.Point(650, 500);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(80, 25);
            this.btnNext1.TabIndex = 2;
            this.btnNext1.Text = "Next Page";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // panSecondPage
            // 
            this.panSecondPage.Controls.Add(this.panThirdPage);
            this.panSecondPage.Controls.Add(this.btnPrevSecondPage);
            this.panSecondPage.Controls.Add(this.btnNextSecondPage);
            this.panSecondPage.Controls.Add(this.lblManualSecondPage);
            this.panSecondPage.Controls.Add(this.pictureBox1);
            this.panSecondPage.Controls.Add(this.lblManual2);
            this.panSecondPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSecondPage.Location = new System.Drawing.Point(0, 0);
            this.panSecondPage.Name = "panSecondPage";
            this.panSecondPage.Size = new System.Drawing.Size(784, 562);
            this.panSecondPage.TabIndex = 4;
            // 
            // panThirdPage
            // 
            this.panThirdPage.Controls.Add(this.panFourthPage);
            this.panThirdPage.Controls.Add(this.btnPrevThirdPage);
            this.panThirdPage.Controls.Add(this.btnNextThirdPage);
            this.panThirdPage.Controls.Add(this.lblManualThirdPage);
            this.panThirdPage.Controls.Add(this.picThirdPage);
            this.panThirdPage.Controls.Add(this.lblTheGame);
            this.panThirdPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panThirdPage.Location = new System.Drawing.Point(0, 0);
            this.panThirdPage.Name = "panThirdPage";
            this.panThirdPage.Size = new System.Drawing.Size(784, 562);
            this.panThirdPage.TabIndex = 5;
            // 
            // panFourthPage
            // 
            this.panFourthPage.Controls.Add(this.panFifthPage);
            this.panFourthPage.Controls.Add(this.picFourthPage);
            this.panFourthPage.Controls.Add(this.btnNextFourthPage);
            this.panFourthPage.Controls.Add(this.btnPrevFourthPage);
            this.panFourthPage.Controls.Add(this.lblManualFourthPage);
            this.panFourthPage.Controls.Add(this.lblScoring);
            this.panFourthPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFourthPage.Location = new System.Drawing.Point(0, 0);
            this.panFourthPage.Name = "panFourthPage";
            this.panFourthPage.Size = new System.Drawing.Size(784, 562);
            this.panFourthPage.TabIndex = 5;
            // 
            // panFifthPage
            // 
            this.panFifthPage.Controls.Add(this.btnHomeFifthPage);
            this.panFifthPage.Controls.Add(this.btnPrevFifthPage);
            this.panFifthPage.Controls.Add(this.lblManualFifthPage);
            this.panFifthPage.Controls.Add(this.lblReferences);
            this.panFifthPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFifthPage.Location = new System.Drawing.Point(0, 0);
            this.panFifthPage.Name = "panFifthPage";
            this.panFifthPage.Size = new System.Drawing.Size(784, 562);
            this.panFifthPage.TabIndex = 5;
            // 
            // btnHomeFifthPage
            // 
            this.btnHomeFifthPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeFifthPage.Location = new System.Drawing.Point(650, 500);
            this.btnHomeFifthPage.Name = "btnHomeFifthPage";
            this.btnHomeFifthPage.Size = new System.Drawing.Size(80, 25);
            this.btnHomeFifthPage.TabIndex = 3;
            this.btnHomeFifthPage.Text = "Home";
            this.btnHomeFifthPage.UseVisualStyleBackColor = true;
            this.btnHomeFifthPage.Click += new System.EventHandler(this.btnHomeFifthPage_Click);
            // 
            // btnPrevFifthPage
            // 
            this.btnPrevFifthPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevFifthPage.Location = new System.Drawing.Point(60, 500);
            this.btnPrevFifthPage.Name = "btnPrevFifthPage";
            this.btnPrevFifthPage.Size = new System.Drawing.Size(105, 25);
            this.btnPrevFifthPage.TabIndex = 2;
            this.btnPrevFifthPage.Text = "Previous Page";
            this.btnPrevFifthPage.UseVisualStyleBackColor = true;
            this.btnPrevFifthPage.Click += new System.EventHandler(this.btnPrevFifthPage_Click);
            // 
            // lblManualFifthPage
            // 
            this.lblManualFifthPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualFifthPage.Location = new System.Drawing.Point(80, 100);
            this.lblManualFifthPage.Name = "lblManualFifthPage";
            this.lblManualFifthPage.Size = new System.Drawing.Size(620, 160);
            this.lblManualFifthPage.TabIndex = 1;
            this.lblManualFifthPage.Text = "-";
            // 
            // lblReferences
            // 
            this.lblReferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferences.Location = new System.Drawing.Point(40, 30);
            this.lblReferences.Name = "lblReferences";
            this.lblReferences.Size = new System.Drawing.Size(120, 25);
            this.lblReferences.TabIndex = 0;
            this.lblReferences.Text = "References";
            // 
            // picFourthPage
            // 
            this.picFourthPage.Image = global::FruitIshido.Properties.Resources.Scores;
            this.picFourthPage.Location = new System.Drawing.Point(60, 112);
            this.picFourthPage.Name = "picFourthPage";
            this.picFourthPage.Size = new System.Drawing.Size(145, 334);
            this.picFourthPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFourthPage.TabIndex = 4;
            this.picFourthPage.TabStop = false;
            this.picFourthPage.Click += new System.EventHandler(this.picFourthPage_Click);
            // 
            // btnNextFourthPage
            // 
            this.btnNextFourthPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextFourthPage.Location = new System.Drawing.Point(650, 500);
            this.btnNextFourthPage.Name = "btnNextFourthPage";
            this.btnNextFourthPage.Size = new System.Drawing.Size(80, 25);
            this.btnNextFourthPage.TabIndex = 3;
            this.btnNextFourthPage.Text = "Next Page";
            this.btnNextFourthPage.UseVisualStyleBackColor = true;
            this.btnNextFourthPage.Click += new System.EventHandler(this.btnNextFourthPage_Click);
            // 
            // btnPrevFourthPage
            // 
            this.btnPrevFourthPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevFourthPage.Location = new System.Drawing.Point(60, 500);
            this.btnPrevFourthPage.Name = "btnPrevFourthPage";
            this.btnPrevFourthPage.Size = new System.Drawing.Size(105, 25);
            this.btnPrevFourthPage.TabIndex = 2;
            this.btnPrevFourthPage.Text = "Previous Page";
            this.btnPrevFourthPage.UseVisualStyleBackColor = true;
            this.btnPrevFourthPage.Click += new System.EventHandler(this.btnPrevFourthPage_Click);
            // 
            // lblManualFourthPage
            // 
            this.lblManualFourthPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualFourthPage.Location = new System.Drawing.Point(250, 100);
            this.lblManualFourthPage.Name = "lblManualFourthPage";
            this.lblManualFourthPage.Size = new System.Drawing.Size(450, 371);
            this.lblManualFourthPage.TabIndex = 1;
            this.lblManualFourthPage.Text = "-";
            // 
            // lblScoring
            // 
            this.lblScoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoring.Location = new System.Drawing.Point(40, 30);
            this.lblScoring.Name = "lblScoring";
            this.lblScoring.Size = new System.Drawing.Size(125, 25);
            this.lblScoring.TabIndex = 0;
            this.lblScoring.Text = "Scoring";
            // 
            // btnPrevThirdPage
            // 
            this.btnPrevThirdPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevThirdPage.Location = new System.Drawing.Point(60, 500);
            this.btnPrevThirdPage.Name = "btnPrevThirdPage";
            this.btnPrevThirdPage.Size = new System.Drawing.Size(105, 25);
            this.btnPrevThirdPage.TabIndex = 4;
            this.btnPrevThirdPage.Text = "Previous Page";
            this.btnPrevThirdPage.UseVisualStyleBackColor = true;
            this.btnPrevThirdPage.Click += new System.EventHandler(this.btnPrevThirdPage_Click);
            // 
            // btnNextThirdPage
            // 
            this.btnNextThirdPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextThirdPage.Location = new System.Drawing.Point(650, 500);
            this.btnNextThirdPage.Name = "btnNextThirdPage";
            this.btnNextThirdPage.Size = new System.Drawing.Size(80, 25);
            this.btnNextThirdPage.TabIndex = 3;
            this.btnNextThirdPage.Text = "Next Page";
            this.btnNextThirdPage.UseVisualStyleBackColor = true;
            this.btnNextThirdPage.Click += new System.EventHandler(this.btnNextThirdPage_Click);
            // 
            // lblManualThirdPage
            // 
            this.lblManualThirdPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualThirdPage.Location = new System.Drawing.Point(80, 262);
            this.lblManualThirdPage.Name = "lblManualThirdPage";
            this.lblManualThirdPage.Size = new System.Drawing.Size(620, 218);
            this.lblManualThirdPage.TabIndex = 2;
            this.lblManualThirdPage.Text = "-";
            // 
            // picThirdPage
            // 
            this.picThirdPage.Image = global::FruitIshido.Properties.Resources.FruitIshido10;
            this.picThirdPage.Location = new System.Drawing.Point(250, 30);
            this.picThirdPage.Name = "picThirdPage";
            this.picThirdPage.Size = new System.Drawing.Size(350, 215);
            this.picThirdPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThirdPage.TabIndex = 1;
            this.picThirdPage.TabStop = false;
            this.picThirdPage.Click += new System.EventHandler(this.picThirdPage_Click);
            // 
            // lblTheGame
            // 
            this.lblTheGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheGame.Location = new System.Drawing.Point(40, 30);
            this.lblTheGame.Name = "lblTheGame";
            this.lblTheGame.Size = new System.Drawing.Size(125, 25);
            this.lblTheGame.TabIndex = 0;
            this.lblTheGame.Text = "The Game";
            // 
            // btnPrevSecondPage
            // 
            this.btnPrevSecondPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevSecondPage.Location = new System.Drawing.Point(60, 500);
            this.btnPrevSecondPage.Name = "btnPrevSecondPage";
            this.btnPrevSecondPage.Size = new System.Drawing.Size(105, 25);
            this.btnPrevSecondPage.TabIndex = 4;
            this.btnPrevSecondPage.Text = "Previous Page";
            this.btnPrevSecondPage.UseVisualStyleBackColor = true;
            this.btnPrevSecondPage.Click += new System.EventHandler(this.btnPrevSecondPage_Click);
            // 
            // btnNextSecondPage
            // 
            this.btnNextSecondPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextSecondPage.Location = new System.Drawing.Point(650, 500);
            this.btnNextSecondPage.Name = "btnNextSecondPage";
            this.btnNextSecondPage.Size = new System.Drawing.Size(80, 25);
            this.btnNextSecondPage.TabIndex = 3;
            this.btnNextSecondPage.Text = "Next Page";
            this.btnNextSecondPage.UseVisualStyleBackColor = true;
            this.btnNextSecondPage.Click += new System.EventHandler(this.btnNextSecondPage_Click);
            // 
            // lblManualSecondPage
            // 
            this.lblManualSecondPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualSecondPage.Location = new System.Drawing.Point(80, 320);
            this.lblManualSecondPage.Name = "lblManualSecondPage";
            this.lblManualSecondPage.Size = new System.Drawing.Size(620, 160);
            this.lblManualSecondPage.TabIndex = 2;
            this.lblManualSecondPage.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FruitIshido.Properties.Resources.FruitSet;
            this.pictureBox1.Location = new System.Drawing.Point(250, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblManual2
            // 
            this.lblManual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual2.Location = new System.Drawing.Point(40, 30);
            this.lblManual2.Name = "lblManual2";
            this.lblManual2.Size = new System.Drawing.Size(80, 25);
            this.lblManual2.TabIndex = 0;
            this.lblManual2.Text = "Manual";
            // 
            // pictFirstPage
            // 
            this.pictFirstPage.Image = global::FruitIshido.Properties.Resources.EmptyTable;
            this.pictFirstPage.Location = new System.Drawing.Point(250, 30);
            this.pictFirstPage.Name = "pictFirstPage";
            this.pictFirstPage.Size = new System.Drawing.Size(350, 250);
            this.pictFirstPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictFirstPage.TabIndex = 3;
            this.pictFirstPage.TabStop = false;
            this.pictFirstPage.Click += new System.EventHandler(this.pictFirstPage_Click);
            // 
            // ManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panSecondPage);
            this.Controls.Add(this.pictFirstPage);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.lblManualFirstPage);
            this.Controls.Add(this.lblTitle);
            this.Name = "ManualForm";
            this.Text = "Manual";
            this.Load += new System.EventHandler(this.ManualForm_Load);
            this.panSecondPage.ResumeLayout(false);
            this.panThirdPage.ResumeLayout(false);
            this.panFourthPage.ResumeLayout(false);
            this.panFifthPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFourthPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThirdPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictFirstPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblManualFirstPage;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.PictureBox pictFirstPage;
        private System.Windows.Forms.Panel panSecondPage;
        private System.Windows.Forms.Label lblManualSecondPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManual2;
        private System.Windows.Forms.Button btnPrevSecondPage;
        private System.Windows.Forms.Button btnNextSecondPage;
        private System.Windows.Forms.Panel panThirdPage;
        private System.Windows.Forms.PictureBox picThirdPage;
        private System.Windows.Forms.Label lblTheGame;
        private System.Windows.Forms.Label lblManualThirdPage;
        private System.Windows.Forms.Button btnPrevThirdPage;
        private System.Windows.Forms.Button btnNextThirdPage;
        private System.Windows.Forms.Panel panFourthPage;
        private System.Windows.Forms.Label lblManualFourthPage;
        private System.Windows.Forms.Label lblScoring;
        private System.Windows.Forms.Button btnNextFourthPage;
        private System.Windows.Forms.Button btnPrevFourthPage;
        private System.Windows.Forms.PictureBox picFourthPage;
        private System.Windows.Forms.Panel panFifthPage;
        private System.Windows.Forms.Label lblManualFifthPage;
        private System.Windows.Forms.Label lblReferences;
        private System.Windows.Forms.Button btnPrevFifthPage;
        private System.Windows.Forms.Button btnHomeFifthPage;
    }
}