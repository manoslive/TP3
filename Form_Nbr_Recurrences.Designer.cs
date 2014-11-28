namespace Compact_Agenda
{
    partial class Form_Nbr_Recurrences
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
            this.FBTN_Ok = new FlashButton.FlashButton();
            this.FBTN_Cancel = new FlashButton.FlashButton();
            this.NUD_Recurrence = new System.Windows.Forms.NumericUpDown();
            this.LB_Recurrence = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Recurrence)).BeginInit();
            this.SuspendLayout();
            // 
            // FBTN_Ok
            // 
            this.FBTN_Ok.BackgroundImage = global::Compact_Agenda.Properties.Resources.Accepter;
            this.FBTN_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Ok.ImageClick = global::Compact_Agenda.Properties.Resources.Accepter_Click;
            this.FBTN_Ok.ImageDisable = global::Compact_Agenda.Properties.Resources.Accepter;
            this.FBTN_Ok.ImageNeutral = global::Compact_Agenda.Properties.Resources.Accepter;
            this.FBTN_Ok.ImageOver = global::Compact_Agenda.Properties.Resources.Accepter_Over;
            this.FBTN_Ok.Location = new System.Drawing.Point(180, 128);
            this.FBTN_Ok.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FBTN_Ok.Name = "FBTN_Ok";
            this.FBTN_Ok.Size = new System.Drawing.Size(40, 40);
            this.FBTN_Ok.TabIndex = 52;
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
            this.FBTN_Cancel.Location = new System.Drawing.Point(116, 128);
            this.FBTN_Cancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FBTN_Cancel.Name = "FBTN_Cancel";
            this.FBTN_Cancel.Size = new System.Drawing.Size(40, 40);
            this.FBTN_Cancel.TabIndex = 53;
            this.FBTN_Cancel.Click += new System.EventHandler(this.FBTN_Cancel_Click);
            // 
            // NUD_Recurrence
            // 
            this.NUD_Recurrence.Location = new System.Drawing.Point(59, 52);
            this.NUD_Recurrence.Name = "NUD_Recurrence";
            this.NUD_Recurrence.Size = new System.Drawing.Size(120, 26);
            this.NUD_Recurrence.TabIndex = 54;
            this.NUD_Recurrence.ValueChanged += new System.EventHandler(this.NUD_Recurrence_ValueChanged);
            // 
            // LB_Recurrence
            // 
            this.LB_Recurrence.AutoSize = true;
            this.LB_Recurrence.Location = new System.Drawing.Point(33, 9);
            this.LB_Recurrence.Name = "LB_Recurrence";
            this.LB_Recurrence.Size = new System.Drawing.Size(175, 20);
            this.LB_Recurrence.TabIndex = 55;
            this.LB_Recurrence.Text = "Nombre de récurrences";
            this.LB_Recurrence.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Nbr_Recurrences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 176);
            this.Controls.Add(this.LB_Recurrence);
            this.Controls.Add(this.NUD_Recurrence);
            this.Controls.Add(this.FBTN_Ok);
            this.Controls.Add(this.FBTN_Cancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Nbr_Recurrences";
            this.Text = "Form_Nbr_Recurrences";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Recurrence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlashButton.FlashButton FBTN_Ok;
        private FlashButton.FlashButton FBTN_Cancel;
        private System.Windows.Forms.NumericUpDown NUD_Recurrence;
        private System.Windows.Forms.Label LB_Recurrence;
    }
}