using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

namespace SpeechTest
{
    public partial class Form1 : Form
    {
        private SpVoice Voice = new SpVoice();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Voice.GetVoices().Item(0).Id);
            Voice.Voice = Voice.GetVoices().Item(0);
            Voice.Speak("不知道為什麼，這是同時製作的", SpeechVoiceSpeakFlags.SVSFlagsAsync);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Voice.GetVoices().Item(1).Id);
            Voice.Voice = Voice.GetVoices().Item(1);
            Voice.Speak("不知道為什麼 這是同時製作的 但左黑又紅的那個不成功 我又再開一次COMPOSER 也不會重新製作", SpeechVoiceSpeakFlags.SVSFlagsAsync);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Voice.GetVoices().Item(2).Id);
            Voice.Voice = Voice.GetVoices().Item(2);
            Voice.Speak("不知道為什麼。這是同時製作的", SpeechVoiceSpeakFlags.SVSFlagsAsync);
        }
    }
}
