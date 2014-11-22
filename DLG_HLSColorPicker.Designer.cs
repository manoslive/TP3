using System.Windows.Forms;
namespace PasswordKeeper
{
 
    partial class DLG_HLSColorPicker
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
            this.TKBR_Hue = new System.Windows.Forms.TrackBar();
            this.PN_ColorPreview = new System.Windows.Forms.Panel();
            this.TKBR_Luminosity = new System.Windows.Forms.TrackBar();
            this.TKBR_Saturation = new System.Windows.Forms.TrackBar();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.LB_Hue = new System.Windows.Forms.Label();
            this.LB_Luminosity = new System.Windows.Forms.Label();
            this.LB_Saturaiton = new System.Windows.Forms.Label();
            this.LB_Teinte = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PN_RecentColors = new System.Windows.Forms.Panel();
            this.PN_Saturation = new PasswordKeeper.DoubleBufferPanel();
            this.PN_Lightness = new PasswordKeeper.DoubleBufferPanel();
            this.PN_Hue = new PasswordKeeper.DoubleBufferPanel();
            ((System.ComponentModel.ISupportInitialize)(this.TKBR_Hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKBR_Luminosity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKBR_Saturation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TKBR_Hue
            // 
            this.TKBR_Hue.CausesValidation = false;
            this.TKBR_Hue.LargeChange = 50;
            this.TKBR_Hue.Location = new System.Drawing.Point(6, 28);
            this.TKBR_Hue.Maximum = 1000;
            this.TKBR_Hue.Name = "TKBR_Hue";
            this.TKBR_Hue.Size = new System.Drawing.Size(320, 45);
            this.TKBR_Hue.TabIndex = 0;
            this.TKBR_Hue.ValueChanged += new System.EventHandler(this.TKBR_Hue_ValueChanged);
            this.TKBR_Hue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TKBR_Hue_MouseDown);
            this.TKBR_Hue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TKBR_Hue_MouseUp);
            // 
            // PN_ColorPreview
            // 
            this.PN_ColorPreview.Location = new System.Drawing.Point(332, 12);
            this.PN_ColorPreview.Name = "PN_ColorPreview";
            this.PN_ColorPreview.Size = new System.Drawing.Size(154, 154);
            this.PN_ColorPreview.TabIndex = 1;
            // 
            // TKBR_Luminosity
            // 
            this.TKBR_Luminosity.CausesValidation = false;
            this.TKBR_Luminosity.LargeChange = 50;
            this.TKBR_Luminosity.Location = new System.Drawing.Point(4, 91);
            this.TKBR_Luminosity.Maximum = 1000;
            this.TKBR_Luminosity.Name = "TKBR_Luminosity";
            this.TKBR_Luminosity.Size = new System.Drawing.Size(320, 45);
            this.TKBR_Luminosity.TabIndex = 3;
            this.TKBR_Luminosity.ValueChanged += new System.EventHandler(this.TKBR_Luminosity_ValueChanged);
            this.TKBR_Luminosity.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TKBR_Hue_MouseDown);
            this.TKBR_Luminosity.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TKBR_Hue_MouseUp);
            // 
            // TKBR_Saturation
            // 
            this.TKBR_Saturation.CausesValidation = false;
            this.TKBR_Saturation.LargeChange = 50;
            this.TKBR_Saturation.Location = new System.Drawing.Point(4, 155);
            this.TKBR_Saturation.Maximum = 1000;
            this.TKBR_Saturation.Name = "TKBR_Saturation";
            this.TKBR_Saturation.Size = new System.Drawing.Size(320, 45);
            this.TKBR_Saturation.TabIndex = 5;
            this.TKBR_Saturation.ValueChanged += new System.EventHandler(this.TKBR_Saturation_ValueChanged);
            this.TKBR_Saturation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TKBR_Hue_MouseDown);
            this.TKBR_Saturation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TKBR_Hue_MouseUp);
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(411, 173);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 7;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(330, 173);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 7;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // LB_Hue
            // 
            this.LB_Hue.AutoSize = true;
            this.LB_Hue.Location = new System.Drawing.Point(292, 12);
            this.LB_Hue.Name = "LB_Hue";
            this.LB_Hue.Size = new System.Drawing.Size(28, 13);
            this.LB_Hue.TabIndex = 8;
            this.LB_Hue.Text = "0.00";
            this.LB_Hue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Luminosity
            // 
            this.LB_Luminosity.AutoSize = true;
            this.LB_Luminosity.Location = new System.Drawing.Point(292, 76);
            this.LB_Luminosity.Name = "LB_Luminosity";
            this.LB_Luminosity.Size = new System.Drawing.Size(28, 13);
            this.LB_Luminosity.TabIndex = 8;
            this.LB_Luminosity.Text = "0.00";
            this.LB_Luminosity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Saturaiton
            // 
            this.LB_Saturaiton.AutoSize = true;
            this.LB_Saturaiton.Location = new System.Drawing.Point(292, 140);
            this.LB_Saturaiton.Name = "LB_Saturaiton";
            this.LB_Saturaiton.Size = new System.Drawing.Size(28, 13);
            this.LB_Saturaiton.TabIndex = 8;
            this.LB_Saturaiton.Text = "0.00";
            this.LB_Saturaiton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Teinte
            // 
            this.LB_Teinte.AutoSize = true;
            this.LB_Teinte.Location = new System.Drawing.Point(9, 12);
            this.LB_Teinte.Name = "LB_Teinte";
            this.LB_Teinte.Size = new System.Drawing.Size(37, 13);
            this.LB_Teinte.TabIndex = 8;
            this.LB_Teinte.Text = "Teinte";
            this.LB_Teinte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Luminosité";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saturation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PN_RecentColors);
            this.groupBox1.Location = new System.Drawing.Point(19, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 83);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Couleurs récentes";
            // 
            // PN_RecentColors
            // 
            this.PN_RecentColors.Location = new System.Drawing.Point(16, 25);
            this.PN_RecentColors.Name = "PN_RecentColors";
            this.PN_RecentColors.Size = new System.Drawing.Size(438, 44);
            this.PN_RecentColors.TabIndex = 0;
            // 
            // PN_Saturation
            // 
            this.PN_Saturation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PN_Saturation.Location = new System.Drawing.Point(17, 177);
            this.PN_Saturation.Name = "PN_Saturation";
            this.PN_Saturation.Size = new System.Drawing.Size(294, 18);
            this.PN_Saturation.TabIndex = 6;
            this.PN_Saturation.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Saturation_Paint);
            this.PN_Saturation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PN_Saturation_MouseDoubleClick);
            this.PN_Saturation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PN_Saturation_MouseDown);
            // 
            // PN_Lightness
            // 
            this.PN_Lightness.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PN_Lightness.Location = new System.Drawing.Point(17, 113);
            this.PN_Lightness.Name = "PN_Lightness";
            this.PN_Lightness.Size = new System.Drawing.Size(294, 18);
            this.PN_Lightness.TabIndex = 4;
            this.PN_Lightness.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Lightness_Paint);
            this.PN_Lightness.DoubleClick += new System.EventHandler(this.PN_Lightness_DoubleClick);
            this.PN_Lightness.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PN_Lightness_MouseDown);
            // 
            // PN_Hue
            // 
            this.PN_Hue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PN_Hue.Location = new System.Drawing.Point(17, 49);
            this.PN_Hue.Name = "PN_Hue";
            this.PN_Hue.Size = new System.Drawing.Size(294, 18);
            this.PN_Hue.TabIndex = 2;
            this.PN_Hue.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Hue_Paint);
            this.PN_Hue.DoubleClick += new System.EventHandler(this.PN_Hue_DoubleClick);
            this.PN_Hue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PN_Hue_MouseDown);
            // 
            // FORM_BackColor
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(499, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_Saturaiton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Luminosity);
            this.Controls.Add(this.LB_Teinte);
            this.Controls.Add(this.LB_Hue);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.PN_Saturation);
            this.Controls.Add(this.TKBR_Saturation);
            this.Controls.Add(this.PN_Lightness);
            this.Controls.Add(this.TKBR_Luminosity);
            this.Controls.Add(this.PN_Hue);
            this.Controls.Add(this.PN_ColorPreview);
            this.Controls.Add(this.TKBR_Hue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "FORM_BackColor";
            this.Text = "Couleur de fond...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_BackColor_FormClosing);
            this.Load += new System.EventHandler(this.FORM_BackColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TKBR_Hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKBR_Luminosity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TKBR_Saturation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TKBR_Hue;
        private System.Windows.Forms.Panel PN_ColorPreview;
        private System.Windows.Forms.TrackBar TKBR_Luminosity;
        private System.Windows.Forms.TrackBar TKBR_Saturation;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Label LB_Hue;
        private System.Windows.Forms.Label LB_Luminosity;
        private System.Windows.Forms.Label LB_Saturaiton;
        private System.Windows.Forms.Label LB_Teinte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DoubleBufferPanel PN_Hue;
        private DoubleBufferPanel PN_Lightness;
        private DoubleBufferPanel PN_Saturation;
        private GroupBox groupBox1;
        private Panel PN_RecentColors;
    }
}