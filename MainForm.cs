/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/18/2024
 * Time: 5:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace sirMergator
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
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			loadtext();
		}
		
		public string s = "Reclama la detergenti : Exte ora 16 si un sfert ";
		public int mode = 0;
		public int tcounter = 0;
		public void loadtext()
		{
			label1.Width = 400;
			label1.Text = s;
			
			
		}
		public void run()
		{
			int r = 0;
			int counter = 0 ;
			//while(r == 0 && counter<this.Width-label1.Width)
			//{
				counter+=1;
				if(mode==0) {toRight();}
				if(mode==1){toLeft();}
				if(counter==this.Width-label1.Width){counter=0;r=1;}
				//Thread.Sleep(1);
			//};
		}
		public void toRight()
		{
			if(mode==0){
			if(label1.Left<this.Width-label1.Width){
				label1.Left++;
			}
			else 
			{
				mode = 1;
			}
			}
			
			
		}
		
		public void toLeft()
		{
			if(mode==1){
			if(label1.Left>0){
				label1.Left--;
			}
			else 
			{
				mode = 0;
			}
			}
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			loadtext();
				
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			tcounter++;
			run();	
		}
		void Button2Click(object sender, EventArgs e)
		{
			mode=-2;
		}
		void Button3Click(object sender, EventArgs e)
		{
			mode=-1;
		}
		void Button5Click(object sender, EventArgs e)
		{
			mode=0;
		}
		void Button4Click(object sender, EventArgs e)
		{
			mode=-3;
		}
	}
}
