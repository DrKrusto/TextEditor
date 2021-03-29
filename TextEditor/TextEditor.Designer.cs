
namespace TextEditor
{
    partial class TextEditor
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.rtb_editor = new System.Windows.Forms.RichTextBox();
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_newWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_saveFileUnder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msi_quitWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.msi_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.msi_selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_getDate = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_automaticReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_font = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_zoomFoward = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_zoomBackward = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_zoomDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_stateBar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_stateBar = new System.Windows.Forms.Panel();
            this.panel_informations = new System.Windows.Forms.Panel();
            this.panel_encoding = new System.Windows.Forms.Panel();
            this.lbl_encoding = new System.Windows.Forms.Label();
            this.panel_cursorPosition = new System.Windows.Forms.Panel();
            this.lbl_cursorPosition = new System.Windows.Forms.Label();
            this.panel_zoom = new System.Windows.Forms.Panel();
            this.lbl_zoom = new System.Windows.Forms.Label();
            this.listener = new System.Windows.Forms.Timer(this.components);
            this.cms_rightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsi_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsi_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsi_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsi_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsi_selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_menu.SuspendLayout();
            this.panel_stateBar.SuspendLayout();
            this.panel_informations.SuspendLayout();
            this.panel_encoding.SuspendLayout();
            this.panel_cursorPosition.SuspendLayout();
            this.panel_zoom.SuspendLayout();
            this.cms_rightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_editor
            // 
            this.rtb_editor.AcceptsTab = true;
            this.rtb_editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_editor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_editor.ContextMenuStrip = this.cms_rightClick;
            this.rtb_editor.DetectUrls = false;
            this.rtb_editor.Location = new System.Drawing.Point(0, 24);
            this.rtb_editor.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.rtb_editor.MinimumSize = new System.Drawing.Size(800, 403);
            this.rtb_editor.Name = "rtb_editor";
            this.rtb_editor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtb_editor.Size = new System.Drawing.Size(800, 403);
            this.rtb_editor.TabIndex = 0;
            this.rtb_editor.Text = "";
            this.rtb_editor.WordWrap = false;
            this.rtb_editor.TextChanged += new System.EventHandler(this.rtb_editor_TextChanged);
            // 
            // ms_menu
            // 
            this.ms_menu.BackColor = System.Drawing.Color.White;
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.affichageToolStripMenuItem});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(800, 24);
            this.ms_menu.TabIndex = 1;
            this.ms_menu.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_newFile,
            this.msi_newWindow,
            this.msi_openFile,
            this.msi_saveFile,
            this.msi_saveFileUnder,
            this.toolStripSeparator2,
            this.msi_quitWindow});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // msi_newFile
            // 
            this.msi_newFile.BackColor = System.Drawing.Color.White;
            this.msi_newFile.Name = "msi_newFile";
            this.msi_newFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.msi_newFile.Size = new System.Drawing.Size(234, 22);
            this.msi_newFile.Text = "Nouveau";
            this.msi_newFile.Click += new System.EventHandler(this.msi_newFile_Click);
            // 
            // msi_newWindow
            // 
            this.msi_newWindow.BackColor = System.Drawing.Color.White;
            this.msi_newWindow.Name = "msi_newWindow";
            this.msi_newWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.msi_newWindow.Size = new System.Drawing.Size(234, 22);
            this.msi_newWindow.Text = "Nouvelle fenêtre";
            this.msi_newWindow.Click += new System.EventHandler(this.msi_newWindow_Click);
            // 
            // msi_openFile
            // 
            this.msi_openFile.BackColor = System.Drawing.Color.White;
            this.msi_openFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.msi_openFile.Name = "msi_openFile";
            this.msi_openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.msi_openFile.Size = new System.Drawing.Size(234, 22);
            this.msi_openFile.Text = "Ouvrir...";
            this.msi_openFile.Click += new System.EventHandler(this.msi_openFile_Click);
            // 
            // msi_saveFile
            // 
            this.msi_saveFile.BackColor = System.Drawing.Color.White;
            this.msi_saveFile.Name = "msi_saveFile";
            this.msi_saveFile.ShortcutKeyDisplayString = "Ctrl+S";
            this.msi_saveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.msi_saveFile.Size = new System.Drawing.Size(234, 22);
            this.msi_saveFile.Text = "Enregistrer";
            this.msi_saveFile.Click += new System.EventHandler(this.msi_saveFile_Click);
            // 
            // msi_saveFileUnder
            // 
            this.msi_saveFileUnder.BackColor = System.Drawing.Color.White;
            this.msi_saveFileUnder.Name = "msi_saveFileUnder";
            this.msi_saveFileUnder.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.msi_saveFileUnder.Size = new System.Drawing.Size(234, 22);
            this.msi_saveFileUnder.Text = "Enregistrer sous...";
            this.msi_saveFileUnder.Click += new System.EventHandler(this.msi_saveFileUnder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // msi_quitWindow
            // 
            this.msi_quitWindow.BackColor = System.Drawing.Color.White;
            this.msi_quitWindow.Name = "msi_quitWindow";
            this.msi_quitWindow.Size = new System.Drawing.Size(234, 22);
            this.msi_quitWindow.Text = "Quitter";
            this.msi_quitWindow.Click += new System.EventHandler(this.msi_quitWindow_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_cancel,
            this.toolStripSeparator3,
            this.msi_cut,
            this.msi_copy,
            this.msi_paste,
            this.msi_delete,
            this.toolStripSeparator4,
            this.msi_selectAll,
            this.msi_getDate});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // msi_cancel
            // 
            this.msi_cancel.BackColor = System.Drawing.Color.White;
            this.msi_cancel.Name = "msi_cancel";
            this.msi_cancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.msi_cancel.Size = new System.Drawing.Size(206, 22);
            this.msi_cancel.Text = "Annuler";
            this.msi_cancel.Click += new System.EventHandler(this.annulerText);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // msi_cut
            // 
            this.msi_cut.BackColor = System.Drawing.Color.White;
            this.msi_cut.Name = "msi_cut";
            this.msi_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.msi_cut.Size = new System.Drawing.Size(206, 22);
            this.msi_cut.Text = "Couper";
            this.msi_cut.Click += new System.EventHandler(this.cutText);
            // 
            // msi_copy
            // 
            this.msi_copy.BackColor = System.Drawing.Color.White;
            this.msi_copy.Name = "msi_copy";
            this.msi_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.msi_copy.Size = new System.Drawing.Size(206, 22);
            this.msi_copy.Text = "Copier";
            this.msi_copy.Click += new System.EventHandler(this.copyText);
            // 
            // msi_paste
            // 
            this.msi_paste.BackColor = System.Drawing.Color.White;
            this.msi_paste.Name = "msi_paste";
            this.msi_paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.msi_paste.Size = new System.Drawing.Size(206, 22);
            this.msi_paste.Text = "Coller";
            this.msi_paste.Click += new System.EventHandler(this.pasteText);
            // 
            // msi_delete
            // 
            this.msi_delete.BackColor = System.Drawing.Color.White;
            this.msi_delete.Name = "msi_delete";
            this.msi_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.msi_delete.Size = new System.Drawing.Size(206, 22);
            this.msi_delete.Text = "Supprimer";
            this.msi_delete.Click += new System.EventHandler(this.deleteText);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(203, 6);
            // 
            // msi_selectAll
            // 
            this.msi_selectAll.BackColor = System.Drawing.Color.White;
            this.msi_selectAll.Name = "msi_selectAll";
            this.msi_selectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.msi_selectAll.Size = new System.Drawing.Size(206, 22);
            this.msi_selectAll.Text = "Sélectionner tout";
            this.msi_selectAll.Click += new System.EventHandler(this.msi_selectAll_Click);
            // 
            // msi_getDate
            // 
            this.msi_getDate.BackColor = System.Drawing.Color.White;
            this.msi_getDate.Name = "msi_getDate";
            this.msi_getDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.msi_getDate.Size = new System.Drawing.Size(206, 22);
            this.msi_getDate.Text = "Heure/Date";
            this.msi_getDate.Click += new System.EventHandler(this.msi_getDate_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_automaticReturn,
            this.msi_font});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // msi_automaticReturn
            // 
            this.msi_automaticReturn.BackColor = System.Drawing.Color.White;
            this.msi_automaticReturn.Name = "msi_automaticReturn";
            this.msi_automaticReturn.Size = new System.Drawing.Size(230, 22);
            this.msi_automaticReturn.Text = "Retour automatique à la ligne";
            this.msi_automaticReturn.Click += new System.EventHandler(this.msi_automaticReturn_Click);
            // 
            // msi_font
            // 
            this.msi_font.BackColor = System.Drawing.Color.White;
            this.msi_font.Name = "msi_font";
            this.msi_font.Size = new System.Drawing.Size(230, 22);
            this.msi_font.Text = "Police...";
            this.msi_font.Click += new System.EventHandler(this.msi_font_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_zoom,
            this.msi_stateBar});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // msi_zoom
            // 
            this.msi_zoom.BackColor = System.Drawing.Color.White;
            this.msi_zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_zoomFoward,
            this.msi_zoomBackward,
            this.msi_zoomDefault});
            this.msi_zoom.Name = "msi_zoom";
            this.msi_zoom.Size = new System.Drawing.Size(134, 22);
            this.msi_zoom.Text = "Zoom";
            // 
            // msi_zoomFoward
            // 
            this.msi_zoomFoward.Name = "msi_zoomFoward";
            this.msi_zoomFoward.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.msi_zoomFoward.Size = new System.Drawing.Size(265, 22);
            this.msi_zoomFoward.Text = "Zoom avant";
            this.msi_zoomFoward.Click += new System.EventHandler(this.msi_zoomFoward_Click);
            // 
            // msi_zoomBackward
            // 
            this.msi_zoomBackward.Name = "msi_zoomBackward";
            this.msi_zoomBackward.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.msi_zoomBackward.Size = new System.Drawing.Size(265, 22);
            this.msi_zoomBackward.Text = "Zoom arrière";
            this.msi_zoomBackward.Click += new System.EventHandler(this.msi_zoomBackward_Click);
            // 
            // msi_zoomDefault
            // 
            this.msi_zoomDefault.Name = "msi_zoomDefault";
            this.msi_zoomDefault.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.msi_zoomDefault.Size = new System.Drawing.Size(265, 22);
            this.msi_zoomDefault.Text = "Restaurer le zoom par défaut";
            this.msi_zoomDefault.Click += new System.EventHandler(this.msi_zoomDefault_Click);
            // 
            // msi_stateBar
            // 
            this.msi_stateBar.BackColor = System.Drawing.Color.White;
            this.msi_stateBar.Checked = true;
            this.msi_stateBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.msi_stateBar.Name = "msi_stateBar";
            this.msi_stateBar.Size = new System.Drawing.Size(134, 22);
            this.msi_stateBar.Text = "Barre d\'état";
            this.msi_stateBar.Click += new System.EventHandler(this.msi_stateBar_Click);
            // 
            // panel_stateBar
            // 
            this.panel_stateBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_stateBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_stateBar.Controls.Add(this.panel_informations);
            this.panel_stateBar.Location = new System.Drawing.Point(-8, 428);
            this.panel_stateBar.Name = "panel_stateBar";
            this.panel_stateBar.Size = new System.Drawing.Size(811, 23);
            this.panel_stateBar.TabIndex = 2;
            // 
            // panel_informations
            // 
            this.panel_informations.Controls.Add(this.panel_encoding);
            this.panel_informations.Controls.Add(this.panel_cursorPosition);
            this.panel_informations.Controls.Add(this.panel_zoom);
            this.panel_informations.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_informations.Location = new System.Drawing.Point(511, 0);
            this.panel_informations.Margin = new System.Windows.Forms.Padding(0);
            this.panel_informations.Name = "panel_informations";
            this.panel_informations.Size = new System.Drawing.Size(298, 21);
            this.panel_informations.TabIndex = 4;
            // 
            // panel_encoding
            // 
            this.panel_encoding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_encoding.Controls.Add(this.lbl_encoding);
            this.panel_encoding.Location = new System.Drawing.Point(200, -1);
            this.panel_encoding.Margin = new System.Windows.Forms.Padding(0);
            this.panel_encoding.Name = "panel_encoding";
            this.panel_encoding.Size = new System.Drawing.Size(97, 23);
            this.panel_encoding.TabIndex = 3;
            // 
            // lbl_encoding
            // 
            this.lbl_encoding.AutoSize = true;
            this.lbl_encoding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_encoding.Location = new System.Drawing.Point(3, 4);
            this.lbl_encoding.Name = "lbl_encoding";
            this.lbl_encoding.Size = new System.Drawing.Size(32, 13);
            this.lbl_encoding.TabIndex = 1;
            this.lbl_encoding.Text = "Code";
            // 
            // panel_cursorPosition
            // 
            this.panel_cursorPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_cursorPosition.Controls.Add(this.lbl_cursorPosition);
            this.panel_cursorPosition.Location = new System.Drawing.Point(0, -1);
            this.panel_cursorPosition.Margin = new System.Windows.Forms.Padding(0);
            this.panel_cursorPosition.Name = "panel_cursorPosition";
            this.panel_cursorPosition.Size = new System.Drawing.Size(135, 23);
            this.panel_cursorPosition.TabIndex = 5;
            // 
            // lbl_cursorPosition
            // 
            this.lbl_cursorPosition.AutoSize = true;
            this.lbl_cursorPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_cursorPosition.Location = new System.Drawing.Point(3, 4);
            this.lbl_cursorPosition.Name = "lbl_cursorPosition";
            this.lbl_cursorPosition.Size = new System.Drawing.Size(58, 13);
            this.lbl_cursorPosition.TabIndex = 2;
            this.lbl_cursorPosition.Text = "Ln 0, Col 0";
            // 
            // panel_zoom
            // 
            this.panel_zoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_zoom.Controls.Add(this.lbl_zoom);
            this.panel_zoom.Location = new System.Drawing.Point(133, -1);
            this.panel_zoom.Margin = new System.Windows.Forms.Padding(0);
            this.panel_zoom.Name = "panel_zoom";
            this.panel_zoom.Size = new System.Drawing.Size(68, 23);
            this.panel_zoom.TabIndex = 4;
            // 
            // lbl_zoom
            // 
            this.lbl_zoom.AutoSize = true;
            this.lbl_zoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_zoom.Location = new System.Drawing.Point(4, 4);
            this.lbl_zoom.Name = "lbl_zoom";
            this.lbl_zoom.Size = new System.Drawing.Size(33, 13);
            this.lbl_zoom.TabIndex = 0;
            this.lbl_zoom.Text = "100%";
            // 
            // listener
            // 
            this.listener.Enabled = true;
            this.listener.Interval = 50;
            this.listener.Tick += new System.EventHandler(this.listener_Tick);
            // 
            // cms_rightClick
            // 
            this.cms_rightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsi_cancel,
            this.toolStripSeparator5,
            this.cmsi_cut,
            this.cmsi_copy,
            this.cmsi_paste,
            this.cmsi_delete,
            this.toolStripSeparator6,
            this.cmsi_selectAll});
            this.cms_rightClick.Name = "cms_rightClick";
            this.cms_rightClick.Size = new System.Drawing.Size(165, 148);
            // 
            // cmsi_cancel
            // 
            this.cmsi_cancel.Name = "cmsi_cancel";
            this.cmsi_cancel.Size = new System.Drawing.Size(164, 22);
            this.cmsi_cancel.Text = "Annuler";
            this.cmsi_cancel.Click += new System.EventHandler(this.annulerText);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // cmsi_cut
            // 
            this.cmsi_cut.Name = "cmsi_cut";
            this.cmsi_cut.Size = new System.Drawing.Size(164, 22);
            this.cmsi_cut.Text = "Couper";
            this.cmsi_cut.Click += new System.EventHandler(this.cutText);
            // 
            // cmsi_copy
            // 
            this.cmsi_copy.Name = "cmsi_copy";
            this.cmsi_copy.Size = new System.Drawing.Size(164, 22);
            this.cmsi_copy.Text = "Copier";
            this.cmsi_copy.Click += new System.EventHandler(this.copyText);
            // 
            // cmsi_paste
            // 
            this.cmsi_paste.Name = "cmsi_paste";
            this.cmsi_paste.Size = new System.Drawing.Size(164, 22);
            this.cmsi_paste.Text = "Coller";
            this.cmsi_paste.Click += new System.EventHandler(this.pasteText);
            // 
            // cmsi_delete
            // 
            this.cmsi_delete.Name = "cmsi_delete";
            this.cmsi_delete.Size = new System.Drawing.Size(164, 22);
            this.cmsi_delete.Text = "Supprimer";
            this.cmsi_delete.Click += new System.EventHandler(this.deleteText);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(161, 6);
            // 
            // cmsi_selectAll
            // 
            this.cmsi_selectAll.Name = "cmsi_selectAll";
            this.cmsi_selectAll.Size = new System.Drawing.Size(164, 22);
            this.cmsi_selectAll.Text = "Tout sélectionner";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_stateBar);
            this.Controls.Add(this.rtb_editor);
            this.Controls.Add(this.ms_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_menu;
            this.Name = "TextEditor";
            this.Text = "TextEditor - New file";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditor_FormClosing);
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.panel_stateBar.ResumeLayout(false);
            this.panel_informations.ResumeLayout(false);
            this.panel_encoding.ResumeLayout(false);
            this.panel_encoding.PerformLayout();
            this.panel_cursorPosition.ResumeLayout(false);
            this.panel_cursorPosition.PerformLayout();
            this.panel_zoom.ResumeLayout(false);
            this.panel_zoom.PerformLayout();
            this.cms_rightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_editor;
        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msi_openFile;
        private System.Windows.Forms.ToolStripMenuItem msi_saveFileUnder;
        private System.Windows.Forms.ToolStripMenuItem msi_saveFile;
        private System.Windows.Forms.ToolStripMenuItem msi_newFile;
        private System.Windows.Forms.ToolStripMenuItem msi_newWindow;
        private System.Windows.Forms.ToolStripMenuItem msi_quitWindow;
        private System.Windows.Forms.Panel panel_stateBar;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msi_font;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msi_cut;
        private System.Windows.Forms.ToolStripMenuItem msi_copy;
        private System.Windows.Forms.ToolStripMenuItem msi_paste;
        private System.Windows.Forms.ToolStripMenuItem msi_delete;
        private System.Windows.Forms.ToolStripMenuItem msi_cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panel_encoding;
        private System.Windows.Forms.Panel panel_zoom;
        private System.Windows.Forms.Panel panel_cursorPosition;
        private System.Windows.Forms.Label lbl_zoom;
        private System.Windows.Forms.Timer listener;
        private System.Windows.Forms.Label lbl_encoding;
        private System.Windows.Forms.Label lbl_cursorPosition;
        private System.Windows.Forms.Panel panel_informations;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msi_zoom;
        private System.Windows.Forms.ToolStripMenuItem msi_zoomFoward;
        private System.Windows.Forms.ToolStripMenuItem msi_zoomBackward;
        private System.Windows.Forms.ToolStripMenuItem msi_zoomDefault;
        private System.Windows.Forms.ToolStripMenuItem msi_stateBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem msi_selectAll;
        private System.Windows.Forms.ToolStripMenuItem msi_getDate;
        private System.Windows.Forms.ToolStripMenuItem msi_automaticReturn;
        private System.Windows.Forms.ContextMenuStrip cms_rightClick;
        private System.Windows.Forms.ToolStripMenuItem cmsi_cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cmsi_cut;
        private System.Windows.Forms.ToolStripMenuItem cmsi_copy;
        private System.Windows.Forms.ToolStripMenuItem cmsi_paste;
        private System.Windows.Forms.ToolStripMenuItem cmsi_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cmsi_selectAll;
    }
}

