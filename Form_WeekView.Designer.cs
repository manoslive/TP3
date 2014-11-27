namespace Compact_Agenda
{
    partial class Form_WeekView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_WeekView));
            this.PN_Frame = new System.Windows.Forms.Panel();
            this.FBTN_DecrementWeek = new FlashButton.FlashButton();
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.CM_Event = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMI_Modifier = new System.Windows.Forms.ToolStripMenuItem();
            this.CMI_Effacer = new System.Windows.Forms.ToolStripMenuItem();
            this.CMI_Reporter = new System.Windows.Forms.ToolStripMenuItem();
            this.CMI_Dupliquer = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_EnteteJour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.afficherSemainCouranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateSemaineCouranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CMI_CouleurFond = new System.Windows.Forms.ToolStripMenuItem();
            this.CMI_CouleurLigne = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeFondDeLaJournéeCouranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_SemaineCourante = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMI_Ligne = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurLignesSecondaires = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeDesÉvênementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeTitreÉvênementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_EnteteHeures = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.couleurDeFondToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.policeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeLaPoliceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PN_Scroll = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Content = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Hours = new Compact_Agenda.DoubleBufferPanel();
            this.ZS_ZoomMaster = new ZoomSliderProject.ZoomSlider();
            this.PB_Fleche = new System.Windows.Forms.PictureBox();
            this.PN_DaysHeader = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Frame.SuspendLayout();
            this.CM_Event.SuspendLayout();
            this.CM_EnteteJour.SuspendLayout();
            this.CM_SemaineCourante.SuspendLayout();
            this.CM_EnteteHeures.SuspendLayout();
            this.PN_Scroll.SuspendLayout();
            this.PN_Hours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fleche)).BeginInit();
            this.SuspendLayout();
            // 
            // PN_Frame
            // 
            this.PN_Frame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Frame.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PN_Frame.Controls.Add(this.PN_Scroll);
            this.PN_Frame.Controls.Add(this.FBTN_DecrementWeek);
            this.PN_Frame.Controls.Add(this.FBTN_IncrementWeek);
            this.PN_Frame.Controls.Add(this.PN_DaysHeader);
            this.PN_Frame.Location = new System.Drawing.Point(0, 0);
            this.PN_Frame.Name = "PN_Frame";
            this.PN_Frame.Size = new System.Drawing.Size(737, 452);
            this.PN_Frame.TabIndex = 4;
            this.PN_Frame.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Frame_Paint);
            // 
            // FBTN_DecrementWeek
            // 
            this.FBTN_DecrementWeek.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_FlecheGauche;
            this.FBTN_DecrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_DecrementWeek.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_FlecheGauche_Click;
            this.FBTN_DecrementWeek.ImageDisable = null;
            this.FBTN_DecrementWeek.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_FlecheGauche;
            this.FBTN_DecrementWeek.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_FlecheGauche_Over;
            this.FBTN_DecrementWeek.Location = new System.Drawing.Point(3, 2);
            this.FBTN_DecrementWeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_DecrementWeek.Name = "FBTN_DecrementWeek";
            this.FBTN_DecrementWeek.Size = new System.Drawing.Size(32, 32);
            this.FBTN_DecrementWeek.TabIndex = 2;
            this.FBTN_DecrementWeek.Click += new System.EventHandler(this.FBTN_DecrementWeek_Click);
            // 
            // FBTN_IncrementWeek
            // 
            this.FBTN_IncrementWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBTN_IncrementWeek.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_FlecheDroite;
            this.FBTN_IncrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_IncrementWeek.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_FlecheDroite_Click;
            this.FBTN_IncrementWeek.ImageDisable = null;
            this.FBTN_IncrementWeek.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_FlecheDroite;
            this.FBTN_IncrementWeek.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_FlecheDroite_Over;
            this.FBTN_IncrementWeek.Location = new System.Drawing.Point(702, 2);
            this.FBTN_IncrementWeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FBTN_IncrementWeek.Name = "FBTN_IncrementWeek";
            this.FBTN_IncrementWeek.Size = new System.Drawing.Size(32, 32);
            this.FBTN_IncrementWeek.TabIndex = 3;
            this.FBTN_IncrementWeek.Click += new System.EventHandler(this.FBTN_IncrementWeek_Click);
            // 
            // CM_Event
            // 
            this.CM_Event.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMI_Modifier,
            this.CMI_Effacer,
            this.CMI_Reporter,
            this.CMI_Dupliquer});
            this.CM_Event.Name = "CM_Event";
            this.CM_Event.Size = new System.Drawing.Size(200, 92);
            // 
            // CMI_Modifier
            // 
            this.CMI_Modifier.Name = "CMI_Modifier";
            this.CMI_Modifier.Size = new System.Drawing.Size(199, 22);
            this.CMI_Modifier.Text = "Modifier...";
            this.CMI_Modifier.Click += new System.EventHandler(this.CMI_Modifier_Click);
            // 
            // CMI_Effacer
            // 
            this.CMI_Effacer.Name = "CMI_Effacer";
            this.CMI_Effacer.Size = new System.Drawing.Size(199, 22);
            this.CMI_Effacer.Text = "Effacer...";
            this.CMI_Effacer.Click += new System.EventHandler(this.CMI_Effacer_Click);
            // 
            // CMI_Reporter
            // 
            this.CMI_Reporter.Name = "CMI_Reporter";
            this.CMI_Reporter.Size = new System.Drawing.Size(199, 22);
            this.CMI_Reporter.Text = "Reporter d\'une semaine";
            this.CMI_Reporter.Click += new System.EventHandler(this.CMI_Reporter_Click);
            // 
            // CMI_Dupliquer
            // 
            this.CMI_Dupliquer.Name = "CMI_Dupliquer";
            this.CMI_Dupliquer.Size = new System.Drawing.Size(199, 22);
            this.CMI_Dupliquer.Text = "Dupliquer...";
            this.CMI_Dupliquer.Click += new System.EventHandler(this.CMI_Dupliquer_Click);
            // 
            // CM_EnteteJour
            // 
            this.CM_EnteteJour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherSemainCouranteToolStripMenuItem,
            this.dateSemaineCouranteToolStripMenuItem,
            this.toolStripSeparator1,
            this.CMI_CouleurFond,
            this.CMI_CouleurLigne,
            this.couleurDeFondDeLaJournéeCouranteToolStripMenuItem});
            this.CM_EnteteJour.Name = "CM_SemaineCourante";
            this.CM_EnteteJour.Size = new System.Drawing.Size(291, 120);
            // 
            // afficherSemainCouranteToolStripMenuItem
            // 
            this.afficherSemainCouranteToolStripMenuItem.Name = "afficherSemainCouranteToolStripMenuItem";
            this.afficherSemainCouranteToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.afficherSemainCouranteToolStripMenuItem.Text = "Afficher la semaine courante...";
            this.afficherSemainCouranteToolStripMenuItem.Click += new System.EventHandler(this.afficherSemainCouranteToolStripMenuItem_Click);
            // 
            // dateSemaineCouranteToolStripMenuItem
            // 
            this.dateSemaineCouranteToolStripMenuItem.Name = "dateSemaineCouranteToolStripMenuItem";
            this.dateSemaineCouranteToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.dateSemaineCouranteToolStripMenuItem.Text = "Afficher la semaine du...";
            this.dateSemaineCouranteToolStripMenuItem.Click += new System.EventHandler(this.dateSemaineCouranteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(287, 6);
            // 
            // CMI_CouleurFond
            // 
            this.CMI_CouleurFond.Name = "CMI_CouleurFond";
            this.CMI_CouleurFond.Size = new System.Drawing.Size(290, 22);
            this.CMI_CouleurFond.Text = "Couleur de fond...";
            this.CMI_CouleurFond.Click += new System.EventHandler(this.CMI_CouleurFond_Click);
            // 
            // CMI_CouleurLigne
            // 
            this.CMI_CouleurLigne.Name = "CMI_CouleurLigne";
            this.CMI_CouleurLigne.Size = new System.Drawing.Size(290, 22);
            this.CMI_CouleurLigne.Text = "Couleur des lignes...";
            this.CMI_CouleurLigne.Click += new System.EventHandler(this.CMI_CouleurLigne_Click);
            // 
            // couleurDeFondDeLaJournéeCouranteToolStripMenuItem
            // 
            this.couleurDeFondDeLaJournéeCouranteToolStripMenuItem.Name = "couleurDeFondDeLaJournéeCouranteToolStripMenuItem";
            this.couleurDeFondDeLaJournéeCouranteToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.couleurDeFondDeLaJournéeCouranteToolStripMenuItem.Text = "Couleur de fond de la journée courante...";
            this.couleurDeFondDeLaJournéeCouranteToolStripMenuItem.Click += new System.EventHandler(this.couleurDeFondDeLaJournéeCouranteToolStripMenuItem_Click);
            // 
            // CM_SemaineCourante
            // 
            this.CM_SemaineCourante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMI_Ligne,
            this.couleurLignesSecondaires,
            this.couleurDeFondToolStripMenuItem,
            this.policeDesÉvênementsToolStripMenuItem,
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem,
            this.policeTitreÉvênementToolStripMenuItem});
            this.CM_SemaineCourante.Name = "CM_SemaineCourante";
            this.CM_SemaineCourante.Size = new System.Drawing.Size(268, 136);
            // 
            // CMI_Ligne
            // 
            this.CMI_Ligne.Name = "CMI_Ligne";
            this.CMI_Ligne.Size = new System.Drawing.Size(267, 22);
            this.CMI_Ligne.Text = "Couleur lignes principales...";
            this.CMI_Ligne.Click += new System.EventHandler(this.CMI_Ligne_Click);
            // 
            // couleurLignesSecondaires
            // 
            this.couleurLignesSecondaires.Name = "couleurLignesSecondaires";
            this.couleurLignesSecondaires.Size = new System.Drawing.Size(267, 22);
            this.couleurLignesSecondaires.Text = "Couleur lignes secondaires";
            this.couleurLignesSecondaires.Click += new System.EventHandler(this.couleurLignesHorizontalesToolStripMenuItem_Click);
            // 
            // couleurDeFondToolStripMenuItem
            // 
            this.couleurDeFondToolStripMenuItem.Name = "couleurDeFondToolStripMenuItem";
            this.couleurDeFondToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.couleurDeFondToolStripMenuItem.Text = "Couleur de fond...";
            this.couleurDeFondToolStripMenuItem.Click += new System.EventHandler(this.couleurDeFondToolStripMenuItem_Click);
            // 
            // policeDesÉvênementsToolStripMenuItem
            // 
            this.policeDesÉvênementsToolStripMenuItem.Name = "policeDesÉvênementsToolStripMenuItem";
            this.policeDesÉvênementsToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.policeDesÉvênementsToolStripMenuItem.Text = "Police description évênement...";
            this.policeDesÉvênementsToolStripMenuItem.Click += new System.EventHandler(this.policeDesÉvênementsToolStripMenuItem_Click);
            // 
            // couleurDeLaPoliceDesÉvênementsToolStripMenuItem
            // 
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem.Name = "couleurDeLaPoliceDesÉvênementsToolStripMenuItem";
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem.Text = "Couleur de la police des évênements";
            this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem.Click += new System.EventHandler(this.couleurDeLaPoliceDesÉvênementsToolStripMenuItem_Click);
            // 
            // policeTitreÉvênementToolStripMenuItem
            // 
            this.policeTitreÉvênementToolStripMenuItem.Name = "policeTitreÉvênementToolStripMenuItem";
            this.policeTitreÉvênementToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.policeTitreÉvênementToolStripMenuItem.Text = "Police titre évênement...";
            this.policeTitreÉvênementToolStripMenuItem.Click += new System.EventHandler(this.policeTitreÉvênementToolStripMenuItem_Click);
            // 
            // CM_EnteteHeures
            // 
            this.CM_EnteteHeures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couleurDeFondToolStripMenuItem1,
            this.policeToolStripMenuItem1,
            this.couleurDeLaPoliceToolStripMenuItem1});
            this.CM_EnteteHeures.Name = "CM_EnteteHeures";
            this.CM_EnteteHeures.Size = new System.Drawing.Size(189, 70);
            // 
            // couleurDeFondToolStripMenuItem1
            // 
            this.couleurDeFondToolStripMenuItem1.Name = "couleurDeFondToolStripMenuItem1";
            this.couleurDeFondToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.couleurDeFondToolStripMenuItem1.Text = "Couleur de fond...";
            this.couleurDeFondToolStripMenuItem1.Click += new System.EventHandler(this.couleurDeFondToolStripMenuItem1_Click);
            // 
            // policeToolStripMenuItem1
            // 
            this.policeToolStripMenuItem1.Name = "policeToolStripMenuItem1";
            this.policeToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.policeToolStripMenuItem1.Text = "Police...";
            this.policeToolStripMenuItem1.Click += new System.EventHandler(this.policeToolStripMenuItem1_Click);
            // 
            // couleurDeLaPoliceToolStripMenuItem1
            // 
            this.couleurDeLaPoliceToolStripMenuItem1.Name = "couleurDeLaPoliceToolStripMenuItem1";
            this.couleurDeLaPoliceToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.couleurDeLaPoliceToolStripMenuItem1.Text = "Couleur de la police...";
            this.couleurDeLaPoliceToolStripMenuItem1.Click += new System.EventHandler(this.couleurDeLaPoliceToolStripMenuItem1_Click);
            // 
            // PN_Scroll
            // 
            this.PN_Scroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Scroll.AutoScroll = true;
            this.PN_Scroll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PN_Scroll.Controls.Add(this.PN_Content);
            this.PN_Scroll.Controls.Add(this.PN_Hours);
            this.PN_Scroll.Location = new System.Drawing.Point(3, 34);
            this.PN_Scroll.Margin = new System.Windows.Forms.Padding(0);
            this.PN_Scroll.Name = "PN_Scroll";
            this.PN_Scroll.Size = new System.Drawing.Size(731, 395);
            this.PN_Scroll.TabIndex = 1;
            this.PN_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PN_Scroll_Scroll);
            this.PN_Scroll.Resize += new System.EventHandler(this.PN_Scroll_Resize);
            // 
            // PN_Content
            // 
            this.PN_Content.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PN_Content.Location = new System.Drawing.Point(36, 0);
            this.PN_Content.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PN_Content.Name = "PN_Content";
            this.PN_Content.Size = new System.Drawing.Size(628, 452);
            this.PN_Content.TabIndex = 0;
            this.PN_Content.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Content_Paint);
            this.PN_Content.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseClick);
            this.PN_Content.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDoubleClick);
            this.PN_Content.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDown);
            this.PN_Content.MouseEnter += new System.EventHandler(this.PN_Scroll_MouseEnter);
            this.PN_Content.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseMove);
            this.PN_Content.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseUp);
            this.PN_Content.Resize += new System.EventHandler(this.PN_Content_Resize);
            // 
            // PN_Hours
            // 
            this.PN_Hours.Controls.Add(this.ZS_ZoomMaster);
            this.PN_Hours.Controls.Add(this.PB_Fleche);
            this.PN_Hours.Location = new System.Drawing.Point(0, 0);
            this.PN_Hours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PN_Hours.Name = "PN_Hours";
            this.PN_Hours.Size = new System.Drawing.Size(36, 509);
            this.PN_Hours.TabIndex = 1;
            this.PN_Hours.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Hours_Paint);
            this.PN_Hours.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_Hours_MouseClick);
            this.PN_Hours.MouseEnter += new System.EventHandler(this.PN_Hours_MouseEnter);
            this.PN_Hours.MouseLeave += new System.EventHandler(this.PN_Hours_MouseLeave);
            // 
            // ZS_ZoomMaster
            // 
            this.ZS_ZoomMaster.BackColor = System.Drawing.Color.White;
            this.ZS_ZoomMaster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ZS_ZoomMaster.BackgroundImage")));
            this.ZS_ZoomMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ZS_ZoomMaster.Location = new System.Drawing.Point(19, 0);
            this.ZS_ZoomMaster.Name = "ZS_ZoomMaster";
            this.ZS_ZoomMaster.Size = new System.Drawing.Size(17, 150);
            this.ZS_ZoomMaster.TabIndex = 2;
            this.ZS_ZoomMaster.Value = 50;
            this.ZS_ZoomMaster.ValueChanged += new ZoomSliderProject.ZoomSlider.ValueChangedHandler(this.ZS_ZoomMaster_ValueChanged);
            // 
            // PB_Fleche
            // 
            this.PB_Fleche.BackColor = System.Drawing.Color.Transparent;
            this.PB_Fleche.BackgroundImage = global::Compact_Agenda.Properties.Resources.Arrow_Time1;
            this.PB_Fleche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Fleche.Location = new System.Drawing.Point(3, 127);
            this.PB_Fleche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PB_Fleche.Name = "PB_Fleche";
            this.PB_Fleche.Size = new System.Drawing.Size(29, 25);
            this.PB_Fleche.TabIndex = 0;
            this.PB_Fleche.TabStop = false;
            this.PB_Fleche.Visible = false;
            // 
            // PN_DaysHeader
            // 
            this.PN_DaysHeader.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PN_DaysHeader.Location = new System.Drawing.Point(39, 2);
            this.PN_DaysHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PN_DaysHeader.Name = "PN_DaysHeader";
            this.PN_DaysHeader.Size = new System.Drawing.Size(628, 32);
            this.PN_DaysHeader.TabIndex = 0;
            this.PN_DaysHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_DaysHeader_Paint);
            this.PN_DaysHeader.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_DaysHeader_MouseClick);
            // 
            // Form_WeekView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 431);
            this.Controls.Add(this.PN_Frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(590, 470);
            this.Name = "Form_WeekView";
            this.Text = "Agenda compacte...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_WeekView_FormClosing);
            this.Load += new System.EventHandler(this.Form_WeekView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_WeekView_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_WeekView_KeyPress);
            this.PN_Frame.ResumeLayout(false);
            this.CM_Event.ResumeLayout(false);
            this.CM_EnteteJour.ResumeLayout(false);
            this.CM_SemaineCourante.ResumeLayout(false);
            this.CM_EnteteHeures.ResumeLayout(false);
            this.PN_Scroll.ResumeLayout(false);
            this.PN_Hours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fleche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferPanel PN_DaysHeader;
        private DoubleBufferPanel PN_Scroll;
        private DoubleBufferPanel PN_Content;
        private DoubleBufferPanel PN_Hours;
        private FlashButton.FlashButton FBTN_DecrementWeek;
        private FlashButton.FlashButton FBTN_IncrementWeek;
        private System.Windows.Forms.Panel PN_Frame;
        private System.Windows.Forms.ContextMenuStrip CM_Event;
        private System.Windows.Forms.ToolStripMenuItem CMI_Modifier;
        private System.Windows.Forms.ToolStripMenuItem CMI_Effacer;
        private System.Windows.Forms.ToolStripMenuItem CMI_Reporter;
        private System.Windows.Forms.ToolStripMenuItem CMI_Dupliquer;
        private System.Windows.Forms.ContextMenuStrip CM_EnteteJour;
        private System.Windows.Forms.ToolStripMenuItem CMI_CouleurFond;
        private System.Windows.Forms.ToolStripMenuItem CMI_CouleurLigne;
        private System.Windows.Forms.ToolStripMenuItem dateSemaineCouranteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CM_SemaineCourante;
        private System.Windows.Forms.ToolStripMenuItem CMI_Ligne;
        private System.Windows.Forms.ToolStripMenuItem couleurDeFondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeDesÉvênementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurDeLaPoliceDesÉvênementsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CM_EnteteHeures;
        private System.Windows.Forms.ToolStripMenuItem couleurDeFondToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem policeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem couleurDeLaPoliceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem policeTitreÉvênementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurLignesSecondaires;
        private System.Windows.Forms.PictureBox PB_Fleche;
        private System.Windows.Forms.ToolStripMenuItem couleurDeFondDeLaJournéeCouranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherSemainCouranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ZoomSliderProject.ZoomSlider ZS_ZoomMaster;

    }
}