/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 26/11/2021
 * Time: 16:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace imagen3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{		
			string[] nombre_imagenes;
			string  ubicacion_imagenes;
			
		public MainForm()
		{
			
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			nombre_imagenes=new string[5];
			ubicacion_imagenes="C:\\Users\\PC\\Pictures\\";
			nombre_imagenes[0]=ubicacion_imagenes+"1.jpg";
			nombre_imagenes[1]=ubicacion_imagenes+"2.jpg";
			nombre_imagenes[2]=ubicacion_imagenes+"3.jpg";
			nombre_imagenes[3]=ubicacion_imagenes+"4.jpg";
			nombre_imagenes[4]=ubicacion_imagenes+"5.jpg";
			
			pic1.Image=Image.FromFile(nombre_imagenes[0]);
			pic2.Image=Image.FromFile(nombre_imagenes[1]);
			pic3.Image=Image.FromFile(nombre_imagenes[2]);
			pic4.Image=Image.FromFile(nombre_imagenes[3]);
			pic5.Image=Image.FromFile(nombre_imagenes[4]);
			
			
			
		}
		void Pic_grandeClick(object sender, EventArgs e)
		{
			PictureBox aux= (PictureBox) sender;
			pic_grande.Image=aux.Image;
		}
		
		
	}
}
