using System;
using System.Windows.Forms;

namespace Romanian_Radio_Player
{
    public partial class baseForm : Form
    {
        private string lastRadioPlayed;
        private System.Timers.Timer aTimer = new System.Timers.Timer();

        public baseForm()
        {
            InitializeComponent();
            labelVolumeValue.Text = trackBarVolume.Value.ToString();
            labelRadioPlaying.Text = "Not started yet";
        }

        private void buttonRadioZu_MouseClick(object sender, MouseEventArgs e)
        {
            axWMP.URL = "https://live7digi.antenaplay.ro/radiozu/radiozu-48000.m3u8";

            if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying || axWMP.playState == WMPLib.WMPPlayState.wmppsTransitioning)
            {
                labelRadioPlaying.Text = buttonRadioZu.Text;
                this.Text = "Romanian Radio Player - Playing " + buttonRadioZu.Text;
            }
        }

        private void buttonEuropaFM_MouseClick(object sender, MouseEventArgs e)
        {
            axWMP.URL = "https://astreaming.edi.ro:8443/EuropaFM_aac";

            if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying || axWMP.playState == WMPLib.WMPPlayState.wmppsTransitioning)
            {
                labelRadioPlaying.Text = buttonEuropaFM.Text;
                this.Text = "Romanian Radio Player - Playing " + buttonEuropaFM.Text;
            }
        }

        private void buttonKissFM_MouseClick(object sender, MouseEventArgs e)
        {
            axWMP.URL = "https://live.kissfm.ro:8443/kissfm.aacp";

            if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying || axWMP.playState == WMPLib.WMPPlayState.wmppsTransitioning) { 
                labelRadioPlaying.Text = buttonKissFM.Text;
                this.Text = "Romanian Radio Player - Playing " + buttonKissFM.Text;
            }
        }

        private void buttonDigi_MouseClick(object sender, MouseEventArgs e)
        {
            axWMP.URL = "http://edge76.rdsnet.ro:84/digifm/digifm.mp3";

            if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying || axWMP.playState == WMPLib.WMPPlayState.wmppsTransitioning)
            {
                labelRadioPlaying.Text = buttonDigi.Text;
                this.Text = "Romanian Radio Player - Playing " + buttonDigi.Text;
            }
        }

        private void buttonWMPPause_MouseClick(object sender, MouseEventArgs e)
        {
            if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                buttonWMPPause.Text = "Play";
                axWMP.Ctlcontrols.pause();

                lastRadioPlayed = labelRadioPlaying.Text;
                labelRadioPlaying.Text = "Paused";
                this.Text = "Romanian Radio Player - " + labelRadioPlaying.Text;
            }
            else if (axWMP.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                buttonWMPPause.Text = "Pause";
                axWMP.Ctlcontrols.play();

                labelRadioPlaying.Text = lastRadioPlayed;
                this.Text = "Romanian Radio Player - Playing " + labelRadioPlaying.Text;
            }
        }

        private void buttonWMPStop_MouseClick(object sender, MouseEventArgs e)
        {
            if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying || axWMP.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWMP.Ctlcontrols.stop();

                lastRadioPlayed = labelRadioPlaying.Text;
                labelRadioPlaying.Text = "Stopped";
                this.Text = "Romanian Radio Player - " + labelRadioPlaying.Text;
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            if (axWMP != null && trackBarVolume != null)
            {
                axWMP.settings.volume = trackBarVolume.Value;
                labelVolumeValue.Text = trackBarVolume.Value.ToString();
            }
        }
    }
}
