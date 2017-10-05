namespace NoSleepTilBrooklyn
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAction = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.chkPlayMusic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAction.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAction.Location = new System.Drawing.Point(45, 46);
            this.btnAction.Margin = new System.Windows.Forms.Padding(0);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(104, 36);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "btnAction";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMessage.Location = new System.Drawing.Point(22, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(76, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "No Sleep Till...";
            // 
            // chkPlayMusic
            // 
            this.chkPlayMusic.AutoSize = true;
            this.chkPlayMusic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkPlayMusic.Location = new System.Drawing.Point(167, 55);
            this.chkPlayMusic.Name = "chkPlayMusic";
            this.chkPlayMusic.Size = new System.Drawing.Size(77, 17);
            this.chkPlayMusic.TabIndex = 2;
            this.chkPlayMusic.Text = "Play Music";
            this.chkPlayMusic.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 94);
            this.Controls.Add(this.chkPlayMusic);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "No Sleep Till Brooklyn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.CheckBox chkPlayMusic;
    }
}

