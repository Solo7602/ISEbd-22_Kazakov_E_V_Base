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
    public partial class FormBulldozerCFG : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        VehicleBuldozer bulldozer = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event Action<VehicleBuldozer> eventAddCar;

        public FormBulldozerCFG()
        {
            InitializeComponent();
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            buttonStop.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawCar()
        {
            if (bulldozer != null)
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bulldozer.SetPosition(5, 5, pictureBox.Width, pictureBox.Height);
                bulldozer.DrawTransport(gr);
                pictureBox.Image = bmp;
            }
        }
        public void AddEvent(Action<VehicleBuldozer> ev)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new Action<VehicleBuldozer>(ev);
            }
            else
            {
                eventAddCar += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBulldozer_MouseDown(object sender, MouseEventArgs e)
        {
            labelBulldozer.DoDragDrop(labelBulldozer.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void labelModBulldozer_MouseDown(object sender, MouseEventArgs e)
        {
            labelModBulldozer.DoDragDrop(labelModBulldozer.Text, DragDropEffects.Move |
DragDropEffects.Copy);

        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный бульдозер":
                    bulldozer = new BuldozerBase((int)numericUpDownSpeed.Value,
(int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Модифицированный бульдозер":
                    bulldozer = new ModBuldozer((int)numericUpDownSpeed.Value,
(int)numericUpDownWeight.Value, Color.White, Color.Black,
 checkBoxSpoiler.Checked, checkBoxBucket.Checked);
                    break;
            }
            DrawCar();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Color color = (sender as Panel).BackColor;
            (sender as Panel).DoDragDrop(color, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelForMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelForMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bulldozer != null)
            {
                bulldozer.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }

        private void labelForDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bulldozer != null)
            {
                if (bulldozer is ModBuldozer)
                {
                    (bulldozer as ModBuldozer).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCar();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddCar?.Invoke(bulldozer);
            Close();
        }

    }
}
