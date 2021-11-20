using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labaBuldozerKazakovISEbd_22
{
	class ParkingCollection
	{
		readonly Dictionary<string, Parking<VehicleBuldozer>> parkingStages;
		public List<string> Keys => parkingStages.Keys.ToList();
		private readonly int pictureWidth;
		private readonly int pictureHeight;
		public ParkingCollection(int pictureWidth, int pictureHeight)
		{
			parkingStages = new Dictionary<string, Parking<VehicleBuldozer>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}
		private readonly char separator = ':';

		public void AddParking(string name)
		{
			if (parkingStages.ContainsKey(name))
			{
				return;
			}
			parkingStages.Add(name, new Parking<VehicleBuldozer>(pictureWidth, pictureHeight));
		}
		public void DelParking(string name)
		{
			if (parkingStages.ContainsKey(name))
			{
				parkingStages.Remove(name);
			}
		}
		public Parking<VehicleBuldozer> this[string ind]
		{
			get
			{
				if (parkingStages.ContainsKey(ind))
				{
					return parkingStages[ind];
				}
				return null;
			}
		}
		/// <summary>
		/// Сохранение информации по автомобилям на парковках в файл
		/// </summary>
		/// <param name="filename">Путь и имя файла</param>
		/// <returns></returns>
		public bool SaveData(string filename)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (StreamWriter sw = new StreamWriter(filename))
			{
				sw.Write($"ParkingCollection{Environment.NewLine}");
				foreach (var level in parkingStages)
				{
					//Начинаем парковку
					sw.Write($"Parking{separator}{level.Key}{Environment.NewLine}");
					IBuldozer buldozer = null;
					for (int i = 0; (buldozer = level.Value.GetNext(i)) != null; i++)
					{
						if (buldozer != null)
						{
							//если место не пустое
							//Записываем тип машины
							if (buldozer.GetType().Name == "BuldozerBase")
							{
								sw.Write($"BuldozerBase{separator}");
							}
							if (buldozer.GetType().Name == "ModBuldozer")
							{
								sw.Write($"ModBuldozer{separator}");
							}
							//Записываемые параметры
							sw.Write(buldozer + Environment.NewLine);
						}
					}
				}
			}
			return true;
		}
		public bool LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				return false;
			}
			string bufferTextFromFile = "";
			using (StreamReader sr = new StreamReader(filename))
			{
			bufferTextFromFile  = sr.ReadLine();
			if (bufferTextFromFile.Contains("ParkingCollection"))
			{
				//очищаем записи
				parkingStages.Clear();
			}
			else
			{
				//если нет такой записи, то это не те данные
				return false;
			}
			VehicleBuldozer buldozer = null;
			string key = string.Empty;
			for (int i = 1; !sr.EndOfStream; ++i)
			{
				//идем по считанным записям
				bufferTextFromFile = sr.ReadLine();
				if (bufferTextFromFile.Contains("Parking"))
				{
					key = bufferTextFromFile.Split(separator)[1];
					parkingStages.Add(key, new Parking<VehicleBuldozer>(pictureWidth,
					pictureHeight));
					continue;
				}
				if (string.IsNullOrEmpty(bufferTextFromFile))
				{
					continue;
				}
				if (bufferTextFromFile.Split(separator)[0] == "BuldozerBase")
				{
					buldozer = new BuldozerBase(bufferTextFromFile.Split(separator)[1]);
				}
				else if (bufferTextFromFile.Split(separator)[0] == "ModBuldozer")
				{
					buldozer = new ModBuldozer(bufferTextFromFile.Split(separator)[1]);
				}
				var result = parkingStages[key] + buldozer;
					if (!result)
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}
