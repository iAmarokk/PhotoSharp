namespace Picture
{
    partial class PhotoSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoSharp));
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonOpenPicture = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.checkBoxGray = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.labelContrast = new System.Windows.Forms.Label();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.comboBoxCorrection = new System.Windows.Forms.ComboBox();
            this.labelGamma = new System.Windows.Forms.Label();
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(12, 27);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(978, 494);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // buttonOpenPicture
            // 
            this.buttonOpenPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenPicture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenPicture.Location = new System.Drawing.Point(996, 27);
            this.buttonOpenPicture.Name = "buttonOpenPicture";
            this.buttonOpenPicture.Size = new System.Drawing.Size(183, 60);
            this.buttonOpenPicture.TabIndex = 1;
            this.buttonOpenPicture.Text = "Выбрать картинку";
            this.buttonOpenPicture.UseVisualStyleBackColor = true;
            this.buttonOpenPicture.Click += new System.EventHandler(this.buttonOpenPicture_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileName.Location = new System.Drawing.Point(1000, 93);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(179, 20);
            this.textBoxFileName.TabIndex = 2;
            // 
            // checkBoxGray
            // 
            this.checkBoxGray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxGray.AutoSize = true;
            this.checkBoxGray.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxGray.Location = new System.Drawing.Point(1000, 119);
            this.checkBoxGray.Name = "checkBoxGray";
            this.checkBoxGray.Size = new System.Drawing.Size(144, 23);
            this.checkBoxGray.TabIndex = 3;
            this.checkBoxGray.Text = "Оттенки серого";
            this.checkBoxGray.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(997, 462);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(183, 59);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Изменить картинку";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarBrightness.LargeChange = 10;
            this.trackBarBrightness.Location = new System.Drawing.Point(996, 179);
            this.trackBarBrightness.Maximum = 50;
            this.trackBarBrightness.Minimum = -50;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(183, 45);
            this.trackBarBrightness.TabIndex = 5;
            this.trackBarBrightness.TickFrequency = 10;
            this.trackBarBrightness.ValueChanged += new System.EventHandler(this.trackBarBrightness_ValueChanged);
            // 
            // labelBrightness
            // 
            this.labelBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBrightness.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrightness.Location = new System.Drawing.Point(996, 153);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(183, 23);
            this.labelBrightness.TabIndex = 6;
            this.labelBrightness.Text = "Яркость:";
            // 
            // labelContrast
            // 
            this.labelContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContrast.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContrast.Location = new System.Drawing.Point(997, 227);
            this.labelContrast.Name = "labelContrast";
            this.labelContrast.Size = new System.Drawing.Size(183, 23);
            this.labelContrast.TabIndex = 8;
            this.labelContrast.Text = "Контрасность:";
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarContrast.LargeChange = 10;
            this.trackBarContrast.Location = new System.Drawing.Point(997, 253);
            this.trackBarContrast.Maximum = 50;
            this.trackBarContrast.Minimum = -50;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(183, 45);
            this.trackBarContrast.TabIndex = 7;
            this.trackBarContrast.TickFrequency = 10;
            this.trackBarContrast.ValueChanged += new System.EventHandler(this.trackBarContrast_ValueChanged);
            // 
            // comboBoxCorrection
            // 
            this.comboBoxCorrection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCorrection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCorrection.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCorrection.FormattingEnabled = true;
            this.comboBoxCorrection.Items.AddRange(new object[] {
            "Линейная коррекция",
            "Синусоидальная",
            "Экспоненциальная",
            "Логарифмическая"});
            this.comboBoxCorrection.Location = new System.Drawing.Point(997, 304);
            this.comboBoxCorrection.Name = "comboBoxCorrection";
            this.comboBoxCorrection.Size = new System.Drawing.Size(182, 27);
            this.comboBoxCorrection.TabIndex = 9;
            // 
            // labelGamma
            // 
            this.labelGamma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGamma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGamma.Location = new System.Drawing.Point(996, 348);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(193, 23);
            this.labelGamma.TabIndex = 11;
            this.labelGamma.Text = "Гамма-коррекция:";
            // 
            // trackBarGamma
            // 
            this.trackBarGamma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGamma.LargeChange = 10;
            this.trackBarGamma.Location = new System.Drawing.Point(997, 374);
            this.trackBarGamma.Maximum = 190;
            this.trackBarGamma.Minimum = 10;
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.Size = new System.Drawing.Size(183, 45);
            this.trackBarGamma.TabIndex = 10;
            this.trackBarGamma.TickFrequency = 10;
            this.trackBarGamma.Value = 10;
            this.trackBarGamma.Scroll += new System.EventHandler(this.trackBarGamma_Scroll);
            this.trackBarGamma.ValueChanged += new System.EventHandler(this.trackBarGamma_ValueChanged);
            // 
            // PhotoSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 533);
            this.Controls.Add(this.labelGamma);
            this.Controls.Add(this.trackBarGamma);
            this.Controls.Add(this.comboBoxCorrection);
            this.Controls.Add(this.labelContrast);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkBoxGray);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonOpenPicture);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhotoSharp";
            this.Text = "PhotoSharp";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button buttonOpenPicture;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.CheckBox checkBoxGray;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.Label labelContrast;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.ComboBox comboBoxCorrection;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.TrackBar trackBarGamma;
    }
}

