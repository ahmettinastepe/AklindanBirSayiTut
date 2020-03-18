namespace AklindanBirSayiTut
{
    partial class FrmBilgisayarTahminEtsin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgisayarTahminEtsin));
            this.lblBildirim = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.btnEvet = new DevExpress.XtraEditors.SimpleButton();
            this.btnHayır = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
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
            this.lblBildirim.Size = new System.Drawing.Size(573, 157);
            this.lblBildirim.TabIndex = 2;
            this.lblBildirim.Text = "NETA\r\nAklından Bir Sayı Tut";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControl1.Location = new System.Drawing.Point(12, 163);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(160, 142);
            this.listBoxControl1.TabIndex = 3;
            // 
            // btnEvet
            // 
            this.btnEvet.Appearance.Font = new System.Drawing.Font("Righteous", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvet.Appearance.Options.UseFont = true;
            this.btnEvet.Appearance.Options.UseTextOptions = true;
            this.btnEvet.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnEvet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBenTahminEdeyim.ImageOptions.Image")));
            this.btnEvet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnEvet.Location = new System.Drawing.Point(191, 163);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(182, 142);
            this.btnEvet.TabIndex = 4;
            this.btnEvet.Text = "Evet";
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // btnHayır
            // 
            this.btnHayır.Appearance.Font = new System.Drawing.Font("Righteous", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHayır.Appearance.Options.UseFont = true;
            this.btnHayır.Appearance.Options.UseTextOptions = true;
            this.btnHayır.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnHayır.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnHayır.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnHayır.Location = new System.Drawing.Point(379, 163);
            this.btnHayır.Name = "btnHayır";
            this.btnHayır.Size = new System.Drawing.Size(182, 142);
            this.btnHayır.TabIndex = 4;
            this.btnHayır.Text = "Hayır";
            this.btnHayır.Click += new System.EventHandler(this.btnHayır_Click);
            // 
            // FrmBilgisayarTahminEtsin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 310);
            this.Controls.Add(this.btnHayır);
            this.Controls.Add(this.btnEvet);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.lblBildirim);
            this.Name = "FrmBilgisayarTahminEtsin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBilgisayarTahminEtsin";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBildirim;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton btnEvet;
        private DevExpress.XtraEditors.SimpleButton btnHayır;
    }
}