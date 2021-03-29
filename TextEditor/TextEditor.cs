using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        TextFile file = new TextFile { FileName = "Nouveau fichier", Exists = false, isSaved = true };
        float zoomBearing = 0.10f;

        public TextEditor()
        {
            InitializeComponent();
            this.updateWindowName(file);
            this.lbl_encoding.Text = "UTF-8";
        }

        #region Evenements
        private void msi_saveFileUnder_Click(object sender, EventArgs e)
        {
            this.saveFile(false);
        }

        private void msi_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(open.FileName))
                {
                    this.rtb_editor.Text = reader.ReadToEnd();
                    this.lbl_encoding.Text = reader.CurrentEncoding.BodyName.ToUpper();
                    reader.Close();
                }
                this.file.FileName = open.FileName;
                this.file.Exists = true;
            }
            this.updateWindowName(this.file);
        }

        private void msi_saveFile_Click(object sender, EventArgs e)
        {
            if (this.file.Exists)
                this.saveFile(true);
            else
                this.saveFile(false);
        }

        private void msi_quitWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtb_editor_TextChanged(object sender, EventArgs e)
        {
            this.file.isSaved = false;
            this.updateWindowName(this.file);
        }

        private void msi_newFile_Click(object sender, EventArgs e)
        {
            this.file = new TextFile { FileName = "Nouveau fichier", Exists = false, isSaved = true };
            this.updateWindowName(this.file);
            this.rtb_editor.Text = "";
        }

        private void msi_newWindow_Click(object sender, EventArgs e)
        {
            TextEditor newWindow = new TextEditor();
            newWindow.Show();
        }

        private void msi_font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = this.rtb_editor.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                this.rtb_editor.Font = fontDialog.Font;
            }
        }

        private void listener_Tick(object sender, EventArgs e)
        {
            this.changeZoom(null, null);
        }

        private void msi_zoomFoward_Click(object sender, EventArgs e)
        {
            this.rtb_editor.ZoomFactor += this.zoomBearing;
        }

        private void msi_zoomBackward_Click(object sender, EventArgs e)
        {
            if (this.rtb_editor.ZoomFactor - this.zoomBearing > 0)
                this.rtb_editor.ZoomFactor -= this.zoomBearing;
        }

        private void msi_zoomDefault_Click(object sender, EventArgs e)
        {
            this.rtb_editor.ZoomFactor = 1f;
        }

        private void msi_stateBar_Click(object sender, EventArgs e)
        {
            if (this.msi_stateBar.Checked)
            {
                this.msi_stateBar.Checked = false;
                this.panel_stateBar.Hide();
                this.rtb_editor.Dock = DockStyle.Fill;
            }
            else
            {
                this.msi_stateBar.Checked = true;
                this.panel_stateBar.Show();
                this.rtb_editor.Dock = DockStyle.None;
            }

        }

        private void msi_getDate_Click(object sender, EventArgs e)
        {
            this.rtb_editor.SelectedText += DateTime.Now.ToString();
        }

        private void msi_selectAll_Click(object sender, EventArgs e)
        {
            this.rtb_editor.SelectAll();
        }

        private void msi_automaticReturn_Click(object sender, EventArgs e)
        {
            if (this.msi_automaticReturn.Checked)
            {
                this.msi_automaticReturn.Checked = false;
                this.rtb_editor.WordWrap = false;
            }
            else
            {
                this.msi_automaticReturn.Checked = true;
                this.rtb_editor.WordWrap = true;
            }
        }

        private void rtb_editor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                cms_rightClick.Show();
                cms_rightClick.Top = e.Y;
                cms_rightClick.Left = e.X;
            }
        }
        #endregion

        #region Fonctions
        private void cutText(object sender, EventArgs e)
        {
            Clipboard.SetText(this.rtb_editor.SelectedText);
            this.rtb_editor.SelectedText = "";
        }

        private void copyText(object sender, EventArgs e)
        {
            Clipboard.SetText(this.rtb_editor.SelectedText);
        }

        private void pasteText(object sender, EventArgs e)
        {
            this.rtb_editor.SelectedText = Clipboard.GetText();
        }

        private void deleteText(object sender, EventArgs e)
        {
            this.rtb_editor.SelectedText = String.Empty;
        }

        private void annulerText(object sender, EventArgs e)
        {
            this.rtb_editor.Undo();
        }

        private void changeZoom(object sender, EventArgs e)
        {
            this.lbl_zoom.Text = String.Format("{0}%", this.rtb_editor.ZoomFactor * 100);
        }

        private void updateWindowName(TextFile file)
        {
            if (file.isSaved)
                this.Text = String.Format("TextEditor - {0}", this.file.FileName);
            else
                this.Text = String.Format("TextEditor - *{0}", this.file.FileName);
        }

        private void saveFile(bool exists)
        {
            if (!exists || this.file.FileName == null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.FileName);
                    writer.WriteLine(this.rtb_editor.Text);
                    writer.Close();
                    this.file.FileName = save.FileName;
                    this.file.isSaved = true;
                    this.file.Exists = true;
                }
                this.updateWindowName(this.file);
            }
            else
            {
                StreamWriter writer = new StreamWriter(file.FileName);
                writer.WriteLine(this.rtb_editor.Text);
                writer.Close();
                this.file.isSaved = true;
                this.file.Exists = true;
                this.updateWindowName(this.file);
            }
        }
        #endregion

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.file.isSaved)
            {
                Closing closeForm = new Closing(this.file);
                if (closeForm.ShowDialog() == DialogResult.Yes)
                {
                    if (this.file.Exists)
                        this.saveFile(true);
                    else
                        this.saveFile(false);
                }
            }
        }
    }
}
