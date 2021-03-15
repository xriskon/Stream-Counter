
namespace Stream_Counter
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.saveBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.TextBox();
            this.folderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.locationPriv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(154, 78);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(124, 40);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save && Close";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(12, 78);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(124, 40);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // pathText
            // 
            this.pathText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathText.Location = new System.Drawing.Point(12, 40);
            this.pathText.MaximumSize = new System.Drawing.Size(234, 26);
            this.pathText.MinimumSize = new System.Drawing.Size(234, 26);
            this.pathText.Name = "pathText";
            this.pathText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pathText.Size = new System.Drawing.Size(234, 23);
            this.pathText.TabIndex = 3;
            // 
            // folderBtn
            // 
            this.folderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderBtn.Location = new System.Drawing.Point(252, 40);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(26, 26);
            this.folderBtn.TabIndex = 4;
            this.folderBtn.Text = "...";
            this.folderBtn.UseVisualStyleBackColor = true;
            this.folderBtn.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Save Location";
            // 
            // locationPriv
            // 
            this.locationPriv.AutoSize = true;
            this.locationPriv.Enabled = false;
            this.locationPriv.Location = new System.Drawing.Point(230, 22);
            this.locationPriv.Name = "locationPriv";
            this.locationPriv.Size = new System.Drawing.Size(48, 13);
            this.locationPriv.TabIndex = 6;
            this.locationPriv.Text = "Location";
            this.locationPriv.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 130);
            this.ControlBox = false;
            this.Controls.Add(this.locationPriv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderBtn);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.saveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(306, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(306, 39);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button folderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label locationPriv;
    }
}