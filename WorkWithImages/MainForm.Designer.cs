/*
 * Created by SharpDevelop.
 * User: B3
 * Date: 10.02.2021
 * Time: 20:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WorkWithImages
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(65, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(230, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "From";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "To";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(65, 33);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(230, 20);
			this.textBox2.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 91);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Image to Txt";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(13, 62);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(199, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Image to MiniImage";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(14, 234);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Process 1:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(78, 227);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(544, 23);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 8;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(218, 62);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(199, 23);
			this.button3.TabIndex = 10;
			this.button3.Text = "From - To";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(218, 91);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(199, 23);
			this.button4.TabIndex = 11;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(13, 121);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(404, 23);
			this.button5.TabIndex = 12;
			this.button5.Text = "Goo";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 262);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "WorkWithImages";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
