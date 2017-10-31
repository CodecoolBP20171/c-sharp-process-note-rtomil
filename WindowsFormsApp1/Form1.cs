using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Process[] allProcess;
        private Process selected;
        private bool autosave;
        private Dictionary<int, string> comments;
        private bool isChanges;


        public Form1()
        {
            comments = new Dictionary<int, string>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            allProcess = Process.GetProcesses();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {

            if (!autosave && isChanges)
            {
                MessageBoxHandler(sender, e);
            }
            ResetEverything();
            selected = null;
            foreach (var item in allProcess)
            {
                this.listBox1.Items.Add(item.Id + ".             " + item.ProcessName);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            errorMsg.Text = " ";
            int id = Convert.ToInt32(listBox1.SelectedItem.ToString().Split('.')[0]);
            // try with array
            selected = Process.GetProcessById(id);
            LabelFiller();
        }

        private void LabelFiller( )
        {
            this.processName.Text = "Name: \n" + selected.ProcessName;
            this.processId.Text = "Id: \n" + selected.Id.ToString();
            try
            {
                textBox1.Text = comments[selected.Id];
            } catch(Exception e)
            {
                textBox1.Text = " ";
                Console.WriteLine(e);
            }
            ResetDetails();
        }

        private void ToggleAll_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            try
            {
                DetailedLabelFiller();
            }
            catch (Win32Exception)
            {
                errorMsg.Text = "Permission denied.";
            }
        }

        private void DetailedLabelFiller( )
        {
            this.cpuUsage.Text = "CPU usage: \n" + selected.TotalProcessorTime;
            this.memUsage.Text = "Memory usage: \n" + selected.WorkingSet64;
        }

        private void ResetDetails()
        {
            cpuUsage.Text = " ";
            memUsage.Text = " ";
        }

        private void ResetEverything()
        {
            this.button1.Enabled = true;
            this.listBox1.Items.Clear();
            selected = null;
            processName.Text = "";
            processId.Text = " ";
            ResetDetails();
            errorMsg.Text = " ";
        }
        
        public void SaveChanges(object sender, EventArgs e)
        {
            if (comments.ContainsKey(selected.Id)){
                comments[selected.Id] = textBox1.Text;
            } else
            {
                comments.Add(selected.Id, textBox1.Text);
            }
        }

        private void Autosave_Checkbox(object sender, EventArgs e)
        {
            autosave = !autosave;
            if (autosave)
            {
                textBox1.TextChanged += SaveChanges;
                SaveChanges(sender, e);
            } else
            {
                textBox1.TextChanged += null;
            }
        }

        private void MessageBoxHandler(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("There are unsaved changes.\nDo you want to save?", "Achtung!!!", MessageBoxButtons.YesNo);
            if (msgBox == DialogResult.Yes)
            {
                SaveChanges(sender, e);
                isChanges = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(" "))
            {
                isChanges = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
