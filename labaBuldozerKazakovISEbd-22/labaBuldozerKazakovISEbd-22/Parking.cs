using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labaBuldozerKazakovISEbd_22
{
        public class Parking<T> : IEnumerator<T>, IEnumerable<T>
        where T : class, IBuldozer
    {
            private readonly List<T> _places;
        private readonly int _maxCount;
        private readonly int pictureWidth;
            private readonly int pictureHeight;
            private readonly int _placeSizeWidth = 305;
            private readonly int _placeSizeHeight = 160;
        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height; 
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _currentIndex = -1;
        }
        public static bool operator +(Parking<T> p, T bulldozer)
        {
            if (p._places.Count >= p._maxCount)
            {
				throw new ParkingOverflowException();
            }
            if (p._places.Contains(bulldozer))
            {
                throw new ParkingAlreadyHaveException();
            }
            p._places.Add(bulldozer);
            return true;
        }
        public static T operator -(Parking<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
				throw new ParkingNotFoundException(index);
			}
			T bulldozer = p._places[index];
            p._places.RemoveAt(index);
            return bulldozer;
        }
        public void Draw(Graphics g)
        {
            int changeHeight = 10;
            int width = pictureWidth / _placeSizeWidth;
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition((i % width * _placeSizeWidth) + changeHeight,
                    i / width * _placeSizeHeight + changeHeight, pictureWidth,
                    pictureHeight);
                _places[i].DrawTransport(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            double changeLong = 1.2;
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, (float)(i *
                  _placeSizeWidth + _placeSizeWidth / changeLong), j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
              (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
        public void Sort() => _places.Sort((IComparer<T>)new BulldozerCompare());
        /// <summary>
        /// </summary>
        public void Dispose()
        {
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу
        ///коллекции
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            _currentIndex++;
            if (_currentIndex >= _places.Count)
            {
                Reset();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
           
