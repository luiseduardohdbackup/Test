﻿// project created on 27/07/2003 at 22:36
using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace MyFormProject 
{
	class MainForm : System.Windows.Forms.Form
	{

		private System.Windows.Forms.Button button;
		private System.Windows.Forms.TextBox inputCode;
		private System.Windows.Forms.TextBox outputCode;

		public MainForm()
		{
			InitializeComponent();
		}

		// THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
		// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
		void InitializeComponent() {
			this.button = new System.Windows.Forms.Button();
			this.inputCode = new System.Windows.Forms.TextBox();
			this.outputCode = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button
			// 
			this.button.Dock = System.Windows.Forms.DockStyle.Top;
			this.button.Location = new System.Drawing.Point(0, 0);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(496, 24);
			this.button.TabIndex = 0;
			this.button.Text = "Convertir";
			this.button.Click += Click;
			// 
			// textBox
			// 
			this.inputCode.Location = new System.Drawing.Point(0, 25);
			this.inputCode.Name = "textBox";
			this.inputCode.Size = new System.Drawing.Size(300, 400);
			this.inputCode.TabIndex = 1;
			this.inputCode.Text = "";
			this.inputCode.Multiline = true;
			// 
			// textBox
			// 
			this.outputCode.Location = new System.Drawing.Point(300, 25);
			this.outputCode.Name = "textBox";
			this.outputCode.Size = new System.Drawing.Size(300, 400);
			this.outputCode.TabIndex = 1;
			this.outputCode.Text = "";
			this.outputCode.Multiline = true;
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
				this.button,
				this.inputCode,
				this.outputCode});
			this.Text = "ObjC2CSharp";
			this.ResumeLayout(false);
		}

		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}

		private void Click(object sender, EventArgs e) {
			//Console.WriteLine("Got doubleclick");

			const string message =
				"Are you sure that you would like to close the form?";
			const string caption = "Form Closing";
			var result = MessageBox.Show(message, caption,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
		}
	}			
}
