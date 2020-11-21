namespace FruitIshido
{
    partial class Ishido
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tOP10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panInformation = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFourWayDisplay = new System.Windows.Forms.Label();
            this.lblLeftStoneDisplay = new System.Windows.Forms.Label();
            this.lblUsedStoneDisplay = new System.Windows.Forms.Label();
            this.lblMessageDisplay = new System.Windows.Forms.Label();
            this.lblScoreDisplay = new System.Windows.Forms.Label();
            this.lblMessages = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblFourWays = new System.Windows.Forms.Label();
            this.lbLeftStones = new System.Windows.Forms.Label();
            this.lblUsedStones = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.panNextStone = new System.Windows.Forms.Panel();
            this.lblNextStone = new System.Windows.Forms.Label();
            this.panGame = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panInformation.SuspendLayout();
            this.panNextStone.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tOP10ToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tOP10ToolStripMenuItem
            // 
            this.tOP10ToolStripMenuItem.Name = "tOP10ToolStripMenuItem";
            this.tOP10ToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.tOP10ToolStripMenuItem.Text = " TOP 10";
            this.tOP10ToolStripMenuItem.Click += new System.EventHandler(this.tOP10ToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panInformation
            // 
            this.panInformation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panInformation.Controls.Add(this.btnLoad);
            this.panInformation.Controls.Add(this.btnSave);
            this.panInformation.Controls.Add(this.lblFourWayDisplay);
            this.panInformation.Controls.Add(this.lblLeftStoneDisplay);
            this.panInformation.Controls.Add(this.lblUsedStoneDisplay);
            this.panInformation.Controls.Add(this.lblMessageDisplay);
            this.panInformation.Controls.Add(this.lblScoreDisplay);
            this.panInformation.Controls.Add(this.lblMessages);
            this.panInformation.Controls.Add(this.btnNewGame);
            this.panInformation.Controls.Add(this.lblFourWays);
            this.panInformation.Controls.Add(this.lbLeftStones);
            this.panInformation.Controls.Add(this.lblUsedStones);
            this.panInformation.Controls.Add(this.lblNext);
            this.panInformation.Controls.Add(this.lblScore);
            this.panInformation.Controls.Add(this.panNextStone);
            this.panInformation.Location = new System.Drawing.Point(0, 33);
            this.panInformation.Margin = new System.Windows.Forms.Padding(4);
            this.panInformation.Name = "panInformation";
            this.panInformation.Size = new System.Drawing.Size(240, 510);
            this.panInformation.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(151, 418);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 60);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(151, 329);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 60);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFourWayDisplay
            // 
            this.lblFourWayDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFourWayDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourWayDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFourWayDisplay.Location = new System.Drawing.Point(30, 421);
            this.lblFourWayDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFourWayDisplay.Name = "lblFourWayDisplay";
            this.lblFourWayDisplay.Size = new System.Drawing.Size(77, 28);
            this.lblFourWayDisplay.TabIndex = 17;
            this.lblFourWayDisplay.Text = "0";
            this.lblFourWayDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLeftStoneDisplay
            // 
            this.lblLeftStoneDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLeftStoneDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftStoneDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLeftStoneDisplay.Location = new System.Drawing.Point(31, 357);
            this.lblLeftStoneDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeftStoneDisplay.Name = "lblLeftStoneDisplay";
            this.lblLeftStoneDisplay.Size = new System.Drawing.Size(76, 28);
            this.lblLeftStoneDisplay.TabIndex = 16;
            this.lblLeftStoneDisplay.Text = "0";
            this.lblLeftStoneDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsedStoneDisplay
            // 
            this.lblUsedStoneDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsedStoneDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedStoneDisplay.ForeColor = System.Drawing.Color.Blue;
            this.lblUsedStoneDisplay.Location = new System.Drawing.Point(31, 288);
            this.lblUsedStoneDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsedStoneDisplay.Name = "lblUsedStoneDisplay";
            this.lblUsedStoneDisplay.Size = new System.Drawing.Size(76, 28);
            this.lblUsedStoneDisplay.TabIndex = 15;
            this.lblUsedStoneDisplay.Text = "0";
            this.lblUsedStoneDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMessageDisplay
            // 
            this.lblMessageDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblMessageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageDisplay.Location = new System.Drawing.Point(95, 31);
            this.lblMessageDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessageDisplay.Name = "lblMessageDisplay";
            this.lblMessageDisplay.Size = new System.Drawing.Size(129, 22);
            this.lblMessageDisplay.TabIndex = 14;
            // 
            // lblScoreDisplay
            // 
            this.lblScoreDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblScoreDisplay.Location = new System.Drawing.Point(19, 98);
            this.lblScoreDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreDisplay.Name = "lblScoreDisplay";
            this.lblScoreDisplay.Size = new System.Drawing.Size(111, 28);
            this.lblScoreDisplay.TabIndex = 13;
            this.lblScoreDisplay.Text = "0";
            this.lblScoreDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMessages
            // 
            this.lblMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessages.Location = new System.Drawing.Point(4, 31);
            this.lblMessages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(103, 22);
            this.lblMessages.TabIndex = 11;
            this.lblMessages.Text = "Messages:";
            this.lblMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(151, 240);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(60, 60);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblFourWays
            // 
            this.lblFourWays.AutoSize = true;
            this.lblFourWays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourWays.Location = new System.Drawing.Point(26, 396);
            this.lblFourWays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFourWays.Name = "lblFourWays";
            this.lblFourWays.Size = new System.Drawing.Size(90, 20);
            this.lblFourWays.TabIndex = 8;
            this.lblFourWays.Text = "Four Ways";
            this.lblFourWays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLeftStones
            // 
            this.lbLeftStones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeftStones.Location = new System.Drawing.Point(-5, 326);
            this.lbLeftStones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLeftStones.Name = "lbLeftStones";
            this.lbLeftStones.Size = new System.Drawing.Size(155, 28);
            this.lbLeftStones.TabIndex = 6;
            this.lbLeftStones.Text = "Left Stones";
            this.lbLeftStones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsedStones
            // 
            this.lblUsedStones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedStones.Location = new System.Drawing.Point(-17, 258);
            this.lblUsedStones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsedStones.Name = "lblUsedStones";
            this.lblUsedStones.Size = new System.Drawing.Size(181, 28);
            this.lblUsedStones.TabIndex = 4;
            this.lblUsedStones.Text = "Used Stones";
            this.lblUsedStones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNext
            // 
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(4, 135);
            this.lblNext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(133, 28);
            this.lblNext.TabIndex = 3;
            this.lblNext.Text = "Next Stone";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 70);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(133, 28);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panNextStone
            // 
            this.panNextStone.Controls.Add(this.lblNextStone);
            this.panNextStone.Location = new System.Drawing.Point(31, 170);
            this.panNextStone.Margin = new System.Windows.Forms.Padding(4);
            this.panNextStone.Name = "panNextStone";
            this.panNextStone.Size = new System.Drawing.Size(80, 74);
            this.panNextStone.TabIndex = 0;
            // 
            // lblNextStone
            // 
            this.lblNextStone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNextStone.Location = new System.Drawing.Point(0, 0);
            this.lblNextStone.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblNextStone.Name = "lblNextStone";
            this.lblNextStone.Size = new System.Drawing.Size(80, 74);
            this.lblNextStone.TabIndex = 0;
            // 
            // panGame
            // 
            this.panGame.Location = new System.Drawing.Point(248, 33);
            this.panGame.Margin = new System.Windows.Forms.Padding(4);
            this.panGame.Name = "panGame";
            this.panGame.Size = new System.Drawing.Size(797, 510);
            this.panGame.TabIndex = 2;
            // 
            // Ishido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 544);
            this.Controls.Add(this.panGame);
            this.Controls.Add(this.panInformation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ishido";
            this.Text = "FruitIshido";
            this.Load += new System.EventHandler(this.FruitIshido_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panInformation.ResumeLayout(false);
            this.panInformation.PerformLayout();
            this.panNextStone.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panGame;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Panel panInformation;
        private System.Windows.Forms.Panel panNextStone;
        private System.Windows.Forms.Label lblNextStone;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lbLeftStones;
        private System.Windows.Forms.Label lblUsedStones;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblFourWays;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Label lblScoreDisplay;
        private System.Windows.Forms.Label lblMessageDisplay;
        private System.Windows.Forms.Label lblUsedStoneDisplay;
        private System.Windows.Forms.Label lblLeftStoneDisplay;
        private System.Windows.Forms.Label lblFourWayDisplay;
        private System.Windows.Forms.ToolStripMenuItem tOP10ToolStripMenuItem;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
    }
}

