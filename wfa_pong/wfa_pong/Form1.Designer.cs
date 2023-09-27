namespace wfa_pong
{
    partial class Tong
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tong));
            this.leftPlayer = new System.Windows.Forms.PictureBox();
            this.rightPlayer = new System.Windows.Forms.PictureBox();
            this.theBall = new System.Windows.Forms.PictureBox();
            this.scoreLeft = new System.Windows.Forms.Label();
            this.scoreRight = new System.Windows.Forms.Label();
            this.tongLogo = new System.Windows.Forms.PictureBox();
            this.theTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseInfo = new System.Windows.Forms.Label();
            this.pauseMenuCtn = new System.Windows.Forms.FlowLayoutPanel();
            this.restartBtn = new System.Windows.Forms.Button();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.leaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endGamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.endGameText = new System.Windows.Forms.Label();
            this.restartBtn2 = new System.Windows.Forms.Button();
            this.leaveBtn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongLogo)).BeginInit();
            this.pauseMenuCtn.SuspendLayout();
            this.endGamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPlayer
            // 
            this.leftPlayer.BackColor = System.Drawing.Color.Transparent;
            this.leftPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftPlayer.BackgroundImage")));
            this.leftPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftPlayer.Location = new System.Drawing.Point(-2, 180);
            this.leftPlayer.Name = "leftPlayer";
            this.leftPlayer.Size = new System.Drawing.Size(32, 140);
            this.leftPlayer.TabIndex = 0;
            this.leftPlayer.TabStop = false;
            // 
            // rightPlayer
            // 
            this.rightPlayer.BackColor = System.Drawing.Color.Transparent;
            this.rightPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightPlayer.BackgroundImage")));
            this.rightPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightPlayer.Location = new System.Drawing.Point(994, 180);
            this.rightPlayer.Name = "rightPlayer";
            this.rightPlayer.Size = new System.Drawing.Size(32, 140);
            this.rightPlayer.TabIndex = 1;
            this.rightPlayer.TabStop = false;
            // 
            // theBall
            // 
            this.theBall.BackColor = System.Drawing.Color.Transparent;
            this.theBall.Image = ((System.Drawing.Image)(resources.GetObject("theBall.Image")));
            this.theBall.Location = new System.Drawing.Point(492, 234);
            this.theBall.Name = "theBall";
            this.theBall.Size = new System.Drawing.Size(41, 41);
            this.theBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.theBall.TabIndex = 2;
            this.theBall.TabStop = false;
            // 
            // scoreLeft
            // 
            this.scoreLeft.AutoSize = true;
            this.scoreLeft.BackColor = System.Drawing.Color.Transparent;
            this.scoreLeft.Font = new System.Drawing.Font("Castellar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLeft.ForeColor = System.Drawing.Color.Aqua;
            this.scoreLeft.Location = new System.Drawing.Point(370, 55);
            this.scoreLeft.Name = "scoreLeft";
            this.scoreLeft.Size = new System.Drawing.Size(36, 34);
            this.scoreLeft.TabIndex = 3;
            this.scoreLeft.Text = "0";
            this.scoreLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreRight
            // 
            this.scoreRight.AutoSize = true;
            this.scoreRight.BackColor = System.Drawing.Color.Transparent;
            this.scoreRight.Font = new System.Drawing.Font("Castellar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreRight.ForeColor = System.Drawing.Color.Aqua;
            this.scoreRight.Location = new System.Drawing.Point(630, 55);
            this.scoreRight.Name = "scoreRight";
            this.scoreRight.Size = new System.Drawing.Size(36, 34);
            this.scoreRight.TabIndex = 4;
            this.scoreRight.Text = "0";
            this.scoreRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tongLogo
            // 
            this.tongLogo.BackColor = System.Drawing.Color.Transparent;
            this.tongLogo.Location = new System.Drawing.Point(426, 15);
            this.tongLogo.Name = "tongLogo";
            this.tongLogo.Size = new System.Drawing.Size(182, 103);
            this.tongLogo.TabIndex = 5;
            this.tongLogo.TabStop = false;
            // 
            // theTimer
            // 
            this.theTimer.Enabled = true;
            this.theTimer.Interval = 40;
            this.theTimer.Tick += new System.EventHandler(this.theTimer_Tick);
            // 
            // pauseInfo
            // 
            this.pauseInfo.AutoSize = true;
            this.pauseInfo.BackColor = System.Drawing.Color.Transparent;
            this.pauseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseInfo.ForeColor = System.Drawing.Color.Teal;
            this.pauseInfo.Location = new System.Drawing.Point(817, 15);
            this.pauseInfo.Name = "pauseInfo";
            this.pauseInfo.Size = new System.Drawing.Size(209, 25);
            this.pauseInfo.TabIndex = 6;
            this.pauseInfo.Text = "Click SPACE to pause";
            this.pauseInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pauseMenuCtn
            // 
            this.pauseMenuCtn.AutoSize = true;
            this.pauseMenuCtn.BackColor = System.Drawing.Color.Transparent;
            this.pauseMenuCtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pauseMenuCtn.Controls.Add(this.restartBtn);
            this.pauseMenuCtn.Controls.Add(this.optionsBtn);
            this.pauseMenuCtn.Controls.Add(this.leaveBtn);
            this.pauseMenuCtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.pauseMenuCtn.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pauseMenuCtn.Location = new System.Drawing.Point(458, 180);
            this.pauseMenuCtn.Name = "pauseMenuCtn";
            this.pauseMenuCtn.Size = new System.Drawing.Size(112, 143);
            this.pauseMenuCtn.TabIndex = 10;
            this.pauseMenuCtn.TabStop = true;
            this.pauseMenuCtn.Visible = false;
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(3, 3);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(102, 37);
            this.restartBtn.TabIndex = 0;
            this.restartBtn.TabStop = false;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // optionsBtn
            // 
            this.optionsBtn.Location = new System.Drawing.Point(3, 46);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(101, 42);
            this.optionsBtn.TabIndex = 1;
            this.optionsBtn.TabStop = false;
            this.optionsBtn.Text = "Options";
            this.optionsBtn.UseVisualStyleBackColor = true;
            // 
            // leaveBtn
            // 
            this.leaveBtn.Location = new System.Drawing.Point(3, 94);
            this.leaveBtn.Name = "leaveBtn";
            this.leaveBtn.Size = new System.Drawing.Size(101, 42);
            this.leaveBtn.TabIndex = 2;
            this.leaveBtn.TabStop = false;
            this.leaveBtn.Text = "Quitter";
            this.leaveBtn.UseVisualStyleBackColor = true;
            this.leaveBtn.Click += new System.EventHandler(this.leaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(1, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "Z\r\nS\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(36, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 60);
            this.label2.TabIndex = 12;
            this.label2.Text = "  /\\\r\n   |\r\n\r\n   |\r\n  \\/\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(799, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 44);
            this.label3.TabIndex = 13;
            this.label3.Text = "Auto = M\r\nManual  = Up/Down arrows\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // endGamePanel
            // 
            this.endGamePanel.AutoSize = true;
            this.endGamePanel.BackColor = System.Drawing.Color.Transparent;
            this.endGamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.endGamePanel.Controls.Add(this.endGameText);
            this.endGamePanel.Controls.Add(this.restartBtn2);
            this.endGamePanel.Controls.Add(this.leaveBtn2);
            this.endGamePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.endGamePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.endGamePanel.Location = new System.Drawing.Point(458, 155);
            this.endGamePanel.Name = "endGamePanel";
            this.endGamePanel.Size = new System.Drawing.Size(112, 135);
            this.endGamePanel.TabIndex = 14;
            this.endGamePanel.TabStop = true;
            this.endGamePanel.Visible = false;
            // 
            // endGameText
            // 
            this.endGameText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.endGameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.endGameText.Location = new System.Drawing.Point(3, 0);
            this.endGameText.Name = "endGameText";
            this.endGameText.Size = new System.Drawing.Size(102, 40);
            this.endGameText.TabIndex = 3;
            this.endGameText.Text = "Left player\r\n win !!!";
            this.endGameText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // restartBtn2
            // 
            this.restartBtn2.Location = new System.Drawing.Point(3, 43);
            this.restartBtn2.Name = "restartBtn2";
            this.restartBtn2.Size = new System.Drawing.Size(102, 37);
            this.restartBtn2.TabIndex = 0;
            this.restartBtn2.TabStop = false;
            this.restartBtn2.Text = "Restart";
            this.restartBtn2.UseVisualStyleBackColor = true;
            this.restartBtn2.Click += new System.EventHandler(this.restartBtn2_Click);
            // 
            // leaveBtn2
            // 
            this.leaveBtn2.Location = new System.Drawing.Point(3, 86);
            this.leaveBtn2.Name = "leaveBtn2";
            this.leaveBtn2.Size = new System.Drawing.Size(101, 42);
            this.leaveBtn2.TabIndex = 2;
            this.leaveBtn2.TabStop = false;
            this.leaveBtn2.Text = "Quitter";
            this.leaveBtn2.UseVisualStyleBackColor = true;
            this.leaveBtn2.Click += new System.EventHandler(this.leaveBtn2_Click);
            // 
            // Tong
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 532);
            this.Controls.Add(this.endGamePanel);
            this.Controls.Add(this.pauseMenuCtn);
            this.Controls.Add(this.theBall);
            this.Controls.Add(this.rightPlayer);
            this.Controls.Add(this.leftPlayer);
            this.Controls.Add(this.tongLogo);
            this.Controls.Add(this.pauseInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scoreLeft);
            this.Controls.Add(this.scoreRight);
            this.MaximumSize = new System.Drawing.Size(1045, 579);
            this.MinimumSize = new System.Drawing.Size(1045, 579);
            this.Name = "Tong";
            this.Text = "Tong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.leftPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongLogo)).EndInit();
            this.pauseMenuCtn.ResumeLayout(false);
            this.endGamePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox leftPlayer;
        private System.Windows.Forms.PictureBox rightPlayer;
        private System.Windows.Forms.Label scoreLeft;
        private System.Windows.Forms.Label scoreRight;
        private System.Windows.Forms.PictureBox tongLogo;
        private System.Windows.Forms.Timer theTimer;
        private System.Windows.Forms.PictureBox theBall;
        private System.Windows.Forms.Label pauseInfo;
        private System.Windows.Forms.FlowLayoutPanel pauseMenuCtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button leaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel endGamePanel;
        private System.Windows.Forms.Button restartBtn2;
        private System.Windows.Forms.Button leaveBtn2;
        private System.Windows.Forms.Label endGameText;
    }
}

