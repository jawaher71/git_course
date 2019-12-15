namespace gestion_vente.PL
{
    partial class FRM_Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncommande = new System.Windows.Forms.Button();
            this.btnproduit = new System.Windows.Forms.Button();
            this.btncat = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelbut = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panalparameter = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnparam = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panalparameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panelbut);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btncommande);
            this.panel1.Controls.Add(this.btnproduit);
            this.panel1.Controls.Add(this.btncat);
            this.panel1.Controls.Add(this.btnuser);
            this.panel1.Controls.Add(this.btnclient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 363);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btncommande
            // 
            this.btncommande.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncommande.Location = new System.Drawing.Point(0, 224);
            this.btncommande.Name = "btncommande";
            this.btncommande.Size = new System.Drawing.Size(194, 45);
            this.btncommande.TabIndex = 8;
            this.btncommande.Text = "COMMANDE";
            this.btncommande.UseVisualStyleBackColor = false;
            // 
            // btnproduit
            // 
            this.btnproduit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduit.Location = new System.Drawing.Point(0, 105);
            this.btnproduit.Name = "btnproduit";
            this.btnproduit.Size = new System.Drawing.Size(194, 45);
            this.btnproduit.TabIndex = 7;
            this.btnproduit.Text = "PRODUIT";
            this.btnproduit.UseVisualStyleBackColor = false;
            this.btnproduit.Click += new System.EventHandler(this.button5_Click);
            // 
            // btncat
            // 
            this.btncat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncat.Location = new System.Drawing.Point(0, 163);
            this.btncat.Name = "btncat";
            this.btncat.Size = new System.Drawing.Size(194, 45);
            this.btncat.TabIndex = 6;
            this.btncat.Text = "CATEGORIE";
            this.btncat.UseVisualStyleBackColor = false;
            this.btncat.Click += new System.EventHandler(this.btncat_Click);
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.Location = new System.Drawing.Point(3, 290);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(194, 45);
            this.btnuser.TabIndex = 5;
            this.btnuser.Text = "UTILISATEUR";
            this.btnuser.UseVisualStyleBackColor = false;
            this.btnuser.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnclient
            // 
            this.btnclient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.Location = new System.Drawing.Point(3, 43);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(194, 45);
            this.btnclient.TabIndex = 4;
            this.btnclient.Text = "CLIENT";
            this.btnclient.UseVisualStyleBackColor = false;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 18);
            this.panel2.TabIndex = 1;
            // 
            // panelbut
            // 
            this.panelbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelbut.Location = new System.Drawing.Point(3, 42);
            this.panelbut.Name = "panelbut";
            this.panelbut.Size = new System.Drawing.Size(10, 46);
            this.panelbut.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panalparameter);
            this.panel3.Controls.Add(this.btnparam);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 345);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panalparameter
            // 
            this.panalparameter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panalparameter.Controls.Add(this.button8);
            this.panalparameter.Controls.Add(this.button6);
            this.panalparameter.Controls.Add(this.button5);
            this.panalparameter.Controls.Add(this.button4);
            this.panalparameter.Location = new System.Drawing.Point(40, 3);
            this.panalparameter.Name = "panalparameter";
            this.panalparameter.Size = new System.Drawing.Size(242, 130);
            this.panalparameter.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(2, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(240, 28);
            this.button8.TabIndex = 9;
            this.button8.Text = "deconnecter";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(4, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(240, 28);
            this.button6.TabIndex = 8;
            this.button6.Text = "restaurer application";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(1, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 28);
            this.button5.TabIndex = 7;
            this.button5.Text = "creer une copie application";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(0, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 28);
            this.button4.TabIndex = 6;
            this.button4.Text = "connecter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(156, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 26);
            this.button7.TabIndex = 8;
            this.button7.Text = "- - -";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // btnparam
            // 
            this.btnparam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnparam.Location = new System.Drawing.Point(114, 24);
            this.btnparam.Name = "btnparam";
            this.btnparam.Size = new System.Drawing.Size(35, 26);
            this.btnparam.TabIndex = 9;
            this.btnparam.Text = "***";
            this.btnparam.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(447, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(488, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 363);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Menu";
            this.Text = "FRM_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panalparameter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button btnproduit;
        private System.Windows.Forms.Button btncat;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btncommande;
        private System.Windows.Forms.Panel panelbut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panalparameter;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnparam;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}