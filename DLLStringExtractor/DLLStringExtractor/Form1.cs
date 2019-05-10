using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace FolderBrowserDialogSampleInCSharp
{
   
    public partial class Form1 : Form
    {
        OpenFileDialog fileDlg;
        OpenFileDialog fileDlgDict;
        OpenFileDialog fileDlg2;
       string a;
        FileInfo[] Files;
        FileInfo[] Files2;
        FolderBrowserDialog folderBrowserDialog3save = new FolderBrowserDialog();
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        string strCmdText, DstrCmdText;
        string dict;

        //startInfo.FileName = "cmd.exe";
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseFolderButton_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
           
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryInfo d = new DirectoryInfo(folderDlg.SelectedPath);
                FileInfo[] Files = d.GetFiles("*.dll"); 
                foreach (FileInfo filen in Files)
                {
                    textBox2.AppendText(filen.ToString());
                    textBox2.AppendText("\r\n");
                }
                 Environment.SpecialFolder root = folderDlg.RootFolder;
                Files2= Files;
            }

        }
        

        public void openFileDialog1_FileOk(object sender, EventArgs e)
        {
            textBox2.Clear();
           OpenFileDialog fileDlg = new OpenFileDialog();          
           
            fileDlg.Multiselect = true;
            DialogResult result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (String file in fileDlg.SafeFileNames)
                { 
                    textBox2.AppendText(file);
                    textBox2.AppendText("\r\n");
                }
               
            }
            fileDlg2 = fileDlg;
        }

        private void GenStrings_click(object sender,EventArgs e)
        {
            if (fileDlg2 != null)
            {
                foreach (string lined in fileDlg2.FileNames)
                {
                    foreach (string line in lined.Split(new[] { '\n' }))
                    {
                        //string newline = line.Replace(@"\\", @"\");
                        
                   
                        //strCmdText = "/C" + " " + "strings" + " " + line + " " + ">" + line + ".txt";
                        //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                        // code for searching using dict file 
                        ProcessStartInfo startinfo = new ProcessStartInfo();
                        Process cmd = new Process();
                        //this is forst repo
                        if (dict != null)

                        { strCmdText = "/C" + " " + "strings" + " \"" + line + "\" " + "|" + " " + "findstr" + " " + "/G:" + "\"" + a + "\""; }
                        else if (dict == null)
                        { strCmdText = "/C" + " " + "strings" + " \"" + line + "\""; }
                        //strCmdText = "/C" +" "+"dir" +" " + fileDlg2.FileName.Replace(fileDlg2.SafeFileName,"") ;
                        cmd.StartInfo.WorkingDirectory = @"C:\Windows\System32";
                        cmd.StartInfo.FileName = "cmd.exe";
                        cmd.StartInfo.Arguments = strCmdText.ToString();
                        cmd.StartInfo.UseShellExecute = false;
                       cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        cmd.StartInfo.RedirectStandardOutput = true;
                        cmd.Start();
                        cmd.WaitForExit();
                        string output = cmd.StandardOutput.ReadToEnd();
                      string savefile= Directory.GetCurrentDirectory();
                        savefile += @"\";
                        string nonextsavefile= Path.GetFileNameWithoutExtension(line);
                        if (dict != null)

                        { savefile += nonextsavefile+"_Dictonary" + ".txt";  }
                        else if (dict == null)
                        { savefile += nonextsavefile + ".txt"; }
                        
                            File.WriteAllText(savefile, output);
                     
                        
                        

                    }
                }
            }
            else if(Files2!=null)
            {
                foreach (FileInfo filene in Files2)
                {
                    //old code

                    //strCmdText = "/C" + " " + "strings" + " \"" + filene.FullName.ToString() + "\" " + ">" + filene.FullName.ToString() +"__folder"+ ".txt";
                    //System.Diagnostics.Process.Start("CMD.exe", strCmdText);

                    ProcessStartInfo startinfo = new ProcessStartInfo();
                    Process cmd = new Process();
                    if (dict != null)
                    {
                        strCmdText = "/C" + " " + "strings" + " \"" + filene.FullName.ToString() + "\"" + "|" + " " + "findstr" + " " + "/G:" + "\"" + a + "\"";
                    }
                    else if (dict == null)
                    {
                        strCmdText = "/C" + " " + "strings" + " \"" + filene.FullName.ToString() + "\"";
                    }
                    cmd.StartInfo.WorkingDirectory = @"C:\Windows\System32";
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.Arguments = strCmdText.ToString();
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.Start();
                    cmd.WaitForExit();
                    string output = cmd.StandardOutput.ReadToEnd();
                    string savefile = Directory.GetCurrentDirectory();
                    savefile += @"\";
                    string nonextsavefile = Path.GetFileNameWithoutExtension(filene.ToString());
                    if (dict != null)

                    { savefile += nonextsavefile + "_Dictonary" + ".txt"; }
                    else if (dict == null)
                    { savefile += nonextsavefile + ".txt"; }
                    File.WriteAllText(savefile, output);


                }
            }

            else
            {
                MessageBox.Show("ERROR select any option");
            }

            dict = null;
        }

        private void explist_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog3save.ShowDialog() == DialogResult.OK)
            {
                // create a writer and open the file
               
                // write a line of text to the file
                File.WriteAllText(folderBrowserDialog3save.SelectedPath + "DLLnames.txt", textBox2.Text);
                
                // close the stream
                
               // MessageBox.Show("Saved to " + folderBrowserDialog3save.SelectedPath + "\\logfile.txt", "Saved Log File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Dict_Click(object sender, EventArgs e)
        {
             dict="inid";
            
            //textBox2.Clear();
            OpenFileDialog fileDlgDict = new OpenFileDialog();
            DialogResult result = fileDlgDict.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                     a = fileDlgDict.FileName;
                a.Replace(@"\\", @"\");
                dict = "Yes";
               // a.ToString();
                

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
