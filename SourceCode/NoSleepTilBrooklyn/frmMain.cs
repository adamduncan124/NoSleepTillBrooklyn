using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace NoSleepTilBrooklyn
{
    public partial class frmMain : Form
    {
        private const string MusicRelativePath = "music\\NoSleep.wav";

        /*private int minX => 10;
        private int minY => 10;
        private int maxX => 300;
        private int maxY => 300;
        private int jump => 15;*/
        private int? curX { get; set; }

        private int? curY { get; set; }
        private int maxCount => 50;
        private int count { get; set; } = 0;
        private bool stopLoop { get; set; } = true;
        private SoundPlayer PlayAudio { get; set; }
        private bool isPlaying { get; set; } = false;


        public frmMain()
        {
            InitializeComponent();
            btnAction.Text = "Start Trip";
            lblMessage.Text = "Click the Button to Begin the Trip.";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (stopLoop)
            {
                btnAction.Text = "Stop And Sleep";
                StartMouseLocation();
            }
            else
            {
                lblMessage.Text = "";
                btnAction.Text = "Start Trip";
                StopMouseLocation();
            }
        }

        private void StartMouseLocation()
        {
            stopLoop = false;
            LoopMouseLocation();
        }

        private void StopMouseLocation()
        {
            stopLoop = true;
        }

        private void LoopMouseLocation()
        {
            if (stopLoop)
            {
                lblMessage.Text = "You're Awake!!!";
                StopMusic();
                return;
            }

            Application.DoEvents();
            Thread.Sleep(1000);
            Application.DoEvents();

            TestMouseAndMove();
            LoopMouseLocation(); //call self
            Application.DoEvents();
        }

        private void TestMouseAndMove()
        {
            if (stopLoop)
            {
                count = 0; //reset
                return;
            }

            count++;

            //set variables if null
            if ((curX == null) && (curY == null))
            {
                curX = Cursor.Position.X;
                curY = Cursor.Position.Y;
            }

            //first test mouse position is same            
            if ((curX != Cursor.Position.X) || (curY != Cursor.Position.Y))
            {
                count = 0; //reset
                curX = Cursor.Position.X;
                curY = Cursor.Position.Y;
                lblMessage.Text = "Mouse Moved!";
                StopMusic();
                return;
            }

            if (!isPlaying) PlayMusic();

            lblMessage.Text = $"Key Press for No Sleep In {maxCount - count} seconds";

            //next test count
            if (count >= maxCount)
            {
                F15Press();
                count = 0; //reset
            }
        }

        private void F15Press()
        {
            SendKeys.Send("{F15}");
        }

        /*private void MoveMouseNextSpot()
        {
            //reset if needed
            curX = (curX >= maxX) ? minX : 
                ((curX < minX) ? minX : curX);
            curY = (curY >= maxY) ? minY :
                ((curY < minY) ? minY : curY);

            //now jump!
            curX = curX + jump;
            curY = curY + jump;

            if((curX != null) && (curY != null))
                Cursor.Position = new Point((int) curX, (int) curY);
        }*/

        private void StopMusic()
        {
            PlayAudio?.Stop();
            isPlaying = false;
        }

        private void PlayMusic()
        {
            var musicFile = $"{Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)}\\{MusicRelativePath}";

            if (!chkPlayMusic.Checked || !File.Exists(musicFile)) return;

            if (PlayAudio == null)
                PlayAudio = new SoundPlayer();

            PlayAudio.SoundLocation = musicFile;
            PlayAudio.Play();
            isPlaying = true;
        }
    }
}
