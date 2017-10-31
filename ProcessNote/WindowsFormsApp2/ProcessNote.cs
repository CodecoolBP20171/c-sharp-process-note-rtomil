using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ProcessNote : Form
    {
        private Dictionary<int, string> commentContainer = new Dictionary<int, string>();
        private static Process[] runningProcesses;
        public ProcessNote()
        {
            InitializeComponent();
        }

        private void Neve_Click(object sender, EventArgs e)
        {

        }

        private void ListAll_click(object sender, EventArgs e)
        {


            runningProcesses = Process.GetProcesses();
            foreach (var process in runningProcesses)
            {
                //string line = process.Id, process.ProcessName
                string space = String.Concat(Enumerable.Repeat(" ", 30 - process.Id.ToString().Length));
                RunningProgressBox.Items.Add(process.Id.ToString() + space + process.ProcessName.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RunningProgressBox_Click(object sender, EventArgs e)
        {
            var process = RunningProgressBox.SelectedItem;
            var id = Int32.Parse(process.ToString().Split(' ')[0]);
            var name = process.ToString().Split(' ')[process.ToString().Split(' ').Length - 1];
            label1.Text = id.ToString();
            label2.Text = name;
            var currentProcess = Process.GetProcessById(id); ;
            try
            {
                label3.Text = currentProcess.TotalProcessorTime.ToString();
                label12.Text = currentProcess.StartTime.ToString();
            } catch (Win32Exception)
            {
                label3.Text = "A hozzáférés megtagadva";
                label12.Text = "A hozzáférés megtagadva";
            }
            if (commentContainer.ContainsKey(Int32.Parse(label1.Text)))
            {
                textBox1.Text = commentContainer[Int32.Parse(label1.Text)];
            }
            else
            {
                textBox1.Text = "";
            }
            label4.Text = currentProcess.PagedMemorySize64.ToString();
            label13.Text = currentProcess.Threads.ToString();
            //label14.Text = currentProcess.C
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Neve_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                try
                {
                    commentContainer.Add(Int32.Parse(label1.Text), textBox1.Text);
                }
                catch (ArgumentException)
                {
                    commentContainer[Int32.Parse(label1.Text)] += textBox1.Text;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
