using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Leaf.xNet;
using OpenQA.Selenium.IE;

namespace WindowsFormsApp1sd
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			Thread newThread = new Thread(PingIP);
			newThread.Start();

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void PingIP()
		{

			/*
			ChromeOptions proxy = new ChromeOptions();
			proxy.AddArguments("--proxy-server=" + textBox1.Text);
			IWebDriver driver1 = new ChromeDriver(proxy);
			driver1.Navigate().GoToUrl("https://www.twitch.tv/test");

			System.Threading.Thread.Sleep(10000);

			((IJavaScriptExecutor)driver1).ExecuteScript("window.open();");
			driver1.SwitchTo().Window(driver1.WindowHandles.Last());
			*/

			
			//foreach (var item in listBox1.Items)
			//{
				//var request2 = item.ToString();


					ChromeOptions proxy = new ChromeOptions();
					proxy.AddArguments("--proxy-server=" + textBox1.Text);
					IWebDriver driver1 = new ChromeDriver(proxy);
					driver1.Navigate().GoToUrl("https://www.twitch.tv/ChannelName");


		}

		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Text = File.ReadAllText(@"ro.txt").ToString();
			listBox1.Items.AddRange(listBox1.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None));
		}


	}
}
