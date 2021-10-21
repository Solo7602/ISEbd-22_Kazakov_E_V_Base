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
		private readonly ParkingCollection parkingCollection;
		public ParkingPlace()
		{
			InitializeComponent();
			parkingCollection = new ParkingCollection(pictureBoxforParking.Width,
pictureBoxforParking.Height);
		}
		private void ReloadLevels()
		{
			int index = listBoxParking.SelectedIndex;
			listBoxParking.Items.Clear();
			for (int i = 0; i < parkingCollection.Keys.Count; i++)
			{
				listBoxParking.Items.Add(parkingCollection.Keys[i]);
			}
			if (listBoxParking.Items.Count > 0 && (index == -1 || index >=
		   listBoxParking.Items.Count))
			{
				listBoxParking.SelectedIndex = 0;
			}
			else if (listBoxParking.Items.Count > 0 && index > -1 && index <
		   listBoxParking.Items.Count)
			{
				listBoxParking.SelectedIndex = index;
			}
		}

		private void Draw()
		{
			if (listBoxParking.SelectedIndex > -1)
			{	//если выбран один из пуктов в listBox (при старте программы ни один пункт
				//не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу
				//listBox)
 Bitmap bmp = new Bitmap(pictureBoxforParking.Width,
pictureBoxforParking.Height);
				Graphics gr = Graphics.FromImage(bmp);
				parkingCollection[listBoxParking.SelectedItem.ToString()].Draw(gr);
				pictureBoxforParking.Image = bmp;
			}

		}
		private void Addparking_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxforName.Text))
			{
				MessageBox.Show("Введите название парковки", "Ошибка",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			parkingCollection.AddParking(textBoxforName.Text);
			ReloadLevels();
		}
		private void button_del_parking_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить парковку{ listBoxParking.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == DialogResult.Yes)
				{
					parkingCollection.DelParking(textBoxforName.Text);
					ReloadLevels();
				}
			}
		}
		private void parkBuldozer_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					var bulldozer = new BuldozerBase(100, 1000, dialog.Color);
					if (parkingCollection[listBoxParking.SelectedItem.ToString()] +
				   bulldozer)
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
		private void parkModBuldozer_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var bulldozer = new ModBuldozer(100, 1000, dialog.Color,
					   dialogDop.Color, true, true);
						if (parkingCollection[listBoxParking.SelectedItem.ToString()]
+ bulldozer)
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
		}

		private void OutBuldozer_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1 && BuldozerPlace.Text != "")
			{
				var bulldozer = parkingCollection[listBoxParking.SelectedItem.ToString()] -
			   Convert.ToInt32(BuldozerPlace.Text);
				if (bulldozer != null)
				{
					FormBulldozer form = new FormBulldozer();
					form.SetBuldozer(bulldozer);
					form.ShowDialog();
				}
				Draw();
			}
		}
		private void listBoxParking_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}

	}
}
