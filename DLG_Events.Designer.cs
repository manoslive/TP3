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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_Description = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.SuspendLayout();
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
            this.TBX_Title.Location = new System.Drawing.Point(105, 18);
            this.TBX_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBX_Title.Name = "TBX_Title";
            this.TBX_Title.Size = new System.Drawing.Size(186, 26);
            this.TBX_Title.TabIndex = 0;
            this.TBX_Title.TextChanged += new System.EventHandler(this.TBX_Title_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            // 
            // TBX_Description
            // 
            this.TBX_Description.Location = new System.Drawing.Point(105, 58);
            this.TBX_Description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBX_Description.Multiline = true;
            this.TBX_Description.Name = "TBX_Description";
            this.TBX_Description.Size = new System.Drawing.Size(186, 255);
            this.TBX_Description.TabIndex = 1;
            this.TBX_Description.TextChanged += new System.EventHandler(this.TBX_Description_TextChanged);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(105, 329);
            this.DTP_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTP_Date.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.DTP_Date.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(186, 26);
            this.DTP_Date.TabIndex = 3;
            this.DTP_Date.ValueChanged += new System.EventHandler(this.DTP_Date_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Début :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fin :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(320, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 295);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catégorie";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(11, 254);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(73, 24);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Autre";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(11, 211);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(71, 24);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Loisir";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(11, 168);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 24);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Important";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 125);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 24);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Santé";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 24);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Travail";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Général";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PB_General
            // 
            this.PB_General.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_General.Location = new System.Drawing.Point(497, 57);
            this.PB_General.Name = "PB_General";
            this.PB_General.Size = new System.Drawing.Size(59, 28);
            this.PB_General.TabIndex = 48;
            this.PB_General.TabStop = false;
            this.PB_General.Click += new System.EventHandler(this.PB_General_Click);
            // 
            // PB_Travail
            // 
            this.PB_Travail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Travail.Location = new System.Drawing.Point(497, 100);
            this.PB_Travail.Name = "PB_Travail";
            this.PB_Travail.Size = new System.Drawing.Size(59, 28);
            this.PB_Travail.TabIndex = 48;
            this.PB_Travail.TabStop = false;
            this.PB_Travail.Click += new System.EventHandler(this.PB_Travail_Click);
            // 
            // PB_Sante
            // 
            this.PB_Sante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Sante.Location = new System.Drawing.Point(497, 143);
            this.PB_Sante.Name = "PB_Sante";
            this.PB_Sante.Size = new System.Drawing.Size(59, 28);
            this.PB_Sante.TabIndex = 48;
            this.PB_Sante.TabStop = false;
            this.PB_Sante.Click += new System.EventHandler(this.PB_Sante_Click);
            // 
            // PB_Important
            // 
            this.PB_Important.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Important.Location = new System.Drawing.Point(497, 186);
            this.PB_Important.Name = "PB_Important";
            this.PB_Important.Size = new System.Drawing.Size(59, 28);
            this.PB_Important.TabIndex = 48;
            this.PB_Important.TabStop = false;
            this.PB_Important.Click += new System.EventHandler(this.PB_Important_Click);
            // 
            // PB_Loisir
            // 
            this.PB_Loisir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Loisir.Location = new System.Drawing.Point(497, 229);
            this.PB_Loisir.Name = "PB_Loisir";
            this.PB_Loisir.Size = new System.Drawing.Size(59, 28);
            this.PB_Loisir.TabIndex = 48;
            this.PB_Loisir.TabStop = false;
            this.PB_Loisir.Click += new System.EventHandler(this.PB_Loisir_Click);
            // 
            // PB_Autre
            // 
            this.PB_Autre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Autre.Location = new System.Drawing.Point(497, 272);
            this.PB_Autre.Name = "PB_Autre";
            this.PB_Autre.Size = new System.Drawing.Size(59, 28);
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
            this.FBTN_Close.Location = new System.Drawing.Point(464, 406);
            this.FBTN_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_Close.Name = "FBTN_Close";
            this.FBTN_Close.Size = new System.Drawing.Size(40, 40);
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
            this.FBTN_Accepter.Location = new System.Drawing.Point(526, 406);
            this.FBTN_Accepter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_Accepter.Name = "FBTN_Accepter";
            this.FBTN_Accepter.Size = new System.Drawing.Size(40, 40);
            this.FBTN_Accepter.TabIndex = 49;
            this.FBTN_Accepter.Click += new System.EventHandler(this.FBTN_Accepter_Click);
            // 
            // NUD_DebutHeure
            // 
            this.NUD_DebutHeure.Location = new System.Drawing.Point(104, 373);
            this.NUD_DebutHeure.Name = "NUD_DebutHeure";
            this.NUD_DebutHeure.Size = new System.Drawing.Size(59, 26);
            this.NUD_DebutHeure.TabIndex = 50;
            this.NUD_DebutHeure.ValueChanged += new System.EventHandler(this.NUD_DebutHeure_ValueChanged);
            // 
            // NUD_DebutMinute
            // 
            this.NUD_DebutMinute.Location = new System.Drawing.Point(200, 373);
            this.NUD_DebutMinute.Name = "NUD_DebutMinute";
            this.NUD_DebutMinute.Size = new System.Drawing.Size(59, 26);
            this.NUD_DebutMinute.TabIndex = 50;
            this.NUD_DebutMinute.ValueChanged += new System.EventHandler(this.NUD_DebutMinute_ValueChanged);
            // 
            // NUD_FinHeure
            // 
            this.NUD_FinHeure.Location = new System.Drawing.Point(105, 413);
            this.NUD_FinHeure.Name = "NUD_FinHeure";
            this.NUD_FinHeure.Size = new System.Drawing.Size(59, 26);
            this.NUD_FinHeure.TabIndex = 50;
            this.NUD_FinHeure.ValueChanged += new System.EventHandler(this.NUD_FinHeure_ValueChanged);
            // 
            // NUD_FinMinute
            // 
            this.NUD_FinMinute.Location = new System.Drawing.Point(200, 413);
            this.NUD_FinMinute.Name = "NUD_FinMinute";
            this.NUD_FinMinute.Size = new System.Drawing.Size(59, 26);
            this.NUD_FinMinute.TabIndex = 50;
            this.NUD_FinMinute.ValueChanged += new System.EventHandler(this.NUD_FinMinute_ValueChanged);
            // 
            // LB_2PointsDebut
            // 
            this.LB_2PointsDebut.AutoSize = true;
            this.LB_2PointsDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_2PointsDebut.Location = new System.Drawing.Point(169, 367);
            this.LB_2PointsDebut.Name = "LB_2PointsDebut";
            this.LB_2PointsDebut.Size = new System.Drawing.Size(24, 32);
            this.LB_2PointsDebut.TabIndex = 51;
            this.LB_2PointsDebut.Text = ":";
            // 
            // LB_2PointsFin
            // 
            this.LB_2PointsFin.AutoSize = true;
            this.LB_2PointsFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_2PointsFin.Location = new System.Drawing.Point(169, 407);
            this.LB_2PointsFin.Name = "LB_2PointsFin";
            this.LB_2PointsFin.Size = new System.Drawing.Size(24, 32);
            this.LB_2PointsFin.TabIndex = 51;
            this.LB_2PointsFin.Text = ":";
            // 
            // DLG_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 460);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBX_Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DLG_Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DLG_Events";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_Events_FormClosing);
            this.Load += new System.EventHandler(this.DLG_Events_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_Description;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
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