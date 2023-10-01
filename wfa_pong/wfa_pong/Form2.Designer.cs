namespace wfa_pong
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.closeOptionPanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeOptionPanel
            // 
            this.closeOptionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeOptionPanel.Location = new System.Drawing.Point(131, 507);
            this.closeOptionPanel.Name = "closeOptionPanel";
            this.closeOptionPanel.Size = new System.Drawing.Size(222, 71);
            this.closeOptionPanel.TabIndex = 0;
            this.closeOptionPanel.Text = "Retour au jeu";
            this.closeOptionPanel.UseVisualStyleBackColor = true;
            this.closeOptionPanel.Click += new System.EventHandler(this.closeOptionPanel_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 703);
            this.Controls.Add(this.closeOptionPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Location = new System.Drawing.Point(1045, 0);
            this.MaximumSize = new System.Drawing.Size(500, 750);
            this.MinimumSize = new System.Drawing.Size(500, 750);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeOptionPanel;
    }
}