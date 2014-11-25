namespace Compact_Agenda
{
    partial class DLG_Events
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
            this.TBX_Title = new System.Windows.Forms.TextBox();
            this.LB_Titre = new System.Windows.Forms.Label();
            this.LB_Description = new System.Windows.Forms.Label();
            this.TBX_Description = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.LB_Date = new System.Windows.Forms.Label();
            this.LB_Debut = new System.Windows.Forms.Label();
            this.LB_Fin = new System.Windows.Forms.Label();
            this.GB_Categorie = new System.Windows.Forms.GroupBox();
            this.RB_Autre = new System.Windows.Forms.RadioButton();
            this.RB_Loisir = new System.Windows.Forms.RadioButton();
            this.RB_Important = new System.Windows.Forms.RadioButton();
            this.RB_Sante = new System.Windows.Forms.RadioButton();
            this.RB_Travail = new System.Windows.Forms.RadioButton();
            this.RB_General = new System.Windows.Forms.RadioButton();
            this.PB_General = new System.Windows.Forms.PictureBox();
            this.PB_Travail = new System.Windows.Forms.PictureBox();
            this.PB_Sante = new System.Windows.Forms.PictureBox();
            this.PB_Important = new System.Windows.Forms.PictureBox();
            this.PB_Loisir = new System.Windows.Forms.PictureBox();
            this.PB_Autre = new System.Windows.Forms.PictureBox();
            this.FBTN_Close = new FlashButton.FlashButton();
            this.FBTN_Accepter = new FlashButton.FlashButton();
            this.NUD_DebutHeure = new System.Windows.Forms.NumericUpDown();
            this.NUD_DebutMinute = new System.Windows.Forms.NumericUpDown();
            this.NUD_FinHeure = new System.Windows.Forms.NumericUpDown();
            this.NUD_FinMinute = new System.Windows.Forms.NumericUpDown();
            this.LB_2PointsDebut = new System.Windows.Forms.Label();
            this.LB_2PointsFin = new System.Windows.Forms.Label();
            this.GB_Categorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_General)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Travail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Sante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Important)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Loisir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Autre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DebutHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DebutMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FinHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FinMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_Title
            // 
            this.TBX_Title.Location = new System.Drawing.Point(70, 12);
            this.TBX_Title.Name = "TBX_Title";
            this.TBX_Title.Size = new System.Drawing.Size(125, 20);
            this.TBX_Title.TabIndex = 0;
            this.TBX_Title.TextChanged += new System.EventHandler(this.TBX_Title_TextChanged);
            // 
            // LB_Titre
            // 
            this.LB_Titre.AutoSize = true;
            this.LB_Titre.Location = new System.Drawing.Point(33, 14);
            this.LB_Titre.Name = "LB_Titre";
            this.LB_Titre.Size = new System.Drawing.Size(34, 13);
            this.LB_Titre.TabIndex = 1;
            this.LB_Titre.Text = "Titre :";
            // 
            // LB_Description
            // 
            this.LB_Description.AutoSize = true;
            this.LB_Description.Location = new System.Drawing.Point(0, 40);
            this.LB_Description.Name = "LB_Description";
            this.LB_Description.Size = new System.Drawing.Size(66, 13);
            this.LB_Description.TabIndex = 1;
            this.LB_Description.Text = "Description :";
            // 
            // TBX_Description
            // 
            this.TBX_Description.Location = new System.Drawing.Point(70, 38);
            this.TBX_Description.Multiline = true;
            this.TBX_Description.Name = "TBX_Description";
            this.TBX_Description.Size = new System.Drawing.Size(125, 167);
            this.TBX_Description.TabIndex = 1;
            this.TBX_Description.TextChanged += new System.EventHandler(this.TBX_Description_TextChanged);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(70, 214);
            this.DTP_Date.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.DTP_Date.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(125, 20);
            this.DTP_Date.TabIndex = 3;
            this.DTP_Date.ValueChanged += new System.EventHandler(this.DTP_Date_ValueChanged);
            // 
            // LB_Date
            // 
            this.LB_Date.AutoSize = true;
            this.LB_Date.Location = new System.Drawing.Point(30, 217);
            this.LB_Date.Name = "LB_Date";
            this.LB_Date.Size = new System.Drawing.Size(36, 13);
            this.LB_Date.TabIndex = 1;
            this.LB_Date.Text = "Date :";
            // 
            // LB_Debut
            // 
            this.LB_Debut.AutoSize = true;
            this.LB_Debut.Location = new System.Drawing.Point(24, 244);
            this.LB_Debut.Name = "LB_Debut";
            this.LB_Debut.Size = new System.Drawing.Size(42, 13);
            this.LB_Debut.TabIndex = 1;
            this.LB_Debut.Text = "Début :";
            // 
            // LB_Fin
            // 
            this.LB_Fin.AutoSize = true;
            this.LB_Fin.Location = new System.Drawing.Point(39, 270);
            this.LB_Fin.Name = "LB_Fin";
            this.LB_Fin.Size = new System.Drawing.Size(27, 13);
            this.LB_Fin.TabIndex = 1;
            this.LB_Fin.Text = "Fin :";
            // 
            // GB_Categorie
            // 
            this.GB_Categorie.Controls.Add(this.RB_Autre);
            this.GB_Categorie.Controls.Add(this.RB_Loisir);
            this.GB_Categorie.Controls.Add(this.RB_Important);
            this.GB_Categorie.Controls.Add(this.RB_Sante);
            this.GB_Categorie.Controls.Add(this.RB_Travail);
            this.GB_Categorie.Controls.Add(this.RB_General);
            this.GB_Categorie.Location = new System.Drawing.Point(213, 12);
            this.GB_Categorie.Margin = new System.Windows.Forms.Padding(2);
            this.GB_Categorie.Name = "GB_Categorie";
            this.GB_Categorie.Padding = new System.Windows.Forms.Padding(2);
            this.GB_Categorie.Size = new System.Drawing.Size(105, 192);
            this.GB_Categorie.TabIndex = 47;
            this.GB_Categorie.TabStop = false;
            this.GB_Categorie.Text = "Catégorie";
            // 
            // RB_Autre
            // 
            this.RB_Autre.AutoSize = true;
            this.RB_Autre.Location = new System.Drawing.Point(7, 165);
            this.RB_Autre.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Autre.Name = "RB_Autre";
            this.RB_Autre.Size = new System.Drawing.Size(50, 17);
            this.RB_Autre.TabIndex = 0;
            this.RB_Autre.TabStop = true;
            this.RB_Autre.Text = "Autre";
            this.RB_Autre.UseVisualStyleBackColor = true;
            this.RB_Autre.CheckedChanged += new System.EventHandler(this.RB_Autre_CheckedChanged);
            // 
            // RB_Loisir
            // 
            this.RB_Loisir.AutoSize = true;
            this.RB_Loisir.Location = new System.Drawing.Point(7, 137);
            this.RB_Loisir.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Loisir.Name = "RB_Loisir";
            this.RB_Loisir.Size = new System.Drawing.Size(49, 17);
            this.RB_Loisir.TabIndex = 0;
            this.RB_Loisir.TabStop = true;
            this.RB_Loisir.Text = "Loisir";
            this.RB_Loisir.UseVisualStyleBackColor = true;
            this.RB_Loisir.CheckedChanged += new System.EventHandler(this.RB_Loisir_CheckedChanged);
            // 
            // RB_Important
            // 
            this.RB_Important.AutoSize = true;
            this.RB_Important.Location = new System.Drawing.Point(7, 109);
            this.RB_Important.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Important.Name = "RB_Important";
            this.RB_Important.Size = new System.Drawing.Size(69, 17);
            this.RB_Important.TabIndex = 0;
            this.RB_Important.TabStop = true;
            this.RB_Important.Text = "Important";
            this.RB_Important.UseVisualStyleBackColor = true;
            this.RB_Important.CheckedChanged += new System.EventHandler(this.RB_Important_CheckedChanged);
            // 
            // RB_Sante
            // 
            this.RB_Sante.AutoSize = true;
            this.RB_Sante.Location = new System.Drawing.Point(7, 81);
            this.RB_Sante.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Sante.Name = "RB_Sante";
            this.RB_Sante.Size = new System.Drawing.Size(53, 17);
            this.RB_Sante.TabIndex = 0;
            this.RB_Sante.TabStop = true;
            this.RB_Sante.Text = "Santé";
            this.RB_Sante.UseVisualStyleBackColor = true;
            this.RB_Sante.CheckedChanged += new System.EventHandler(this.RB_Sante_CheckedChanged);
            // 
            // RB_Travail
            // 
            this.RB_Travail.AutoSize = true;
            this.RB_Travail.Location = new System.Drawing.Point(7, 53);
            this.RB_Travail.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Travail.Name = "RB_Travail";
            this.RB_Travail.Size = new System.Drawing.Size(57, 17);
            this.RB_Travail.TabIndex = 0;
            this.RB_Travail.TabStop = true;
            this.RB_Travail.Text = "Travail";
            this.RB_Travail.UseVisualStyleBackColor = true;
            this.RB_Travail.CheckedChanged += new System.EventHandler(this.RG_Travail_CheckedChanged);
            // 
            // RB_General
            // 
            this.RB_General.AutoSize = true;
            this.RB_General.Location = new System.Drawing.Point(7, 25);
            this.RB_General.Margin = new System.Windows.Forms.Padding(2);
            this.RB_General.Name = "RB_General";
            this.RB_General.Size = new System.Drawing.Size(62, 17);
            this.RB_General.TabIndex = 0;
            this.RB_General.TabStop = true;
            this.RB_General.Text = "Général";
            this.RB_General.UseVisualStyleBackColor = true;
            this.RB_General.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PB_General
            // 
            this.PB_General.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_General.Location = new System.Drawing.Point(331, 37);
            this.PB_General.Margin = new System.Windows.Forms.Padding(2);
            this.PB_General.Name = "PB_General";
            this.PB_General.Size = new System.Drawing.Size(40, 19);
            this.PB_General.TabIndex = 48;
            this.PB_General.TabStop = false;
            this.PB_General.Click += new System.EventHandler(this.PB_General_Click);
            // 
            // PB_Travail
            // 
            this.PB_Travail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Travail.Location = new System.Drawing.Point(331, 65);
            this.PB_Travail.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Travail.Name = "PB_Travail";
            this.PB_Travail.Size = new System.Drawing.Size(40, 19);
            this.PB_Travail.TabIndex = 48;
            this.PB_Travail.TabStop = false;
            this.PB_Travail.Click += new System.EventHandler(this.PB_Travail_Click);
            // 
            // PB_Sante
            // 
            this.PB_Sante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Sante.Location = new System.Drawing.Point(331, 93);
            this.PB_Sante.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Sante.Name = "PB_Sante";
            this.PB_Sante.Size = new System.Drawing.Size(40, 19);
            this.PB_Sante.TabIndex = 48;
            this.PB_Sante.TabStop = false;
            this.PB_Sante.Click += new System.EventHandler(this.PB_Sante_Click);
            // 
            // PB_Important
            // 
            this.PB_Important.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Important.Location = new System.Drawing.Point(331, 121);
            this.PB_Important.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Important.Name = "PB_Important";
            this.PB_Important.Size = new System.Drawing.Size(40, 19);
            this.PB_Important.TabIndex = 48;
            this.PB_Important.TabStop = false;
            this.PB_Important.Click += new System.EventHandler(this.PB_Important_Click);
            // 
            // PB_Loisir
            // 
            this.PB_Loisir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Loisir.Location = new System.Drawing.Point(331, 149);
            this.PB_Loisir.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Loisir.Name = "PB_Loisir";
            this.PB_Loisir.Size = new System.Drawing.Size(40, 19);
            this.PB_Loisir.TabIndex = 48;
            this.PB_Loisir.TabStop = false;
            this.PB_Loisir.Click += new System.EventHandler(this.PB_Loisir_Click);
            // 
            // PB_Autre
            // 
            this.PB_Autre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Autre.Location = new System.Drawing.Point(331, 177);
            this.PB_Autre.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Autre.Name = "PB_Autre";
            this.PB_Autre.Size = new System.Drawing.Size(40, 19);
            this.PB_Autre.TabIndex = 48;
            this.PB_Autre.TabStop = false;
            this.PB_Autre.Click += new System.EventHandler(this.PB_Autre_Click);
            // 
            // FBTN_Close
            // 
            this.FBTN_Close.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Close.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Click;
            this.FBTN_Close.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Disable;
            this.FBTN_Close.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Close.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Over;
            this.FBTN_Close.Location = new System.Drawing.Point(309, 264);
            this.FBTN_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_Close.Name = "FBTN_Close";
            this.FBTN_Close.Size = new System.Drawing.Size(27, 26);
            this.FBTN_Close.TabIndex = 49;
            this.FBTN_Close.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // FBTN_Accepter
            // 
            this.FBTN_Accepter.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Neutral;
            this.FBTN_Accepter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Accepter.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Click;
            this.FBTN_Accepter.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Disable;
            this.FBTN_Accepter.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Neutral;
            this.FBTN_Accepter.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Over;
            this.FBTN_Accepter.Location = new System.Drawing.Point(351, 264);
            this.FBTN_Accepter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_Accepter.Name = "FBTN_Accepter";
            this.FBTN_Accepter.Size = new System.Drawing.Size(27, 26);
            this.FBTN_Accepter.TabIndex = 49;
            this.FBTN_Accepter.Click += new System.EventHandler(this.FBTN_Accepter_Click);
            // 
            // NUD_DebutHeure
            // 
            this.NUD_DebutHeure.Location = new System.Drawing.Point(70, 242);
            this.NUD_DebutHeure.Margin = new System.Windows.Forms.Padding(1);
            this.NUD_DebutHeure.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUD_DebutHeure.Name = "NUD_DebutHeure";
            this.NUD_DebutHeure.Size = new System.Drawing.Size(39, 20);
            this.NUD_DebutHeure.TabIndex = 50;
            this.NUD_DebutHeure.ValueChanged += new System.EventHandler(this.NUD_DebutHeure_ValueChanged);
            // 
            // NUD_DebutMinute
            // 
            this.NUD_DebutMinute.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_DebutMinute.Location = new System.Drawing.Point(133, 242);
            this.NUD_DebutMinute.Margin = new System.Windows.Forms.Padding(1);
            this.NUD_DebutMinute.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.NUD_DebutMinute.Name = "NUD_DebutMinute";
            this.NUD_DebutMinute.Size = new System.Drawing.Size(39, 20);
            this.NUD_DebutMinute.TabIndex = 50;
            this.NUD_DebutMinute.ValueChanged += new System.EventHandler(this.NUD_DebutMinute_ValueChanged);
            // 
            // NUD_FinHeure
            // 
            this.NUD_FinHeure.Location = new System.Drawing.Point(70, 268);
            this.NUD_FinHeure.Margin = new System.Windows.Forms.Padding(1);
            this.NUD_FinHeure.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUD_FinHeure.Name = "NUD_FinHeure";
            this.NUD_FinHeure.Size = new System.Drawing.Size(39, 20);
            this.NUD_FinHeure.TabIndex = 50;
            this.NUD_FinHeure.ValueChanged += new System.EventHandler(this.NUD_FinHeure_ValueChanged);
            // 
            // NUD_FinMinute
            // 
            this.NUD_FinMinute.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_FinMinute.Location = new System.Drawing.Point(133, 268);
            this.NUD_FinMinute.Margin = new System.Windows.Forms.Padding(1);
            this.NUD_FinMinute.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.NUD_FinMinute.Name = "NUD_FinMinute";
            this.NUD_FinMinute.Size = new System.Drawing.Size(39, 20);
            this.NUD_FinMinute.TabIndex = 50;
            this.NUD_FinMinute.ValueChanged += new System.EventHandler(this.NUD_FinMinute_ValueChanged);
            // 
            // LB_2PointsDebut
            // 
            this.LB_2PointsDebut.AutoSize = true;
            this.LB_2PointsDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_2PointsDebut.Location = new System.Drawing.Point(113, 239);
            this.LB_2PointsDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_2PointsDebut.Name = "LB_2PointsDebut";
            this.LB_2PointsDebut.Size = new System.Drawing.Size(16, 24);
            this.LB_2PointsDebut.TabIndex = 51;
            this.LB_2PointsDebut.Text = ":";
            // 
            // LB_2PointsFin
            // 
            this.LB_2PointsFin.AutoSize = true;
            this.LB_2PointsFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_2PointsFin.Location = new System.Drawing.Point(113, 265);
            this.LB_2PointsFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_2PointsFin.Name = "LB_2PointsFin";
            this.LB_2PointsFin.Size = new System.Drawing.Size(16, 24);
            this.LB_2PointsFin.TabIndex = 51;
            this.LB_2PointsFin.Text = ":";
            // 
            // DLG_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 299);
            this.Controls.Add(this.LB_2PointsFin);
            this.Controls.Add(this.LB_2PointsDebut);
            this.Controls.Add(this.NUD_FinMinute);
            this.Controls.Add(this.NUD_DebutMinute);
            this.Controls.Add(this.NUD_FinHeure);
            this.Controls.Add(this.NUD_DebutHeure);
            this.Controls.Add(this.FBTN_Accepter);
            this.Controls.Add(this.FBTN_Close);
            this.Controls.Add(this.PB_Autre);
            this.Controls.Add(this.PB_Loisir);
            this.Controls.Add(this.PB_Important);
            this.Controls.Add(this.PB_Sante);
            this.Controls.Add(this.PB_Travail);
            this.Controls.Add(this.PB_General);
            this.Controls.Add(this.GB_Categorie);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.LB_Fin);
            this.Controls.Add(this.TBX_Description);
            this.Controls.Add(this.LB_Debut);
            this.Controls.Add(this.LB_Date);
            this.Controls.Add(this.LB_Description);
            this.Controls.Add(this.LB_Titre);
            this.Controls.Add(this.TBX_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DLG_Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DLG_Events";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_Events_FormClosing);
            this.Load += new System.EventHandler(this.DLG_Events_Load);
            this.GB_Categorie.ResumeLayout(false);
            this.GB_Categorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_General)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Travail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Sante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Important)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Loisir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Autre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DebutHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DebutMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FinHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FinMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Title;
        private System.Windows.Forms.Label LB_Titre;
        private System.Windows.Forms.Label LB_Description;
        private System.Windows.Forms.TextBox TBX_Description;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label LB_Date;
        private System.Windows.Forms.Label LB_Debut;
        private System.Windows.Forms.Label LB_Fin;
        private System.Windows.Forms.GroupBox GB_Categorie;
        private System.Windows.Forms.RadioButton RB_Autre;
        private System.Windows.Forms.RadioButton RB_Loisir;
        private System.Windows.Forms.RadioButton RB_Important;
        private System.Windows.Forms.RadioButton RB_Sante;
        private System.Windows.Forms.RadioButton RB_Travail;
        private System.Windows.Forms.RadioButton RB_General;
        private System.Windows.Forms.PictureBox PB_General;
        private System.Windows.Forms.PictureBox PB_Travail;
        private System.Windows.Forms.PictureBox PB_Sante;
        private System.Windows.Forms.PictureBox PB_Important;
        private System.Windows.Forms.PictureBox PB_Loisir;
        private System.Windows.Forms.PictureBox PB_Autre;
        private FlashButton.FlashButton FBTN_Close;
        private FlashButton.FlashButton FBTN_Accepter;
        private System.Windows.Forms.NumericUpDown NUD_DebutHeure;
        private System.Windows.Forms.NumericUpDown NUD_DebutMinute;
        private System.Windows.Forms.NumericUpDown NUD_FinHeure;
        private System.Windows.Forms.NumericUpDown NUD_FinMinute;
        private System.Windows.Forms.Label LB_2PointsDebut;
        private System.Windows.Forms.Label LB_2PointsFin;
    }
}