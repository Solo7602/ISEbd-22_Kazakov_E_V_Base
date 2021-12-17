namespace labaBuldozerKazakovISEbd_22
{
	partial class ParkingPlace
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pictureBoxforParking = new System.Windows.Forms.PictureBox();
            this.OutPark = new System.Windows.Forms.Label();
            this.InfoPlace = new System.Windows.Forms.Label();
            this.BuldozerPlace = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxforbutton = new System.Windows.Forms.GroupBox();
            this.buttonPark = new System.Windows.Forms.Button();
            this.button_del_parking = new System.Windows.Forms.Button();
            this.listBoxParking = new System.Windows.Forms.ListBox();
            this.Addparking = new System.Windows.Forms.Button();
            this.textBoxforName = new System.Windows.Forms.TextBox();
            this.labelparkingname = new System.Windows.Forms.Label();
            this.OutBuldozer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxforParking)).BeginInit();
            this.groupBoxforbutton.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxforParking
            // 
            this.pictureBoxforParking.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxforParking.Name = "pictureBoxforParking";
            this.pictureBoxforParking.Size = new System.Drawing.Size(678, 424);
            this.pictureBoxforParking.TabIndex = 0;
            this.pictureBoxforParking.TabStop = false;
            // 
            // OutPark
            // 
            this.OutPark.AutoSize = true;
            this.OutPark.Location = new System.Drawing.Point(11, 355);
            this.OutPark.Name = "OutPark";
            this.OutPark.Size = new System.Drawing.Size(105, 13);
            this.OutPark.TabIndex = 3;
            this.OutPark.Text = "Забрать бульдозер";
            // 
            // InfoPlace
            // 
            this.InfoPlace.AutoSize = true;
            this.InfoPlace.Location = new System.Drawing.Point(5, 378);
            this.InfoPlace.Name = "InfoPlace";
            this.InfoPlace.Size = new System.Drawing.Size(39, 13);
            this.InfoPlace.TabIndex = 4;
            this.InfoPlace.Text = "Место";
            // 
            // BuldozerPlace
            // 
            this.BuldozerPlace.Location = new System.Drawing.Point(50, 371);
            this.BuldozerPlace.Name = "BuldozerPlace";
            this.BuldozerPlace.Size = new System.Drawing.Size(58, 20);
            this.BuldozerPlace.TabIndex = 5;
            // 
            // groupBoxforbutton
            // 
            this.groupBoxforbutton.Controls.Add(this.buttonSort);
            this.groupBoxforbutton.Controls.Add(this.buttonPark);
            this.groupBoxforbutton.Controls.Add(this.button_del_parking);
            this.groupBoxforbutton.Controls.Add(this.listBoxParking);
            this.groupBoxforbutton.Controls.Add(this.Addparking);
            this.groupBoxforbutton.Controls.Add(this.textBoxforName);
            this.groupBoxforbutton.Controls.Add(this.labelparkingname);
            this.groupBoxforbutton.Controls.Add(this.OutBuldozer);
            this.groupBoxforbutton.Controls.Add(this.BuldozerPlace);
            this.groupBoxforbutton.Controls.Add(this.InfoPlace);
            this.groupBoxforbutton.Controls.Add(this.OutPark);
            this.groupBoxforbutton.Location = new System.Drawing.Point(679, 2);
            this.groupBoxforbutton.Name = "groupBoxforbutton";
            this.groupBoxforbutton.Size = new System.Drawing.Size(124, 448);
            this.groupBoxforbutton.TabIndex = 6;
            this.groupBoxforbutton.TabStop = false;
            // 
            // buttonPark
            // 
            this.buttonPark.Location = new System.Drawing.Point(6, 288);
            this.buttonPark.Name = "buttonPark";
            this.buttonPark.Size = new System.Drawing.Size(110, 42);
            this.buttonPark.TabIndex = 13;
            this.buttonPark.Text = "Припарковать транспорт";
            this.buttonPark.UseVisualStyleBackColor = true;
            this.buttonPark.Click += new System.EventHandler(this.buttonPark_Click);
            // 
            // button_del_parking
            // 
            this.button_del_parking.Location = new System.Drawing.Point(5, 179);
            this.button_del_parking.Name = "button_del_parking";
            this.button_del_parking.Size = new System.Drawing.Size(113, 23);
            this.button_del_parking.TabIndex = 12;
            this.button_del_parking.Text = "Удалить парковку";
            this.button_del_parking.UseVisualStyleBackColor = true;
            this.button_del_parking.Click += new System.EventHandler(this.button_del_parking_Click);
            // 
            // listBoxParking
            // 
            this.listBoxParking.FormattingEnabled = true;
            this.listBoxParking.Location = new System.Drawing.Point(6, 92);
            this.listBoxParking.Name = "listBoxParking";
            this.listBoxParking.Size = new System.Drawing.Size(112, 82);
            this.listBoxParking.TabIndex = 10;
            this.listBoxParking.SelectedIndexChanged += new System.EventHandler(this.listBoxParking_SelectedIndexChanged);
            // 
            // Addparking
            // 
            this.Addparking.Location = new System.Drawing.Point(0, 60);
            this.Addparking.Name = "Addparking";
            this.Addparking.Size = new System.Drawing.Size(124, 26);
            this.Addparking.TabIndex = 9;
            this.Addparking.Text = "Добавить парковку";
            this.Addparking.UseVisualStyleBackColor = true;
            this.Addparking.Click += new System.EventHandler(this.Addparking_Click);
            // 
            // textBoxforName
            // 
            this.textBoxforName.Location = new System.Drawing.Point(0, 34);
            this.textBoxforName.Name = "textBoxforName";
            this.textBoxforName.Size = new System.Drawing.Size(116, 20);
            this.textBoxforName.TabIndex = 11;
            // 
            // labelparkingname
            // 
            this.labelparkingname.AutoSize = true;
            this.labelparkingname.Location = new System.Drawing.Point(38, 18);
            this.labelparkingname.Name = "labelparkingname";
            this.labelparkingname.Size = new System.Drawing.Size(57, 13);
            this.labelparkingname.TabIndex = 7;
            this.labelparkingname.Text = "Парковки";
            // 
            // OutBuldozer
            // 
            this.OutBuldozer.Location = new System.Drawing.Point(15, 407);
            this.OutBuldozer.Name = "OutBuldozer";
            this.OutBuldozer.Size = new System.Drawing.Size(80, 29);
            this.OutBuldozer.TabIndex = 6;
            this.OutBuldozer.Text = "Забрать";
            this.OutBuldozer.UseVisualStyleBackColor = true;
            this.OutBuldozer.Click += new System.EventHandler(this.OutBuldozer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "Файл";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(6, 229);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(110, 34);
            this.buttonSort.TabIndex = 14;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ParkingPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxforbutton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBoxforParking);
            this.Name = "ParkingPlace";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxforParking)).EndInit();
            this.groupBoxforbutton.ResumeLayout(false);
            this.groupBoxforbutton.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxforParking;
		private System.Windows.Forms.Label OutPark;
		private System.Windows.Forms.Label InfoPlace;
		private System.Windows.Forms.MaskedTextBox BuldozerPlace;
		private System.Windows.Forms.GroupBox groupBoxforbutton;
		private System.Windows.Forms.Button OutBuldozer;
		private System.Windows.Forms.ListBox listBoxParking;
		private System.Windows.Forms.Button Addparking;
		private System.Windows.Forms.TextBox textBoxforName;
		private System.Windows.Forms.Label labelparkingname;
		private System.Windows.Forms.Button button_del_parking;
        private System.Windows.Forms.Button buttonPark;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}