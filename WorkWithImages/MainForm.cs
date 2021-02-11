/*
 * Created by SharpDevelop.
 * User: B3
 * Date: 10.02.2021
 * Time: 20:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace WorkWithImages
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			textBox1.Text = @"C:\Users\User\Desktop\Folder\0.jpg";
			textBox2.Text = @"C:\Users\User\Desktop\Folder\miniImage.jpg";
			textBox1.Enabled = textBox2.Enabled = button1.Enabled = false;
			//button2.Enabled = false;
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//get all colors from Image and write them into txt
			Bitmap p = new Bitmap(textBox1.Text);
//			List<List<int>> list = new List<List<int>>();
//			List<int> ll = new List<int>();
			List<Color> colors = new List<Color>();
			
			for(int i = 0; i < p.Height; ++i){
				for(int j = 0; j < p.Width; ++j){
					IsColorFromArrayElseAddIt(ref colors, p.GetPixel(j, i));
				}
			}
			
			colors.Sort(SortByR);
			
			System.IO.StreamWriter sw = new System.IO.StreamWriter(textBox2.Text, false);
			
			for(int i = 0; i < colors.Count; ++i){
				sw.WriteLine(colors[i].A + " " + colors[i].R + " " + colors[i].G + " " + colors[i].B);
			}
			sw.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Bitmap p = new Bitmap(textBox1.Text);
			Bitmap p2;
			List<Color> colors = new List<Color>();
			progressBar1.Maximum = p.Height;
			progressBar2.Maximum = p.Width;
			
			for(int i = 0; i < p.Height; ++i){
				progressBar1.Value = i + 1;
				for(int j = 0; j < p.Width; ++j){
					IsColorFromArrayElseAddIt(ref colors, p.GetPixel(j, i));
				}
			}
			
			colors.Sort(SortByB);
			colors.Sort(SortByG);
			colors.Sort(SortByR);
			
			
			
			p2 = new Bitmap(colors.Count, 1);
			for(int i = 0; i < colors.Count; ++i){
				p2.SetPixel(i, 0, colors[i]);
			}
			
			p2.Save(textBox2.Text);
		}
		
		bool IsColorFromArrayElseAddIt(ref List<Color> list, Color item){		
			for(int i = 0; i < list.Count; ++i){
				if(list[i] == item){
					return true;
				}
			}
			
			list.Add(item);
			return false;
		}
		
		public int SortByR(Color a, Color b)
	    {
	        if (a.R < b.R)
	            return 1;
	        else if (a.R == b.R)
	            return 0;
	        else 
	            return -1;
	    }
		
		public int SortByB(Color a, Color b)
	    {
	        if (a.B < b.B)
	            return 1;
	        else if (a.B == b.B)
	            return 0;
	        else 
	            return -1;
	    }
		
		public int SortByG(Color a, Color b)
	    {
	        if (a.G < b.G)
	            return 1;
	        else if (a.G == b.G)
	            return 0;
	        else 
	            return -1;
	    }
	}
}
