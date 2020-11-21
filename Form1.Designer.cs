
namespace Romanian_Radio_Player
{
    partial class baseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baseForm));
            this.labelRadioInfo = new System.Windows.Forms.Label();
            this.buttonRadioZu = new System.Windows.Forms.Button();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonEuropaFM = new System.Windows.Forms.Button();
            this.buttonKissFM = new System.Windows.Forms.Button();
            this.buttonDigi = new System.Windows.Forms.Button();
            this.groupBoxWMPControls = new System.Windows.Forms.GroupBox();
            this.buttonWMPStop = new System.Windows.Forms.Button();
            this.labelVolumeInfo = new System.Windows.Forms.Label();
            this.labelVolumeValue = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.buttonWMPPause = new System.Windows.Forms.Button();
            this.labelRadioCurrentInfo = new System.Windows.Forms.Label();
            this.labelRadioPlaying = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.groupBoxWMPControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRadioInfo
            // 
            this.labelRadioInfo.AutoSize = true;
            this.labelRadioInfo.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRadioInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRadioInfo.Location = new System.Drawing.Point(12, 40);
            this.labelRadioInfo.Name = "labelRadioInfo";
            this.labelRadioInfo.Size = new System.Drawing.Size(392, 22);
            this.labelRadioInfo.TabIndex = 0;
            this.labelRadioInfo.Text = "Please select one of the radio stations below";
            // 
            // buttonRadioZu
            // 
            this.buttonRadioZu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRadioZu.BackColor = System.Drawing.Color.DimGray;
            this.buttonRadioZu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRadioZu.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRadioZu.ForeColor = System.Drawing.Color.Black;
            this.buttonRadioZu.Location = new System.Drawing.Point(15, 115);
            this.buttonRadioZu.Name = "buttonRadioZu";
            this.buttonRadioZu.Size = new System.Drawing.Size(210, 40);
            this.buttonRadioZu.TabIndex = 1;
            this.buttonRadioZu.TabStop = false;
            this.buttonRadioZu.Text = "Radio ZU";
            this.buttonRadioZu.UseVisualStyleBackColor = true;
            this.buttonRadioZu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRadioZu_MouseClick);
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(1000, 529);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(10, 10);
            this.axWMP.TabIndex = 2;
            this.axWMP.Visible = false;
            // 
            // buttonEuropaFM
            // 
            this.buttonEuropaFM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEuropaFM.BackColor = System.Drawing.Color.DimGray;
            this.buttonEuropaFM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEuropaFM.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEuropaFM.ForeColor = System.Drawing.Color.Black;
            this.buttonEuropaFM.Location = new System.Drawing.Point(15, 215);
            this.buttonEuropaFM.Name = "buttonEuropaFM";
            this.buttonEuropaFM.Size = new System.Drawing.Size(210, 40);
            this.buttonEuropaFM.TabIndex = 3;
            this.buttonEuropaFM.TabStop = false;
            this.buttonEuropaFM.Text = "EuropaFM";
            this.buttonEuropaFM.UseVisualStyleBackColor = true;
            this.buttonEuropaFM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonEuropaFM_MouseClick);
            // 
            // buttonKissFM
            // 
            this.buttonKissFM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonKissFM.BackColor = System.Drawing.Color.DimGray;
            this.buttonKissFM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonKissFM.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKissFM.ForeColor = System.Drawing.Color.Black;
            this.buttonKissFM.Location = new System.Drawing.Point(15, 315);
            this.buttonKissFM.Name = "buttonKissFM";
            this.buttonKissFM.Size = new System.Drawing.Size(210, 40);
            this.buttonKissFM.TabIndex = 4;
            this.buttonKissFM.TabStop = false;
            this.buttonKissFM.Text = "KissFM";
            this.buttonKissFM.UseVisualStyleBackColor = true;
            this.buttonKissFM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonKissFM_MouseClick);
            // 
            // buttonDigi
            // 
            this.buttonDigi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDigi.BackColor = System.Drawing.Color.DimGray;
            this.buttonDigi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDigi.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDigi.ForeColor = System.Drawing.Color.Black;
            this.buttonDigi.Location = new System.Drawing.Point(15, 415);
            this.buttonDigi.Name = "buttonDigi";
            this.buttonDigi.Size = new System.Drawing.Size(210, 40);
            this.buttonDigi.TabIndex = 5;
            this.buttonDigi.TabStop = false;
            this.buttonDigi.Text = "Digi24";
            this.buttonDigi.UseVisualStyleBackColor = true;
            this.buttonDigi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDigi_MouseClick);
            // 
            // groupBoxWMPControls
            // 
            this.groupBoxWMPControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxWMPControls.Controls.Add(this.buttonWMPStop);
            this.groupBoxWMPControls.Controls.Add(this.labelVolumeInfo);
            this.groupBoxWMPControls.Controls.Add(this.labelVolumeValue);
            this.groupBoxWMPControls.Controls.Add(this.trackBarVolume);
            this.groupBoxWMPControls.Controls.Add(this.buttonWMPPause);
            this.groupBoxWMPControls.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWMPControls.Location = new System.Drawing.Point(657, 315);
            this.groupBoxWMPControls.Name = "groupBoxWMPControls";
            this.groupBoxWMPControls.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxWMPControls.Size = new System.Drawing.Size(300, 140);
            this.groupBoxWMPControls.TabIndex = 6;
            this.groupBoxWMPControls.TabStop = false;
            this.groupBoxWMPControls.Text = "Media Controls";
            // 
            // buttonWMPStop
            // 
            this.buttonWMPStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonWMPStop.BackColor = System.Drawing.Color.DimGray;
            this.buttonWMPStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonWMPStop.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWMPStop.ForeColor = System.Drawing.Color.Black;
            this.buttonWMPStop.Location = new System.Drawing.Point(154, 94);
            this.buttonWMPStop.Name = "buttonWMPStop";
            this.buttonWMPStop.Size = new System.Drawing.Size(140, 40);
            this.buttonWMPStop.TabIndex = 7;
            this.buttonWMPStop.TabStop = false;
            this.buttonWMPStop.Text = "Stop";
            this.buttonWMPStop.UseVisualStyleBackColor = true;
            this.buttonWMPStop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonWMPStop_MouseClick);
            // 
            // labelVolumeInfo
            // 
            this.labelVolumeInfo.AutoSize = true;
            this.labelVolumeInfo.Location = new System.Drawing.Point(90, 60);
            this.labelVolumeInfo.Name = "labelVolumeInfo";
            this.labelVolumeInfo.Size = new System.Drawing.Size(101, 15);
            this.labelVolumeInfo.TabIndex = 9;
            this.labelVolumeInfo.Text = ":Current Volume";
            // 
            // labelVolumeValue
            // 
            this.labelVolumeValue.AutoSize = true;
            this.labelVolumeValue.Location = new System.Drawing.Point(190, 60);
            this.labelVolumeValue.Name = "labelVolumeValue";
            this.labelVolumeValue.Size = new System.Drawing.Size(11, 15);
            this.labelVolumeValue.TabIndex = 8;
            this.labelVolumeValue.Text = ".";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(6, 22);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarVolume.Size = new System.Drawing.Size(288, 45);
            this.trackBarVolume.TabIndex = 7;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // buttonWMPPause
            // 
            this.buttonWMPPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonWMPPause.BackColor = System.Drawing.Color.DimGray;
            this.buttonWMPPause.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonWMPPause.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWMPPause.ForeColor = System.Drawing.Color.Black;
            this.buttonWMPPause.Location = new System.Drawing.Point(6, 94);
            this.buttonWMPPause.Name = "buttonWMPPause";
            this.buttonWMPPause.Size = new System.Drawing.Size(140, 40);
            this.buttonWMPPause.TabIndex = 6;
            this.buttonWMPPause.TabStop = false;
            this.buttonWMPPause.Text = "Pause";
            this.buttonWMPPause.UseVisualStyleBackColor = true;
            this.buttonWMPPause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonWMPPause_MouseClick);
            // 
            // labelRadioCurrentInfo
            // 
            this.labelRadioCurrentInfo.AutoSize = true;
            this.labelRadioCurrentInfo.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRadioCurrentInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRadioCurrentInfo.Location = new System.Drawing.Point(707, 68);
            this.labelRadioCurrentInfo.Name = "labelRadioCurrentInfo";
            this.labelRadioCurrentInfo.Size = new System.Drawing.Size(196, 22);
            this.labelRadioCurrentInfo.TabIndex = 7;
            this.labelRadioCurrentInfo.Text = "Current Radio Playing";
            // 
            // labelRadioPlaying
            // 
            this.labelRadioPlaying.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRadioPlaying.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRadioPlaying.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRadioPlaying.Location = new System.Drawing.Point(3, 16);
            this.labelRadioPlaying.Name = "labelRadioPlaying";
            this.labelRadioPlaying.Size = new System.Drawing.Size(186, 22);
            this.labelRadioPlaying.TabIndex = 8;
            this.labelRadioPlaying.Text = ".";
            this.labelRadioPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelRadioPlaying);
            this.groupBox1.Location = new System.Drawing.Point(711, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 53);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1008, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelRadioCurrentInfo);
            this.Controls.Add(this.groupBoxWMPControls);
            this.Controls.Add(this.buttonDigi);
            this.Controls.Add(this.buttonKissFM);
            this.Controls.Add(this.buttonEuropaFM);
            this.Controls.Add(this.axWMP);
            this.Controls.Add(this.buttonRadioZu);
            this.Controls.Add(this.labelRadioInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "baseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Romanian Radio Player";
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.groupBoxWMPControls.ResumeLayout(false);
            this.groupBoxWMPControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRadioInfo;
        private System.Windows.Forms.Button buttonRadioZu;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Button buttonEuropaFM;
        private System.Windows.Forms.Button buttonKissFM;
        private System.Windows.Forms.Button buttonDigi;
        private System.Windows.Forms.GroupBox groupBoxWMPControls;
        private System.Windows.Forms.Button buttonWMPPause;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelVolumeValue;
        private System.Windows.Forms.Label labelVolumeInfo;
        private System.Windows.Forms.Button buttonWMPStop;
        private System.Windows.Forms.Label labelRadioCurrentInfo;
        private System.Windows.Forms.Label labelRadioPlaying;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

