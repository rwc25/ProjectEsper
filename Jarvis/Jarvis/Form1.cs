using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.IO;

/*
Author              Date                Description
Mark Dela Rosa      1/10/16 - 1/15/16   Pseudocode for start of project
                    2/10/16             Implementing a feature to input what user says into a string and send that string to a text file.
                                        Adding a counter to how many times the user says a specific word or phrase.
*/


namespace Jarvis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpeechSynthesizer jSynth = new SpeechSynthesizer();
        PromptBuilder jBuilder = new PromptBuilder();
        SpeechRecognitionEngine jRecognize = new SpeechRecognitionEngine();
        


        private void Form1_Load(object sender, EventArgs e)
        {

        } 
        private void button1_Click(object sender, EventArgs e)
        {
            jBuilder.ClearContent();
            jBuilder.AppendText(richTextBox1.Text);
            jSynth.Speak(jBuilder);
        }

        //testing reading file 
        //string[] commands = new string[];
        //eventually will be replaced with a database
        StreamReader sR = new StreamReader(@"C:\Users\Batman\Desktop\projectvespar\test.txt");
        // ///////////////////////



        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            button3.Enabled = true;
            Choices jList = new Choices();
            //TEsting////////////////////////
            /*string readTextLine = "";
            readTextLine = sR.ReadLine();
            string testing = "";
            while ((readTextLine = sR.ReadLine()) != null)
            {
                jList.Add(new string[] { readTextLine });
                //enables for testing if commands are being read from file
                testing += readTextLine + "|";
            }
            */

            /*
            // Make code from user input to -> store what they say and write it to a text file
            ///////////////////////////////
            */
            jList.Add(new string[] { "open window", "close window", "change to woman", "change to man", "testing" });
            Grammar gr = new Grammar(new GrammarBuilder(jList));
            
            while (button2.Enabled == false)
            {
                try
                {
                    jRecognize.RequestRecognizerUpdate();
                    jRecognize.LoadGrammar(gr);
                    jRecognize.SpeechRecognized += JRecognize_SpeechRecognized;
                    jRecognize.SetInputToDefaultAudioDevice();
                    jRecognize.RecognizeAsync(RecognizeMode.Multiple);
                    //testing to see if it reads text file and commands are there
                    MessageBox.Show("*Test* Commands Available" + "open window | close window | change to woman | change to man | testing");


                }
                catch
                {
                    return;
                }

            }
           
        }

      
        StreamWriter sW = new StreamWriter(@"C:\Users\Batman\Desktop\projectvespar\writetome.txt", true);
        private void JRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            /*
            Test 2/10/16
            
                    
            string fileName = @"C:\Users\Batman\Desktop\projectvespar\writefile.txt"
            
            StreamWriter sW = new StreamWriter(fileName, true);
            sW.WriteLine(e.Result.Text);
            
            
            
             do
            {
                if (e.Result.Text != "finish" && e.Result.Text != "") 
                {
                    sW.WriteLine(e.Result.Text);
                }
            } while (e.Result.Text != "finish");
                sW.Close();
            
            
            */


            //probably will replace with another file e.Result.Text will be replaced
            //with an array or database similar to one above
            switch (e.Result.Text)
            {
                case ("exit"):
                    Application.Exit();                    
                    break;
                case ("open window"):
                    jSynth.Speak("Opening Window");
                    sW.Write(e.Result.Text.ToString() + "|" );
                    break;
                case ("close window"):
                    jSynth.Speak("Closing Window");
                    sW.Write(" " + e.Result.Text.ToString() + "|");
                    
                    break;
                case ("change to woman"):
                    jSynth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                    sW.Write(" " + e.Result.Text.ToString() + "|");
                    
                    jSynth.Speak("If you say so");
                    break;
                case ("change to man"):
                    jSynth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);
                    sW.Write(" " + e.Result.Text.ToString() + "|");
                    
                    jSynth.Speak("If you say so");
                    break;
                case ("testing"):                    
                    jSynth.Speak("The test was successful");
                    sW.Write(" " + e.Result.Text.ToString() + "|");
                    
                    break;

            }
            /*
            if (e.Result.Text == "exit")
            {
                Application.Exit();
            } else if(e.Result.Text == "")
            {
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + " " + e.Result.Text.ToString();
            }
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jRecognize.RecognizeAsyncStop();
            button2.Enabled = true;
            button3.Enabled = false;
            sW.Close();
        }
    }
}
