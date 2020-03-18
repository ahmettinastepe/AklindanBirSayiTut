namespace AklindanBirSayiTut
{
    partial class FrmBenTahminEdeyim
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
            this.lblBildirim = new DevExpress.XtraEditors.LabelControl();
            this.txtTahmin = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTahmin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBildirim
            // 
            this.lblBildirim.Appearance.Font = new System.Drawing.Font("Roboto Bk", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBildirim.Appearance.Options.UseFont = true;
            this.lblBildirim.Appearance.Options.UseTextOptions = true;
            this.lblBildirim.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBildirim.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblBildirim.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBildirim.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBildirim.Location = new System.Drawing.Point(0, 0);
            this.lblBildirim.Name = "lblBildirim";
            this.lblBildirim.Size = new System.Drawing.Size(594, 157);
            this.lblBildirim.TabIndex = 1;
            this.lblBildirim.Text = "NETA\r\nAklından Bir Sayı Tut";
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(12, 163);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Properties.Appearance.Font = new System.Drawing.Font("Righteous", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Properties.Appearance.Options.UseFont = true;
            this.txtTahmin.Properties.Mask.EditMask = "n0";
            this.txtTahmin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTahmin.Size = new System.Drawing.Size(570, 44);
            this.txtTahmin.TabIndex = 3;
            this.txtTahmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTahmin_KeyDown);
            // 
            // FrmBenTahminEdeyim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 216);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblBildirim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBenTahminEdeyim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBenTahminEdeyim";
            ((System.ComponentModel.ISupportInitialize)(this.txtTahmin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBildirim;
        private DevExpress.XtraEditors.TextEdit txtTahmin;
    }
}