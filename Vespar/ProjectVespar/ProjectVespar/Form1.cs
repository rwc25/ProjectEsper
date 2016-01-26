using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vocola;
using System.Speech.Recognition;

namespace ProjectVespar
{
    public partial class vespar : Form
    {

        SpeechRecognitionEngine pushTalk = new SpeechRecognitionEngine();
        bool pushed = true;

        public vespar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices inputCommands = new Choices();
            inputCommands.Add(new string[] {"Hello Vespar", "Print my name" });
            GrammarBuilder interpret = new GrammarBuilder();
            interpret.Append(inputCommands);
            Grammar grammer = new Grammar(interpret);

            pushTalk.LoadGrammarAsync(grammer);
            pushTalk.SetInputToDefaultAudioDevice();
            pushTalk.SpeechRecognized += recEngine_SpeechRecongnized;

        }

        private void enable_Click(object sender, EventArgs e)
        {
            pushTalk.RecognizeAsync(RecognizeMode.Multiple);
            enable.Enabled = true;
        }

        void recEngine_SpeechRecongnized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "say Hello":
                    MessageBox.Show("Hello Johnny. How Are you?");
                    break;
                case "Print My Name":
                    richTextBox1.Text += "\n Oh~ Johnny";
                    break;

            }
        }
        
        private void disable_Click(object sender, EventArgs e)
        {
            pushTalk.RecognizeAsyncStop();
            disable.Enabled = false;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
