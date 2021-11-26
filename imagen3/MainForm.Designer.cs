/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 26/11/2021
 * Time: 16:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace imagen3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pic_grande;
		private System.Windows.Forms.PictureBox pic1;
		private System.Windows.Forms.PictureBox pic2;
		private System.Windows.Forms.PictureBox pic3;
		private System.Windows.Forms.PictureBox pic4;
		private System.Windows.Forms.PictureBox pic5;
		
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
			this.pic_grande = new System.Windows.Forms.PictureBox();
			this.pic1 = new System.Windows.Forms.PictureBox();
			this.pic2 = new System.Windows.Forms.PictureBox();
			this.pic3 = new System.Windows.Forms.PictureBox();
			this.pic4 = new System.Windows.Forms.PictureBox();
			this.pic5 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_grande)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_grande
			// 
			this.pic_grande.Location = new System.Drawing.Point(74, 56);
			this.pic_grande.Name = "pic_grande";
			this.pic_grande.Size = new System.Drawing.Size(211, 170);
			this.pic_grande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_grande.TabIndex = 0;
			this.pic_grande.TabStop = false;
			// 
			// pic1
			// 
			this.pic1.Location = new System.Drawing.Point(424, 4);
			this.pic1.Name = "pic1";
			this.pic1.Size = new System.Drawing.Size(64, 52);
			this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic1.TabIndex = 1;
			this.pic1.TabStop = false;
			this.pic1.Click += new System.EventHandler(this.Pic_grandeClick);
			// 
			// pic2
			// 
			this.pic2.Location = new System.Drawing.Point(424, 62);
			this.pic2.Name = "pic2";
			this.pic2.Size = new System.Drawing.Size(64, 52);
			this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic2.TabIndex = 2;
			this.pic2.TabStop = false;
			this.pic2.Click += new System.EventHandler(this.Pic_grandeClick);
			// 
			// pic3
			// 
			this.pic3.Location = new System.Drawing.Point(424, 120);
			this.pic3.Name = "pic3";
			this.pic3.Size = new System.Drawing.Size(64, 52);
			this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic3.TabIndex = 3;
			this.pic3.TabStop = false;
			this.pic3.Click += new System.EventHandler(this.Pic_grandeClick);
			// 
			// pic4
			// 
			this.pic4.Location = new System.Drawing.Point(424, 178);
			this.pic4.Name = "pic4";
			this.pic4.Size = new System.Drawing.Size(64, 52);
			this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic4.TabIndex = 4;
			this.pic4.TabStop = false;
			this.pic4.Click += new System.EventHandler(this.Pic_grandeClick);
			// 
			// pic5
			// 
			this.pic5.Location = new System.Drawing.Point(424, 236);
			this.pic5.Name = "pic5";
			this.pic5.Size = new System.Drawing.Size(64, 52);
			this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic5.TabIndex = 5;
			this.pic5.TabStop = false;
			this.pic5.Click += new System.EventHandler(this.Pic_grandeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 298);
			this.Controls.Add(this.pic5);
			this.Controls.Add(this.pic4);
			this.Controls.Add(this.pic3);
			this.Controls.Add(this.pic2);
			this.Controls.Add(this.pic1);
			this.Controls.Add(this.pic_grande);
			this.Name = "MainForm";
			this.Text = "imagen3";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_grande)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
