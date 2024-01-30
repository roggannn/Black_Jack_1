namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ReglerKnapp = new System.Windows.Forms.Button();
            this.ReglerText = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Sparfiler = new System.Windows.Forms.Button();
            this.sparListaBakgrund = new System.Windows.Forms.PictureBox();
            this.Save1 = new System.Windows.Forms.Button();
            this.Save2 = new System.Windows.Forms.Button();
            this.Save3 = new System.Windows.Forms.Button();
            this.Save4 = new System.Windows.Forms.Button();
            this.Saldo = new System.Windows.Forms.Label();
            this.SparaKnapp = new System.Windows.Forms.Button();
            this.LaddaKnapp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sparListaBakgrund)).BeginInit();
            this.SuspendLayout();
            // 
            // ReglerKnapp
            // 
            this.ReglerKnapp.BackColor = System.Drawing.Color.Transparent;
            this.ReglerKnapp.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReglerKnapp.Location = new System.Drawing.Point(687, 190);
            this.ReglerKnapp.Name = "ReglerKnapp";
            this.ReglerKnapp.Size = new System.Drawing.Size(285, 111);
            this.ReglerKnapp.TabIndex = 0;
            this.ReglerKnapp.Text = "Regler";
            this.ReglerKnapp.UseVisualStyleBackColor = false;
            this.ReglerKnapp.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReglerText
            // 
            this.ReglerText.AutoSize = true;
            this.ReglerText.Location = new System.Drawing.Point(1032, 209);
            this.ReglerText.Name = "ReglerText";
            this.ReglerText.Size = new System.Drawing.Size(347, 78);
            this.ReglerText.TabIndex = 1;
            this.ReglerText.Text = resources.GetString("ReglerText.Text");
            this.ReglerText.Visible = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(687, 43);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(285, 111);
            this.Start.TabIndex = 2;
            this.Start.Text = "Starta";
            this.Start.UseVisualStyleBackColor = false;
            // 
            // Sparfiler
            // 
            this.Sparfiler.BackColor = System.Drawing.Color.Transparent;
            this.Sparfiler.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sparfiler.Location = new System.Drawing.Point(38, 43);
            this.Sparfiler.Name = "Sparfiler";
            this.Sparfiler.Size = new System.Drawing.Size(285, 111);
            this.Sparfiler.TabIndex = 3;
            this.Sparfiler.Text = "Sparfiler";
            this.Sparfiler.UseVisualStyleBackColor = false;
            this.Sparfiler.Click += new System.EventHandler(this.Sparfiler_Click);
            // 
            // sparListaBakgrund
            // 
            this.sparListaBakgrund.BackColor = System.Drawing.Color.Transparent;
            this.sparListaBakgrund.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.gray;
            this.sparListaBakgrund.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sparListaBakgrund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sparListaBakgrund.Image = global::WindowsFormsApp1.Properties.Resources.gray;
            this.sparListaBakgrund.Location = new System.Drawing.Point(38, 190);
            this.sparListaBakgrund.Name = "sparListaBakgrund";
            this.sparListaBakgrund.Size = new System.Drawing.Size(285, 314);
            this.sparListaBakgrund.TabIndex = 4;
            this.sparListaBakgrund.TabStop = false;
            this.sparListaBakgrund.Visible = false;
            // 
            // Save1
            // 
            this.Save1.Location = new System.Drawing.Point(52, 207);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(259, 67);
            this.Save1.TabIndex = 5;
            this.Save1.Text = "Save 1";
            this.Save1.UseVisualStyleBackColor = true;
            this.Save1.Visible = false;
            this.Save1.Click += new System.EventHandler(this.Save1_Click);
            // 
            // Save2
            // 
            this.Save2.Location = new System.Drawing.Point(52, 280);
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(259, 67);
            this.Save2.TabIndex = 6;
            this.Save2.Text = "Save 2";
            this.Save2.UseVisualStyleBackColor = true;
            this.Save2.Visible = false;
            this.Save2.Click += new System.EventHandler(this.Save2_Click);
            // 
            // Save3
            // 
            this.Save3.Location = new System.Drawing.Point(52, 353);
            this.Save3.Name = "Save3";
            this.Save3.Size = new System.Drawing.Size(259, 67);
            this.Save3.TabIndex = 7;
            this.Save3.Text = "Save 3";
            this.Save3.UseVisualStyleBackColor = true;
            this.Save3.Visible = false;
            this.Save3.Click += new System.EventHandler(this.Save3_Click);
            // 
            // Save4
            // 
            this.Save4.Location = new System.Drawing.Point(52, 426);
            this.Save4.Name = "Save4";
            this.Save4.Size = new System.Drawing.Size(259, 67);
            this.Save4.TabIndex = 8;
            this.Save4.Text = "Save 4";
            this.Save4.UseVisualStyleBackColor = true;
            this.Save4.Visible = false;
            this.Save4.Click += new System.EventHandler(this.Save4_Click);
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.BackColor = System.Drawing.Color.Transparent;
            this.Saldo.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saldo.Location = new System.Drawing.Point(1544, 0);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(96, 37);
            this.Saldo.TabIndex = 9;
            this.Saldo.Text = "Saldo : ";
            // 
            // SparaKnapp
            // 
            this.SparaKnapp.Location = new System.Drawing.Point(341, 426);
            this.SparaKnapp.Name = "SparaKnapp";
            this.SparaKnapp.Size = new System.Drawing.Size(92, 26);
            this.SparaKnapp.TabIndex = 10;
            this.SparaKnapp.Text = "Spara";
            this.SparaKnapp.UseVisualStyleBackColor = true;
            this.SparaKnapp.Visible = false;
            this.SparaKnapp.Click += new System.EventHandler(this.SparaKnapp_Click);
            // 
            // LaddaKnapp
            // 
            this.LaddaKnapp.Location = new System.Drawing.Point(341, 467);
            this.LaddaKnapp.Name = "LaddaKnapp";
            this.LaddaKnapp.Size = new System.Drawing.Size(92, 26);
            this.LaddaKnapp.TabIndex = 11;
            this.LaddaKnapp.Text = "Ladda";
            this.LaddaKnapp.UseVisualStyleBackColor = true;
            this.LaddaKnapp.Visible = false;
            this.LaddaKnapp.Click += new System.EventHandler(this.LaddaKnapp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.blackjackk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1732, 737);
            this.Controls.Add(this.LaddaKnapp);
            this.Controls.Add(this.SparaKnapp);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.Save4);
            this.Controls.Add(this.Save3);
            this.Controls.Add(this.Save2);
            this.Controls.Add(this.Save1);
            this.Controls.Add(this.sparListaBakgrund);
            this.Controls.Add(this.Sparfiler);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ReglerText);
            this.Controls.Add(this.ReglerKnapp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.sparListaBakgrund)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReglerKnapp;
        private System.Windows.Forms.Label ReglerText;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Sparfiler;
        private System.Windows.Forms.PictureBox sparListaBakgrund;
        private System.Windows.Forms.Button Save1;
        private System.Windows.Forms.Button Save2;
        private System.Windows.Forms.Button Save3;
        private System.Windows.Forms.Button Save4;
        private System.Windows.Forms.Label Saldo;
        private System.Windows.Forms.Button SparaKnapp;
        private System.Windows.Forms.Button LaddaKnapp;
    }
}

