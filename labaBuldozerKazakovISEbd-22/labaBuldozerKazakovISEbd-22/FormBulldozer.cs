using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labaBuldozerKazakovISEbd_22
{
	public partial class FormBulldozer : Form
	{
		private IBuldozer buldozer;
		public FormBulldozer()
		{
			InitializeComponent();
		}
		public void SetBuldozer(IBuldozer buldozer)
		{
			this.buldozer = buldozer;
			Draw();
		}
			private void Draw()
		{
			Bitmap bmp = new Bitmap(Picture.Width, Picture.Height);
			Graphics gr = Graphics.FromImage(bmp);
			buldozer.DrawTransport(gr);
			Picture.Image = bmp;
		}
		private void button_bul_Click_1(object sender, EventArgs e)
		{
			Random rnd = new Random();
			buldozer = new BuldozerBase(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
			buldozer.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), Picture.Width,
Picture.Height);
			Draw();
		}

		private void button_mod_Click_1(object sender, EventArgs e)
		{
			Random rnd = new Random();
			buldozer = new ModBuldozer(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
		   Color.Yellow, true, true);
			buldozer.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), Picture.Width,
		   Picture.Height);
			Draw();
		}
		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					buldozer.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					buldozer.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					buldozer.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					buldozer.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
