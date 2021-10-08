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
			this.parkBuldozer = new System.Windows.Forms.Button();
			this.parkModBuldozer = new System.Windows.Forms.Button();
			this.OutPark = new System.Windows.Forms.Label();
			this.InfoPlace = new System.Windows.Forms.Label();
			this.BuldozerPlace = new System.Windows.Forms.MaskedTextBox();
			this.groupBoxforbutton = new System.Windows.Forms.GroupBox();
			this.OutBuldozer = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxforParking)).BeginInit();
			this.groupBoxforbutton.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxforParking
			// 
			this.pictureBoxforParking.Location = new System.Drawing.Point(1, 1);
			this.pictureBoxforParking.Name = "pictureBoxforParking";
			this.pictureBoxforParking.Size = new System.Drawing.Size(677, 450);
			this.pictureBoxforParking.TabIndex = 0;
			this.pictureBoxforParking.TabStop = false;
			// 
			// parkBuldozer
			// 
			this.parkBuldozer.Location = new System.Drawing.Point(8, 2);
			this.parkBuldozer.Name = "parkBuldozer";
			this.parkBuldozer.Size = new System.Drawing.Size(108, 47);
			this.parkBuldozer.TabIndex = 1;
			this.parkBuldozer.Text = "Припарковать бульдозер";
			this.parkBuldozer.UseVisualStyleBackColor = true;
			this.parkBuldozer.Click += new System.EventHandler(this.parkBuldozer_Click);
			// 
			// parkModBuldozer
			// 
			this.parkModBuldozer.Location = new System.Drawing.Point(8, 55);
			this.parkModBuldozer.Name = "parkModBuldozer";
			this.parkModBuldozer.Size = new System.Drawing.Size(108, 47);
			this.parkModBuldozer.TabIndex = 2;
			this.parkModBuldozer.Text = "Припарковать улучшенный бульдозер";
			this.parkModBuldozer.UseVisualStyleBackColor = true;
			this.parkModBuldozer.Click += new System.EventHandler(this.parkModBuldozer_Click);
			// 
			// OutPark
			// 
			this.OutPark.AutoSize = true;
			this.OutPark.Location = new System.Drawing.Point(11, 105);
			this.OutPark.Name = "OutPark";
			this.OutPark.Size = new System.Drawing.Size(105, 13);
			this.OutPark.TabIndex = 3;
			this.OutPark.Text = "Забрать бульдозер";
			// 
			// InfoPlace
			// 
			this.InfoPlace.AutoSize = true;
			this.InfoPlace.Location = new System.Drawing.Point(12, 134);
			this.InfoPlace.Name = "InfoPlace";
			this.InfoPlace.Size = new System.Drawing.Size(39, 13);
			this.InfoPlace.TabIndex = 4;
			this.InfoPlace.Text = "Место";
			// 
			// BuldozerPlace
			// 
			this.BuldozerPlace.Location = new System.Drawing.Point(57, 131);
			this.BuldozerPlace.Name = "BuldozerPlace";
			this.BuldozerPlace.Size = new System.Drawing.Size(58, 20);
			this.BuldozerPlace.TabIndex = 5;
			// 
			// groupBoxforbutton
			// 
			this.groupBoxforbutton.Controls.Add(this.OutBuldozer);
			this.groupBoxforbutton.Controls.Add(this.BuldozerPlace);
			this.groupBoxforbutton.Controls.Add(this.InfoPlace);
			this.groupBoxforbutton.Controls.Add(this.OutPark);
			this.groupBoxforbutton.Controls.Add(this.parkModBuldozer);
			this.groupBoxforbutton.Controls.Add(this.parkBuldozer);
			this.groupBoxforbutton.Location = new System.Drawing.Point(679, 2);
			this.groupBoxforbutton.Name = "groupBoxforbutton";
			this.groupBoxforbutton.Size = new System.Drawing.Size(124, 448);
			this.groupBoxforbutton.TabIndex = 6;
			this.groupBoxforbutton.TabStop = false;
			// 
			// OutBuldozer
			// 
			this.OutBuldozer.Location = new System.Drawing.Point(21, 163);
			this.OutBuldozer.Name = "OutBuldozer";
			this.OutBuldozer.Size = new System.Drawing.Size(80, 29);
			this.OutBuldozer.TabIndex = 6;
			this.OutBuldozer.Text = "Забрать";
			this.OutBuldozer.UseVisualStyleBackColor = true;
			this.OutBuldozer.Click += new System.EventHandler(this.OutBuldozer_Click);
			// 
			// ParkingPlace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBoxforbutton);
			this.Controls.Add(this.pictureBoxforParking);
			this.Name = "ParkingPlace";
			this.Text = "Парковка";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxforParking)).EndInit();
			this.groupBoxforbutton.ResumeLayout(false);
			this.groupBoxforbutton.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxforParking;
		private System.Windows.Forms.Button parkBuldozer;
		private System.Windows.Forms.Button parkModBuldozer;
		private System.Windows.Forms.Label OutPark;
		private System.Windows.Forms.Label InfoPlace;
		private System.Windows.Forms.MaskedTextBox BuldozerPlace;
		private System.Windows.Forms.GroupBox groupBoxforbutton;
		private System.Windows.Forms.Button OutBuldozer;
	}
}