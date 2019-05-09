using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileHandlingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriteToFile(false);
        }

        private void WriteToFile(bool append)
        {
            try
            {
                //This line will get the file path for the debug folder
                string filePath = Application.StartupPath + @"\\data.txt";
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(filePath, append);

                //Write a line of text
                sw.Write(rtbWrite.Text);
                sw.Write("\n");

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            //Implement Append
        }

        private void btnRread_Click(object sender, EventArgs e)
        {
            rtbRead.Text = string.Empty;
            ReadFile();
        }

        private void ReadFile()
        {
            string line;
            try
            {
                //This line will get the file path for the debug folder
                string filePath = Application.StartupPath + @"\\data.txt";

                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(filePath);

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    rtbRead.Text += line;
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
    }
 }
