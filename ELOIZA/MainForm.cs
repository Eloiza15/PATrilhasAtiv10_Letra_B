//Crie um formulário com dois botões. Ao clicar em um botão, altere a cor de
//fundo do formulário para vermelho. Ao clicar no outro botão, altere a cor de
//fundo para azul.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ELOIZA
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
		void BtnVermelhoClick(object sender, EventArgs e)
		{
	         this.BackColor = Color.Red;
		}
		void BtnAzulClick(object sender, EventArgs e)
		{
	          this.BackColor = Color.Blue;
		}
		
	}
}
