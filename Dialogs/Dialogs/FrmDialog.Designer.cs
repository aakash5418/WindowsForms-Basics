namespace Dialogs
{
    partial class FrmDialog
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
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.btnCustomdesign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(243, 77);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(228, 47);
            this.btnMessageBox.TabIndex = 0;
            this.btnMessageBox.Text = "MessageBox Demo";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // btnCustomdesign
            // 
            this.btnCustomdesign.Location = new System.Drawing.Point(243, 236);
            this.btnCustomdesign.Name = "btnCustomdesign";
            this.btnCustomdesign.Size = new System.Drawing.Size(228, 47);
            this.btnCustomdesign.TabIndex = 1;
            this.btnCustomdesign.Text = "Custom Design";
            this.btnCustomdesign.UseVisualStyleBackColor = true;
            this.btnCustomdesign.Click += new System.EventHandler(this.btnCustomdesign_Click);
            // 
            // FrmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomdesign);
            this.Controls.Add(this.btnMessageBox);
            this.Name = "FrmDialog";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Button btnCustomdesign;
    }
}

