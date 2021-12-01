using NLog;
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
		/// <summary>
		/// Логгер
		/// </summary>
		private readonly Logger logger;
		public ParkingPlace()
		{
			InitializeComponent();
			parkingCollection = new ParkingCollection(pictureBoxforParking.Width,
pictureBoxforParking.Height);
			logger = LogManager.GetCurrentClassLogger();	
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
				logger.Warn("Не введено название парковки");
				return;
			}
			logger.Info($"Добавили парковку {textBoxforName.Text}");
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
					logger.Info($"Удалили парковку{listBoxParking.SelectedItem.ToString()}");
					parkingCollection.DelParking(textBoxforName.Text);
					ReloadLevels();
				}
			}
		}

		private void OutBuldozer_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1 && BuldozerPlace.Text != "")
			{
				try
				{

					var bulldozer = parkingCollection[listBoxParking.SelectedItem.ToString()] -
				   Convert.ToInt32(BuldozerPlace.Text);
					if (bulldozer != null)
					{
						FormBulldozer form = new FormBulldozer();
						form.SetBuldozer(bulldozer);
						form.ShowDialog();
						logger.Info($"Изъят автомобиль {bulldozer} с места{ BuldozerPlace.Text}");
					}
					Draw();
				}
				catch (ParkingNotFoundException ex)
				{
					MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
					logger.Warn("Не найдено");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Warn("Неизвестная ошибка");
				}
			}
		}
		private void listBoxParking_SelectedIndexChanged(object sender, EventArgs e)
		{
			logger.Info($"Перешли на парковку{ listBoxParking.SelectedItem.ToString()}");
			Draw();
		}

        private void buttonPark_Click(object sender, EventArgs e)
        {
			var formCarConfig = new FormBulldozerCFG();
			formCarConfig.AddEvent(AddCar);
			formCarConfig.Show();
		}
		private void AddCar(VehicleBuldozer buldozer)
		{
			if (buldozer != null && listBoxParking.SelectedIndex > -1)
			{
				try
				{
					if ((parkingCollection[listBoxParking.SelectedItem.ToString()]) + buldozer)
					{
						Draw();
						logger.Info($"Добавлен автомобиль {buldozer}");
					}
					else
					{
						MessageBox.Show("Машину не удалось поставить");
					}
					Draw();
				}
				catch (ParkingOverflowException ex)
				{
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
					logger.Warn("Переполнение");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Warn("Неизвестная ошибка");
				}
			}
		}

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					parkingCollection.SaveData(saveFileDialog.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат",MessageBoxButtons.OK, MessageBoxIcon.Information);					logger.Info("Сохранено в файл " + saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
				    MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Warn("Неизвестная ошибка при сохранении");
				}
			}
		}

		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					parkingCollection.LoadData(openFileDialog.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog.FileName);
					ReloadLevels();
					Draw();
				}
				catch (ParkingOccupiedPlaceException ex)
				{
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
    }
}
