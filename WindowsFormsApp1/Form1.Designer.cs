namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.changeText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.processName = new System.Windows.Forms.Label();
            this.cpuUsage = new System.Windows.Forms.Label();
            this.memUsage = new System.Windows.Forms.Label();
            this.processId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // changeText
            // 
            this.changeText.Location = new System.Drawing.Point(832, 322);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(90, 32);
            this.changeText.TabIndex = 1;
            this.changeText.Text = "Show All";
            this.changeText.UseVisualStyleBackColor = true;
            this.changeText.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(628, 324);
            this.listBox1.TabIndex = 4;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // processName
            // 
            this.processName.AutoSize = true;
            this.processName.Location = new System.Drawing.Point(659, 29);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(0, 17);
            this.processName.TabIndex = 5;
            // 
            // cpuUsage
            // 
            this.cpuUsage.AutoSize = true;
            this.cpuUsage.Location = new System.Drawing.Point(659, 85);
            this.cpuUsage.Name = "cpuUsage";
            this.cpuUsage.Size = new System.Drawing.Size(0, 17);
            this.cpuUsage.TabIndex = 6;
            // 
            // memUsage
            // 
            this.memUsage.AutoSize = true;
            this.memUsage.Location = new System.Drawing.Point(787, 85);
            this.memUsage.Name = "memUsage";
            this.memUsage.Size = new System.Drawing.Size(0, 17);
            this.memUsage.TabIndex = 8;
            // 
            // processId
            // 
            this.processId.AutoSize = true;
            this.processId.Location = new System.Drawing.Point(787, 29);
            this.processId.Name = "processId";
            this.processId.Size = new System.Drawing.Size(0, 17);
            this.processId.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(966, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Toggle All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ToggleAll_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Location = new System.Drawing.Point(775, 85);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(12, 17);
            this.errorMsg.TabIndex = 10;
            this.errorMsg.Text = " ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(662, 158);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 158);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(966, 322);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Autosave";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Autosave_Checkbox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 374);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.memUsage);
            this.Controls.Add(this.processId);
            this.Controls.Add(this.cpuUsage);
            this.Controls.Add(this.processName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label processName;
        private System.Windows.Forms.Label cpuUsage;
        private System.Windows.Forms.Label memUsage;
        private System.Windows.Forms.Label processId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

