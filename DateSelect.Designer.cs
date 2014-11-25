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
            this.DTP_DateSemaineCourante.Location = new System.Drawing.Point(77, 42);
            this.DTP_DateSemaineCourante.Name = "DTP_DateSemaineCourante";
            this.DTP_DateSemaineCourante.Size = new System.Drawing.Size(200, 26);
            this.DTP_DateSemaineCourante.TabIndex = 0;
            // 
            // FBTN_Ok
            // 
            this.FBTN_Ok.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Neutral;
            this.FBTN_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Ok.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Click;
            this.FBTN_Ok.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Disable;
            this.FBTN_Ok.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Neutral;
            this.FBTN_Ok.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Over;
            this.FBTN_Ok.Location = new System.Drawing.Point(295, 99);
            this.FBTN_Ok.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FBTN_Ok.Name = "FBTN_Ok";
            this.FBTN_Ok.Size = new System.Drawing.Size(40, 40);
            this.FBTN_Ok.TabIndex = 50;
            this.FBTN_Ok.Click += new System.EventHandler(this.FBTN_Ok_Click);
            // 
            // FBTN_Cancel
            // 
            this.FBTN_Cancel.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Cancel.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Click;
            this.FBTN_Cancel.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Disable;
            this.FBTN_Cancel.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Cancel.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Over;
            this.FBTN_Cancel.Location = new System.Drawing.Point(233, 99);
            this.FBTN_Cancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FBTN_Cancel.Name = "FBTN_Cancel";
            this.FBTN_Cancel.Size = new System.Drawing.Size(40, 40);
            this.FBTN_Cancel.TabIndex = 51;
            this.FBTN_Cancel.Click += new System.EventHandler(this.FBTN_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Choisissez la semaine que vous voulez afficher";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DateSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FBTN_Ok);
            this.Controls.Add(this.FBTN_Cancel);
            this.Controls.Add(this.DTP_DateSemaineCourante);
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