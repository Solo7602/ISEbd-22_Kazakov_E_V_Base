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
	public partial class ParkingPlace : Form
	{
		private readonly Parking<BuldozerBase> parking;
		public ParkingPlace()
		{
			InitializeComponent();
			parking = new Parking<BuldozerBase>(pictureBoxforParking.Width,
pictureBoxforParking.Height);
			Draw();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxforParking.Width, pictureBoxforParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking?.Draw(gr);
			pictureBoxforParking.Image = bmp;
		}

		private void parkBuldozer_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var buldozer = new BuldozerBase(100, 1000, dialog.Color);
				if (parking + buldozer!=-1)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Парковка переполнена");
				}
			}
		}
		private void parkModBuldozer_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var buldozer = new ModBuldozer(100, 1000, dialog.Color, dialogDop.Color,
				   true, true);
					if (parking + buldozer!=-1)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Парковка переполнена");
					}
				}
			}
		}

		private void OutBuldozer_Click(object sender, EventArgs e)
		{
			if (BuldozerPlace.Text != "")
			{
				var car = parking - Convert.ToInt32(BuldozerPlace.Text);
				if (car != null)
				{
					FormBulldozer form = new FormBulldozer();
					form.SetBuldozer(car);
					form.ShowDialog();
				}
				Draw();
			}
		}
	}
}
