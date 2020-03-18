namespace AklindanBirSayiTut
{
    partial class Form1
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBenTahminEdeyim = new DevExpress.XtraEditors.SimpleButton();
            this.btnBilgisayarTahminEtsin = new DevExpress.XtraEditors.SimpleButton();
            this.txtMin = new DevExpress.XtraEditors.TextEdit();
            this.txtMax = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Roboto Bk", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(471, 157);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "\r\nAklından Bir Sayı Tut";
            // 
            // btnBenTahminEdeyim
            // 
            this.btnBenTahminEdeyim.Appearance.Font = new System.Drawing.Font("Righteous", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenTahminEdeyim.Appearance.Options.UseFont = true;
            this.btnBenTahminEdeyim.Appearance.Options.UseTextOptions = true;
            this.btnBenTahminEdeyim.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnBenTahminEdeyim.Location = new System.Drawing.Point(52, 163);
            this.btnBenTahminEdeyim.Name = "btnBenTahminEdeyim";
            this.btnBenTahminEdeyim.Size = new System.Drawing.Size(182, 142);
            this.btnBenTahminEdeyim.TabIndex = 1;
            this.btnBenTahminEdeyim.Text = "Ben Tahmin Edeyim";
            this.btnBenTahminEdeyim.Click += new System.EventHandler(this.btnBenTahminEdeyim_Click);
            // 
            // btnBilgisayarTahminEtsin
            // 
            this.btnBilgisayarTahminEtsin.Appearance.Font = new System.Drawing.Font("Righteous", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilgisayarTahminEtsin.Appearance.Options.UseFont = true;
            this.btnBilgisayarTahminEtsin.Appearance.Options.UseTextOptions = true;
            this.btnBilgisayarTahminEtsin.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnBilgisayarTahminEtsin.Location = new System.Drawing.Point(240, 163);
            this.btnBilgisayarTahminEtsin.Name = "btnBilgisayarTahminEtsin";
            this.btnBilgisayarTahminEtsin.Size = new System.Drawing.Size(182, 142);
            this.btnBilgisayarTahminEtsin.TabIndex = 1;
            this.btnBilgisayarTahminEtsin.Text = "Bilgisayar Tahmin Etsin";
            this.btnBilgisayarTahminEtsin.Click += new System.EventHandler(this.btnBilgisayarTahminEtsin_Click);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(52, 311);
            this.txtMin.Name = "txtMin";
            this.txtMin.Properties.Appearance.Font = new System.Drawing.Font("Righteous", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMin.Properties.Appearance.Options.UseFont = true;
            this.txtMin.Properties.Mask.EditMask = "n0";
            this.txtMin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMin.Size = new System.Drawing.Size(156, 44);
            this.txtMin.TabIndex = 2;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(266, 311);
            this.txtMax.Name = "txtMax";
            this.txtMax.Properties.Appearance.Font = new System.Drawing.Font("Righteous", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMax.Properties.Appearance.Options.UseFont = true;
            this.txtMax.Properties.Mask.EditMask = "n0";
            this.txtMax.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMax.Size = new System.Drawing.Size(156, 44);
            this.txtMax.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Righteous", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(215, 311);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 42);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "İle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 368);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.btnBilgisayarTahminEtsin);
            this.Controls.Add(this.btnBenTahminEdeyim);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aklından Bir Sayı Tut";
            ((System.ComponentModel.ISupportInitialize)(this.txtMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMax.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBenTahminEdeyim;
        private DevExpress.XtraEditors.SimpleButton btnBilgisayarTahminEtsin;
        private DevExpress.XtraEditors.TextEdit txtMin;
        private DevExpress.XtraEditors.TextEdit txtMax;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

