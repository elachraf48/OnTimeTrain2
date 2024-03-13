
namespace Projet_login_1
{
    partial class Ajoute_Produits_a_commande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajoute_Produits_a_commande));
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Qt = new System.Windows.Forms.NumericUpDown();
            this.panel17 = new System.Windows.Forms.Panel();
            this.comboPRD = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Bureau = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboTYP = new System.Windows.Forms.ComboBox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Qt)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 25);
            this.label19.TabIndex = 59;
            this.label19.Text = "Produits";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.Bureau);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 263);
            this.panel2.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "0 DH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Sous-Total :";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.Qt);
            this.panel1.Location = new System.Drawing.Point(186, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 32);
            this.panel1.TabIndex = 51;
            // 
            // Qt
            // 
            this.Qt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qt.Location = new System.Drawing.Point(3, 3);
            this.Qt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qt.Name = "Qt";
            this.Qt.Size = new System.Drawing.Size(249, 26);
            this.Qt.TabIndex = 63;
            this.Qt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qt.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel17
            // 
            this.panel17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel17.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel17.Controls.Add(this.comboPRD);
            this.panel17.Location = new System.Drawing.Point(184, 65);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(257, 32);
            this.panel17.TabIndex = 45;
            // 
            // comboPRD
            // 
            this.comboPRD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPRD.FormattingEnabled = true;
            this.comboPRD.Location = new System.Drawing.Point(2, 2);
            this.comboPRD.Name = "comboPRD";
            this.comboPRD.Size = new System.Drawing.Size(252, 28);
            this.comboPRD.TabIndex = 51;
            this.comboPRD.SelectedIndexChanged += new System.EventHandler(this.comboPRD_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 25);
            this.label18.TabIndex = 47;
            this.label18.Text = "Quantite";
            // 
            // Bureau
            // 
            this.Bureau.AutoSize = true;
            this.Bureau.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bureau.Location = new System.Drawing.Point(10, 8);
            this.Bureau.Name = "Bureau";
            this.Bureau.Size = new System.Drawing.Size(71, 25);
            this.Bureau.TabIndex = 46;
            this.Bureau.Text = "Type";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Controls.Add(this.comboTYP);
            this.panel3.Location = new System.Drawing.Point(184, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 32);
            this.panel3.TabIndex = 44;
            // 
            // comboTYP
            // 
            this.comboTYP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTYP.FormattingEnabled = true;
            this.comboTYP.Location = new System.Drawing.Point(2, 2);
            this.comboTYP.Name = "comboTYP";
            this.comboTYP.Size = new System.Drawing.Size(252, 28);
            this.comboTYP.TabIndex = 50;
            this.comboTYP.SelectedIndexChanged += new System.EventHandler(this.comboTYP_SelectedIndexChanged);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuThinButton22.AutoScroll = true;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Ajoute";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Red;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton22.Location = new System.Drawing.Point(26, 292);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(209, 46);
            this.bunifuThinButton22.TabIndex = 61;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuThinButton21.AutoScroll = true;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Ferme";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Red;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Red;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.Location = new System.Drawing.Point(266, 292);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(209, 46);
            this.bunifuThinButton21.TabIndex = 62;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Ajoute_Produits_a_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(508, 351);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajoute_Produits_a_commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajoute_Produits_a_commande";
            this.Load += new System.EventHandler(this.Ajoute_Produits_a_commande_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Qt)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.ComboBox comboPRD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Bureau;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboTYP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Qt;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}