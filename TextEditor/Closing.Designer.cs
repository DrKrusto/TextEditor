
namespace TextEditor
{
    partial class Closing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Closing));
            this.lbl_message = new System.Windows.Forms.Label();
            this.panel_choices = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_doNotSave = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel_choices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.AutoEllipsis = true;
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_message.Location = new System.Drawing.Point(12, 22);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(329, 20);
            this.lbl_message.TabIndex = 0;
            this.lbl_message.Text = "Voulez-vous enregistrer les modifications de *";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_choices
            // 
            this.panel_choices.BackColor = System.Drawing.Color.LightGray;
            this.panel_choices.Controls.Add(this.btn_save);
            this.panel_choices.Controls.Add(this.btn_doNotSave);
            this.panel_choices.Controls.Add(this.btn_cancel);
            this.panel_choices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_choices.Location = new System.Drawing.Point(0, 89);
            this.panel_choices.Name = "panel_choices";
            this.panel_choices.Size = new System.Drawing.Size(370, 37);
            this.panel_choices.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_cancel.Location = new System.Drawing.Point(283, 7);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_doNotSave
            // 
            this.btn_doNotSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_doNotSave.Location = new System.Drawing.Point(172, 7);
            this.btn_doNotSave.Name = "btn_doNotSave";
            this.btn_doNotSave.Size = new System.Drawing.Size(105, 23);
            this.btn_doNotSave.TabIndex = 1;
            this.btn_doNotSave.Text = "Ne pas enregistrer";
            this.btn_doNotSave.UseVisualStyleBackColor = true;
            this.btn_doNotSave.Click += new System.EventHandler(this.btn_doNotSave_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_save.Location = new System.Drawing.Point(85, 7);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Enregistrer";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Closing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 126);
            this.Controls.Add(this.panel_choices);
            this.Controls.Add(this.lbl_message);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Closing";
            this.Text = "TextEditor";
            this.panel_choices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Panel panel_choices;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_doNotSave;
    }
}