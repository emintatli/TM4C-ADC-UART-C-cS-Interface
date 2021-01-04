/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 16.12.2020
 * Time: 17:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Odev
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		string veri=string.Empty;
		int i;
		bool tik=false;

		
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
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			serialPort1.Write(textBox1.Text);
			serialPort1.Write(textBox2.Text);
			serialPort1.Write(textBox3.Text);
			serialPort1.Write(textBox4.Text);
			serialPort1.Write(textBox5.Text);
			serialPort1.Write(textBox6.Text);
			System.Threading.Thread.Sleep(1000);
			serialPort1.Write(textBox12.Text);
			serialPort1.Write(textBox11.Text);
			serialPort1.Write(textBox10.Text);
			serialPort1.Write(textBox9.Text);
			serialPort1.Write(textBox8.Text);
			serialPort1.Write(textBox7.Text);
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			serialPort1.Write("|");
			serialPort1.Write("|");
			serialPort1.Write("|");
			serialPort1.Write("|");
			serialPort1.Write("|");
			serialPort1.Write("|");
			serialPort1.Write("|");


            
			
			
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			try{
				serialPort1.Open();
			}
			catch {
{
				MessageBox.Show("Cihaz Bağlı Değil");
				Application.Exit();
				}
}
			
			if(serialPort1.PortName !=null){
			label2.Text=serialPort1.PortName.ToString();
			label3.Text=serialPort1.BaudRate.ToString();
			}
				
			
			
				
			
			
		}
		private void DisplayText(object sender,EventArgs e){
			
			
			if(String.Equals(veri[0].ToString(),"#") && veri.Length>1){
				label6.Text=veri.Replace("#", string.Empty);
				}
			else if (sayivarmi(veri)==true && veri.Length<10){
				label1.Text="ADC:"+Convert.ToDouble(veri)/1000.0+" Volt";
				label5.Text="ADC:"+veri;
			}
			
				
			
			
		
			
			
			
			
			
		
		}
		
		void DataGeldi(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			
			veri=serialPort1.ReadExisting();
			
	this.Invoke(new EventHandler(DisplayText));
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			
			if(tik==false){
				label1.Visible=false;
			label5.Visible=true;
			tik=true;
			}
			else if(tik==true){
				label5.Visible=false;
			label1.Visible=true;
			tik=false;
			}
			
			
		}
		void Button4Click(object sender, EventArgs e)
		{
	serialPort1.Close();
		}
		
		bool sayivarmi(string str)
{
    foreach (char c in str)
    {
        if (c < '0' || c > '9')
            return false;
    }

    return true;
}
		
		
		
	}
}
