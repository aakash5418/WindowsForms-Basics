﻿namespace ComboBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txthour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cborate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtgrosspay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Vsbhours = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arjun",
            "Anbu",
            "Arivu",
            "balu",
            "balaji",
            "chandru",
            "deva"});
            this.comboBox1.Location = new System.Drawing.Point(241, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hours";
            // 
            // Txthour
            // 
            this.Txthour.Location = new System.Drawing.Point(276, 136);
            this.Txthour.Name = "Txthour";
            this.Txthour.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txthour.Size = new System.Drawing.Size(100, 26);
            this.Txthour.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rate";
            // 
            // Cborate
            // 
            this.Cborate.FormattingEnabled = true;
            this.Cborate.Items.AddRange(new object[] {
            "5.5",
            "6.5",
            "7.5",
            "8.5",
            "9.5"});
            this.Cborate.Location = new System.Drawing.Point(276, 245);
            this.Cborate.Name = "Cborate";
            this.Cborate.Size = new System.Drawing.Size(121, 28);
            this.Cborate.TabIndex = 5;
            this.Cborate.SelectedIndexChanged += new System.EventHandler(this.Cborate_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "GrossPay";
            // 
            // Txtgrosspay
            // 
            this.Txtgrosspay.Location = new System.Drawing.Point(276, 326);
            this.Txtgrosspay.Name = "Txtgrosspay";
            this.Txtgrosspay.Size = new System.Drawing.Size(100, 26);
            this.Txtgrosspay.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Compute";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Vsbhours
            // 
            this.Vsbhours.Location = new System.Drawing.Point(425, 114);
            this.Vsbhours.Name = "Vsbhours";
            this.Vsbhours.Size = new System.Drawing.Size(26, 120);
            this.Vsbhours.TabIndex = 11;
            this.Vsbhours.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Vsbhours);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txtgrosspay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cborate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txthour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Combo box demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txthour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cborate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtgrosspay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.VScrollBar Vsbhours;
    }
}

