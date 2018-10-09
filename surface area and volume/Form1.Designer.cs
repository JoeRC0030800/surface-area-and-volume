namespace surface_area_and_volume
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
            this.TxtBxRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSurf = new System.Windows.Forms.Label();
            this.LblVol = new System.Windows.Forms.Label();
            this.ButtonCl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Cone = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBxRadius
            // 
            this.TxtBxRadius.Location = new System.Drawing.Point(221, 65);
            this.TxtBxRadius.Name = "TxtBxRadius";
            this.TxtBxRadius.Size = new System.Drawing.Size(102, 20);
            this.TxtBxRadius.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sphere";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Radius";
            // 
            // LblSurf
            // 
            this.LblSurf.AutoSize = true;
            this.LblSurf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSurf.Location = new System.Drawing.Point(343, 64);
            this.LblSurf.Name = "LblSurf";
            this.LblSurf.Size = new System.Drawing.Size(106, 18);
            this.LblSurf.TabIndex = 3;
            this.LblSurf.Text = "Surface Area =";
            // 
            // LblVol
            // 
            this.LblVol.AutoSize = true;
            this.LblVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVol.Location = new System.Drawing.Point(343, 85);
            this.LblVol.Name = "LblVol";
            this.LblVol.Size = new System.Drawing.Size(75, 18);
            this.LblVol.TabIndex = 4;
            this.LblVol.Text = "Volume = ";
            this.LblVol.Click += new System.EventHandler(this.label4_Click);
            // 
            // ButtonCl
            // 
            this.ButtonCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCl.Location = new System.Drawing.Point(568, 303);
            this.ButtonCl.Name = "ButtonCl";
            this.ButtonCl.Size = new System.Drawing.Size(186, 57);
            this.ButtonCl.TabIndex = 5;
            this.ButtonCl.Text = "CALCULATE";
            this.ButtonCl.UseVisualStyleBackColor = true;
            this.ButtonCl.Click += new System.EventHandler(this.ButtonCl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::surface_area_and_volume.Properties.Resources.sphere;
            this.pictureBox1.Location = new System.Drawing.Point(37, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Cone);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 453);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ButtonCl);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TxtBxRadius);
            this.tabPage1.Controls.Add(this.LblVol);
            this.tabPage1.Controls.Add(this.LblSurf);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sphere";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Cone
            // 
            this.Cone.Location = new System.Drawing.Point(4, 22);
            this.Cone.Name = "Cone";
            this.Cone.Padding = new System.Windows.Forms.Padding(3);
            this.Cone.Size = new System.Drawing.Size(801, 427);
            this.Cone.TabIndex = 1;
            this.Cone.Text = "Cone";
            this.Cone.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBxRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSurf;
        private System.Windows.Forms.Label LblVol;
        private System.Windows.Forms.Button ButtonCl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Cone;
    }
}

