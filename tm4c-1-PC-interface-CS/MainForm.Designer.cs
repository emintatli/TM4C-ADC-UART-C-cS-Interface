/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 16.12.2020
 * Time: 17:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Odev
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button4;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(189, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 81);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(23, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox6);
			this.panel1.Controls.Add(this.textBox5);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(171, 36);
			this.panel1.TabIndex = 3;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(148, 6);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(23, 20);
			this.textBox6.TabIndex = 4;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(119, 6);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(23, 20);
			this.textBox5.TabIndex = 4;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(90, 6);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(23, 20);
			this.textBox4.TabIndex = 5;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(61, 6);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(23, 20);
			this.textBox3.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(30, 6);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(23, 20);
			this.textBox2.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1, 245);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(286, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Temizle";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.textBox7);
			this.panel5.Controls.Add(this.textBox8);
			this.panel5.Controls.Add(this.textBox9);
			this.panel5.Controls.Add(this.textBox10);
			this.panel5.Controls.Add(this.textBox11);
			this.panel5.Controls.Add(this.textBox12);
			this.panel5.Location = new System.Drawing.Point(10, 54);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(173, 36);
			this.panel5.TabIndex = 6;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(148, 6);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(23, 20);
			this.textBox7.TabIndex = 4;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(119, 6);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(23, 20);
			this.textBox8.TabIndex = 4;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(90, 6);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(23, 20);
			this.textBox9.TabIndex = 5;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(61, 6);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(23, 20);
			this.textBox10.TabIndex = 4;
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(32, 6);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(23, 20);
			this.textBox11.TabIndex = 3;
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(3, 6);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(23, 20);
			this.textBox12.TabIndex = 2;
			// 
			// serialPort1
			// 
			this.serialPort1.BaudRate = 115200;
			this.serialPort1.PortName = "COM3";
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataGeldi);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 271);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "???";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 284);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "???";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(160, 294);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Muhammed Emin TATLI";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(286, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "0000";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(1, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(286, 34);
			this.label5.TabIndex = 10;
			this.label5.Text = "0000";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label5.Visible = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1, 216);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(286, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "Değiştir";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(1, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(286, 34);
			this.label6.TabIndex = 12;
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button4
			// 
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(189, 88);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(89, 30);
			this.button4.TabIndex = 13;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 313);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MainForm";
			this.Text = "Odev";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
