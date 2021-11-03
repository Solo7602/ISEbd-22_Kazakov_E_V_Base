
namespace labaBuldozerKazakovISEbd_22
{
    partial class FormBulldozerCFG
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
            this.groupBoxForLabel = new System.Windows.Forms.GroupBox();
            this.labelModBulldozer = new System.Windows.Forms.Label();
            this.labelBulldozer = new System.Windows.Forms.Label();
            this.groupBoxforstat = new System.Windows.Forms.GroupBox();
            this.checkBoxBucket = new System.Windows.Forms.CheckBox();
            this.checkBoxSpoiler = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelForMainColor = new System.Windows.Forms.Label();
            this.labelForDopColor = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelGrey = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.groupBoxForColor = new System.Windows.Forms.GroupBox();
            this.groupBoxForLabel.SuspendLayout();
            this.groupBoxforstat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel.SuspendLayout();
            this.groupBoxForColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForLabel
            // 
            this.groupBoxForLabel.Controls.Add(this.labelModBulldozer);
            this.groupBoxForLabel.Controls.Add(this.labelBulldozer);
            this.groupBoxForLabel.Location = new System.Drawing.Point(10, 9);
            this.groupBoxForLabel.Name = "groupBoxForLabel";
            this.groupBoxForLabel.Size = new System.Drawing.Size(156, 134);
            this.groupBoxForLabel.TabIndex = 0;
            this.groupBoxForLabel.TabStop = false;
            // 
            // labelModBulldozer
            // 
            this.labelModBulldozer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelModBulldozer.Location = new System.Drawing.Point(14, 74);
            this.labelModBulldozer.Name = "labelModBulldozer";
            this.labelModBulldozer.Size = new System.Drawing.Size(117, 36);
            this.labelModBulldozer.TabIndex = 1;
            this.labelModBulldozer.Text = "Модифицированный бульдозер";
            this.labelModBulldozer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelModBulldozer_MouseDown);
            // 
            // labelBulldozer
            // 
            this.labelBulldozer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBulldozer.Location = new System.Drawing.Point(14, 27);
            this.labelBulldozer.Name = "labelBulldozer";
            this.labelBulldozer.Size = new System.Drawing.Size(117, 35);
            this.labelBulldozer.TabIndex = 0;
            this.labelBulldozer.Text = "Обычный бульдозер";
            this.labelBulldozer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBulldozer_MouseDown);
            // 
            // groupBoxforstat
            // 
            this.groupBoxforstat.Controls.Add(this.checkBoxBucket);
            this.groupBoxforstat.Controls.Add(this.checkBoxSpoiler);
            this.groupBoxforstat.Controls.Add(this.numericUpDownWeight);
            this.groupBoxforstat.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxforstat.Controls.Add(this.label2);
            this.groupBoxforstat.Controls.Add(this.label1);
            this.groupBoxforstat.Location = new System.Drawing.Point(10, 295);
            this.groupBoxforstat.Name = "groupBoxforstat";
            this.groupBoxforstat.Size = new System.Drawing.Size(463, 137);
            this.groupBoxforstat.TabIndex = 1;
            this.groupBoxforstat.TabStop = false;
            // 
            // checkBoxBucket
            // 
            this.checkBoxBucket.AutoSize = true;
            this.checkBoxBucket.Location = new System.Drawing.Point(305, 78);
            this.checkBoxBucket.Name = "checkBoxBucket";
            this.checkBoxBucket.Size = new System.Drawing.Size(53, 17);
            this.checkBoxBucket.TabIndex = 5;
            this.checkBoxBucket.Text = "Ковш";
            this.checkBoxBucket.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpoiler
            // 
            this.checkBoxSpoiler.AutoSize = true;
            this.checkBoxSpoiler.Location = new System.Drawing.Point(305, 40);
            this.checkBoxSpoiler.Name = "checkBoxSpoiler";
            this.checkBoxSpoiler.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSpoiler.TabIndex = 4;
            this.checkBoxSpoiler.Text = "Задний спойлер";
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(79, 111);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(79, 40);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес бульдозера";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Максимальная скорость";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(33, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(355, 228);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(172, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(405, 266);
            this.panel.TabIndex = 3;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(699, 211);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(74, 30);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(699, 247);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(74, 31);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Отмена";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // labelForMainColor
            // 
            this.labelForMainColor.AllowDrop = true;
            this.labelForMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelForMainColor.Location = new System.Drawing.Point(18, 25);
            this.labelForMainColor.Name = "labelForMainColor";
            this.labelForMainColor.Size = new System.Drawing.Size(68, 40);
            this.labelForMainColor.TabIndex = 0;
            this.labelForMainColor.Text = "Основной цвет";
            this.labelForMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelForMainColor_DragDrop);
            this.labelForMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelForMainColor_DragEnter);
            // 
            // labelForDopColor
            // 
            this.labelForDopColor.AllowDrop = true;
            this.labelForDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelForDopColor.Location = new System.Drawing.Point(105, 26);
            this.labelForDopColor.Name = "labelForDopColor";
            this.labelForDopColor.Size = new System.Drawing.Size(79, 39);
            this.labelForDopColor.TabIndex = 1;
            this.labelForDopColor.Text = "Дополнительный цвет";
            this.labelForDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelForDopColor_DragDrop);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(18, 75);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(38, 38);
            this.panelRed.TabIndex = 2;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(62, 75);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(38, 38);
            this.panelYellow.TabIndex = 3;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(106, 75);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(38, 38);
            this.panelBlack.TabIndex = 3;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(150, 75);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(38, 38);
            this.panelWhite.TabIndex = 3;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGrey
            // 
            this.panelGrey.BackColor = System.Drawing.Color.Gray;
            this.panelGrey.Location = new System.Drawing.Point(18, 119);
            this.panelGrey.Name = "panelGrey";
            this.panelGrey.Size = new System.Drawing.Size(38, 38);
            this.panelGrey.TabIndex = 3;
            this.panelGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(62, 119);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(38, 38);
            this.panelOrange.TabIndex = 3;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(106, 119);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(38, 38);
            this.panelGreen.TabIndex = 3;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(150, 119);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(38, 38);
            this.panelBlue.TabIndex = 3;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // groupBoxForColor
            // 
            this.groupBoxForColor.Controls.Add(this.panelBlue);
            this.groupBoxForColor.Controls.Add(this.panelGreen);
            this.groupBoxForColor.Controls.Add(this.panelOrange);
            this.groupBoxForColor.Controls.Add(this.panelGrey);
            this.groupBoxForColor.Controls.Add(this.panelWhite);
            this.groupBoxForColor.Controls.Add(this.panelBlack);
            this.groupBoxForColor.Controls.Add(this.panelYellow);
            this.groupBoxForColor.Controls.Add(this.panelRed);
            this.groupBoxForColor.Controls.Add(this.labelForDopColor);
            this.groupBoxForColor.Controls.Add(this.labelForMainColor);
            this.groupBoxForColor.Location = new System.Drawing.Point(583, 12);
            this.groupBoxForColor.Name = "groupBoxForColor";
            this.groupBoxForColor.Size = new System.Drawing.Size(190, 183);
            this.groupBoxForColor.TabIndex = 4;
            this.groupBoxForColor.TabStop = false;
            this.groupBoxForColor.Text = "Цвета";
            // 
            // FormBulldozerCFG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 444);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxForColor);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBoxforstat);
            this.Controls.Add(this.groupBoxForLabel);
            this.Name = "FormBulldozerCFG";
            this.Text = "Выбор бульдозера";
            this.groupBoxForLabel.ResumeLayout(false);
            this.groupBoxforstat.ResumeLayout(false);
            this.groupBoxforstat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel.ResumeLayout(false);
            this.groupBoxForColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxForLabel;
        private System.Windows.Forms.GroupBox groupBoxforstat;
        private System.Windows.Forms.CheckBox checkBoxSpoiler;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelModBulldozer;
        private System.Windows.Forms.Label labelBulldozer;
        private System.Windows.Forms.CheckBox checkBoxBucket;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelForMainColor;
        private System.Windows.Forms.Label labelForDopColor;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGrey;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.GroupBox groupBoxForColor;
    }
}