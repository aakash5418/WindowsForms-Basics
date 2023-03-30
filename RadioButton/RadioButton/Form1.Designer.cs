namespace RadioButton
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpMoods = new System.Windows.Forms.GroupBox();
            this.picSad = new System.Windows.Forms.PictureBox();
            this.pichappy = new System.Windows.Forms.PictureBox();
            this.rdoSad = new System.Windows.Forms.RadioButton();
            this.rdoHappy = new System.Windows.Forms.RadioButton();
            this.grpMoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichappy)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMoods
            // 
            this.grpMoods.Controls.Add(this.picSad);
            this.grpMoods.Controls.Add(this.pichappy);
            this.grpMoods.Controls.Add(this.rdoSad);
            this.grpMoods.Controls.Add(this.rdoHappy);
            this.grpMoods.Location = new System.Drawing.Point(23, 28);
            this.grpMoods.Name = "grpMoods";
            this.grpMoods.Size = new System.Drawing.Size(392, 278);
            this.grpMoods.TabIndex = 0;
            this.grpMoods.TabStop = false;
            this.grpMoods.Text = "Moods";
            // 
            // picSad
            // 
            this.picSad.Image = ((System.Drawing.Image)(resources.GetObject("picSad.Image")));
            this.picSad.Location = new System.Drawing.Point(203, 150);
            this.picSad.Name = "picSad";
            this.picSad.Size = new System.Drawing.Size(150, 122);
            this.picSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSad.TabIndex = 2;
            this.picSad.TabStop = false;
            this.picSad.Visible = false;
            // 
            // pichappy
            // 
            this.pichappy.Image = ((System.Drawing.Image)(resources.GetObject("pichappy.Image")));
            this.pichappy.Location = new System.Drawing.Point(203, 18);
            this.pichappy.Name = "pichappy";
            this.pichappy.Size = new System.Drawing.Size(150, 122);
            this.pichappy.TabIndex = 1;
            this.pichappy.TabStop = false;
            this.pichappy.Visible = false;
            // 
            // rdoSad
            // 
            this.rdoSad.AutoSize = true;
            this.rdoSad.Location = new System.Drawing.Point(18, 167);
            this.rdoSad.Name = "rdoSad";
            this.rdoSad.Size = new System.Drawing.Size(65, 29);
            this.rdoSad.TabIndex = 1;
            this.rdoSad.TabStop = true;
            this.rdoSad.Text = "sad";
            this.rdoSad.UseVisualStyleBackColor = true;
            this.rdoSad.CheckedChanged += new System.EventHandler(this.rdoSad_CheckedChanged);
            // 
            // rdoHappy
            // 
            this.rdoHappy.AutoSize = true;
            this.rdoHappy.Location = new System.Drawing.Point(18, 60);
            this.rdoHappy.Name = "rdoHappy";
            this.rdoHappy.Size = new System.Drawing.Size(87, 29);
            this.rdoHappy.TabIndex = 0;
            this.rdoHappy.TabStop = true;
            this.rdoHappy.Text = "happy";
            this.rdoHappy.UseVisualStyleBackColor = true;
            this.rdoHappy.CheckedChanged += new System.EventHandler(this.rdoHappy_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpMoods);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMoods.ResumeLayout(false);
            this.grpMoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichappy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpMoods;
        private PictureBox picSad;
        private PictureBox pichappy;
        private System.Windows.Forms.RadioButton rdoSad;
        private System.Windows.Forms.RadioButton rdoHappy;
    }
}