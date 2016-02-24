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
Mark Dela Rosa      2/10/16             Implementing a feature to input what user says into a string and send that string to a text file.
Mark Dela Rosa                          Adding a counter to how many times the user says a specific word or phrase.
Mark Dela Rosa      2/17/16             Removed the switch statements. Added a function to read a text file line by line. (Dictionary)
                                        Added a function to store user input and write it to a text file. (Data/Database)                               
*/


namespace Jarvis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //creates computer voice
        SpeechSynthesizer jSynth = new SpeechSynthesizer();
        //creates temp dictionary for computer voice to speak
        PromptBuilder jBuilder = new PromptBuilder();
        //creates speech recognition instance
        SpeechRecognitionEngine jRecognize = new SpeechRecognitionEngine();
        

        //n/a
        private void Form1_Load(object sender, EventArgs e)
        {

        } 
        //allows for computer to speak whatever is typed in the richtextbox
        private void button1_Click(object sender, EventArgs e)
        {
            jBuilder.ClearContent();
            jBuilder.AppendText(richTextBox1.Text);
            jSynth.Speak(jBuilder);
        }
        /*
        //testing ideas for a text file 
        //string[] commands = new string[];
        //eventually will be replaced with a database
        //StreamReader sR = new StreamReader(@"C:\Users\Batman\Desktop\projectvespar\test.txt");
        */

        //Dictionary via a text file
        //StreamReader sR = new StreamReader(@"C:\Users\Batman\Desktop\mydictionary.txt");
        StreamReader sR = new StreamReader(@"C:\Users\Batman\Documents\Visual Studio 2015\Projects\Jarvis\dictionary.txt");

        //start button 
        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            button3.Enabled = true;
            Choices jList = new Choices();
            string readTextLine = "";
            readTextLine = sR.ReadLine();
            string testing = "";
            while ((readTextLine = sR.ReadLine()) != null)
            {
                jList.Add(new string[] { readTextLine });
                testing += readTextLine;

            }
            
            //TEsting////////////////////////
            /*
            string readTextLine = "";
            readTextLine = sR.ReadLine();
            string testing = "";
            while ((readTextLine = sR.ReadLine()) != null)
            {
                jList.Add(new string[] { readTextLine });
                //enables for testing if commands are being read from file
                testing += readTextLine + "|";
            }
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
        
        //Where user input will be written to
        //StreamWriter sW = new StreamWriter(@"C:\Users\Batman\Desktop\projectvespar\writetome.txt", true);
        StreamWriter sW = new StreamWriter(@"C:\Users\Batman\Documents\Visual Studio 2015\Projects\Jarvis\writetome.txt", true);
        private void JRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            /*
            This will have to be configured later down the road but right now it does 
            its job of writing the user input into a text document based on the dictionary.
            */

            //this writes what the user says onto the GUI
            richTextBox1.AppendText(e.Result.Text.ToString());
            //this writes what the users says into a text document
            sW.WriteLine(e.Result.Text.ToString());            
            
            /*
            //these are test switch statements to see if the user input 
            //could be regulated based on test cases

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
            */
            
        }
        //Stop button
        private void button3_Click(object sender, EventArgs e)
        {
            jRecognize.RecognizeAsyncStop();
            button2.Enabled = true;
            button3.Enabled = false;
            sW.Close();
        }
    }
}
