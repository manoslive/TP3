namespace Compact_Agenda
{
    partial class DateSelect
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
            this.DTP_DateSemaineCourante = new System.Windows.Forms.DateTimePicker();
            this.FBTN_Ok = new FlashButton.FlashButton();
            this.FBTN_Cancel = new FlashButton.FlashButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DTP_DateSemaineCourante
            // 
            this.DTP_DateSemaineCourante.Location = new System.Drawing.Point(51, 27);
            this.DTP_DateSemaineCourante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTP_DateSemaineCourante.Name = "DTP_DateSemaineCourante";
            this.DTP_DateSemaineCourante.Size = new System.Drawing.Size(135, 20);
            this.DTP_DateSemaineCourante.TabIndex = 0;
            // 
            // FBTN_Ok
            // 
            this.FBTN_Ok.BackgroundImage = global::Compact_Agenda.Properties.Resources.Accepter;
            this.FBTN_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Ok.ImageClick = global::Compact_Agenda.Properties.Resources.Accepter_Click;
            this.FBTN_Ok.ImageDisable = global::Compact_Agenda.Properties.Resources.Accepter;
            this.FBTN_Ok.ImageNeutral = global::Compact_Agenda.Properties.Resources.Accepter;
            this.FBTN_Ok.ImageOver = global::Compact_Agenda.Properties.Resources.Accepter_Over;
            this.FBTN_Ok.Location = new System.Drawing.Point(197, 64);
            this.FBTN_Ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_Ok.Name = "FBTN_Ok";
            this.FBTN_Ok.Size = new System.Drawing.Size(27, 26);
            this.FBTN_Ok.TabIndex = 50;
            this.FBTN_Ok.Click += new System.EventHandler(this.FBTN_Ok_Click);
            // 
            // FBTN_Cancel
            // 
            this.FBTN_Cancel.BackgroundImage = global::Compact_Agenda.Properties.Resources.Quitter;
            this.FBTN_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Cancel.ImageClick = global::Compact_Agenda.Properties.Resources.Quitter_Click;
            this.FBTN_Cancel.ImageDisable = global::Compact_Agenda.Properties.Resources.Quitter;
            this.FBTN_Cancel.ImageNeutral = global::Compact_Agenda.Properties.Resources.Quitter;
            this.FBTN_Cancel.ImageOver = global::Compact_Agenda.Properties.Resources.Quitter_Over;
            this.FBTN_Cancel.Location = new System.Drawing.Point(155, 64);
            this.FBTN_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_Cancel.Name = "FBTN_Cancel";
            this.FBTN_Cancel.Size = new System.Drawing.Size(27, 26);
            this.FBTN_Cancel.TabIndex = 51;
            this.FBTN_Cancel.Click += new System.EventHandler(this.FBTN_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Choisissez la semaine que vous voulez afficher";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DateSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 101);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FBTN_Ok);
            this.Controls.Add(this.FBTN_Cancel);
            this.Controls.Add(this.DTP_DateSemaineCourante);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(249, 140);
            this.MinimumSize = new System.Drawing.Size(249, 140);
            this.Name = "DateSelect";
            this.Text = "DateSelect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DateSelect_FormClosing);
            this.Load += new System.EventHandler(this.DateSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_DateSemaineCourante;
        private FlashButton.FlashButton FBTN_Ok;
        private FlashButton.FlashButton FBTN_Cancel;
        private System.Windows.Forms.Label label1;
    }
}