﻿/*
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
			textBox1.Text = @"C:\Users\User\Desktop\f3\f3_page-0001.jpg";
			textBox2.Text = @"C:\Users\User\Desktop\Folder\miniImage.jpg";
			
			button4.Enabled = false;
			
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
			
			progressBar1.Value = 0;
			MessageBox.Show("Progerss' end...");
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
		
		void Button3Click(object sender, EventArgs e)
		{
			Bitmap p1, p2, final;
			p1 = new Bitmap(textBox1.Text);
			p2 = new Bitmap(textBox2.Text);
			List<Color> colors = new List<Color>();
			colors.Add(Color.White);
			bool _add = true;
			
			for(int i = 0; i < p1.Width; ++i){
				_add = true;
				for(int j = 0; j < p2.Width; ++j){
					if(p2.GetPixel(j, 0) == p1.GetPixel(i, 0)){
						_add = false;
						j = p2.Width;
					}
				}
				if(_add){
					colors.Add(p1.GetPixel(i, 0));
				}
			}
			
			final = new Bitmap(colors.Count, 1);
			for(int i = 0; i < colors.Count; ++i){
				final.SetPixel(i, 0, colors[i]);
			}
			
			final.Save(@"C:\Users\User\Desktop\f3\final.jpg");
			
		}
		
		static bool[] end = new bool[5]{false, false, false, false, false};
		
		void Button4Click(object sender, EventArgs e)
		{
			Bitmap p1 = new Bitmap(textBox1.Text + sender.ToString() + ".jpg");
			Bitmap p2 = new Bitmap(textBox2.Text);
			List<List<Color>> pic1 = new List<List<Color>>();
			List<Color> pic2 = new List<Color>();
			progressBar1.Maximum = p1.Height;
						
			label4.Text = "Proc: " + sender.ToString();
			
			for(int _i = 0; _i < p1.Height; ++_i){
				for(int j = 0; j < p1.Width; ++j){
					pic2.Add(p1.GetPixel(j, _i));
				}
				pic1.Add(pic2);
				pic2 = new List<Color>();
				progressBar1.Value = _i + 1;
			}
			
			for(int _i = 0; _i < p2.Width; ++_i){
				pic2.Add(p2.GetPixel(_i, 0));
			}
			
			progressBar1.Value = 0;
			progressBar1.Maximum = p1.Height;
			
			object[] obj;
			
			for(int i = 0; i < 5; ++i){
				obj =  new object[7]{0, (pic1.Count/5)*i, pic1[0].Count, (pic1.Count/5)*(i + 1), pic1, pic2, i};
				deletePart(ref obj, ref p1);
			}
			
			progressBar1.Value = 0;
			
			progressBar1.Value = 0;
			p1.Save(@"C:\Users\B3\Desktop\Qimia3\" + sender.ToString() + ".jpg");
		}
		
		void deletePart(ref object[] obj, ref Bitmap p){
			int st_x = Convert.ToInt32(obj[0]), st_y = Convert.ToInt32(obj[1]), en_x = Convert.ToInt32(obj[2]), en_y = Convert.ToInt32(obj[3]);
			
			List<List<Color>> lc = (List<List<Color>>) obj[4];
						
			for(int i = st_y; i < en_y; ++i){
				for(int j = st_x; j < en_x; ++j){
					progressBar1.Value = i + 1;
					
					if(lc[i][j] != Color.FromArgb(255, 255, 255, 255)){
						if(DelFromP1(lc[i][j], obj[5])){
							p.SetPixel(j, i, Color.White);
						}
					}
				}
			}
			
			end[(int)obj[6]] = true;
		}
		
		bool DelFromP1(Color lc, object obj){
			List<Color> l = (List<Color>) obj;			
			for(int k = 0; k < l.Count; ++k){
				if(lc == l[k]){
					return true;
				}
			}
			return false;
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			for(int i = 0; i < 189; ++i){
				Button4Click(i, null);
			}
		}
	}
}
