﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labaBuldozerKazakovISEbd_22
{
    public class ModBuldozer : BuldozerBase
    {
        public Color DopColor { private set; get; }
        public bool BackSpoiler { private set; get; }
        public bool Bucket { private set; get; }
        public ModBuldozer(int maxSpeed, float weight, Color mainColor, Color dopColor, bool backSpoiler, bool bucket) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            BackSpoiler = backSpoiler;
            Bucket = bucket;
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            if (BackSpoiler)
            {
                g.DrawLine(pen, _startPosX + 220, _startPosY + 71, _startPosX + 250, _startPosY + 51);
                g.DrawLine(pen, _startPosX + 220, _startPosY + 91, _startPosX + 250, _startPosY + 51);
                g.DrawRectangle(pen, _startPosX + 230, _startPosY + 31, 40, 20);
            }
            if (Bucket)
            {
                g.DrawLine(pen, _startPosX + 70, _startPosY + 76, _startPosX + 40, _startPosY + 76);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 51, _startPosX + 40, _startPosY + 151);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 151, _startPosX, _startPosY + 151);
                g.DrawLine(pen, _startPosX, _startPosY + 151, _startPosX + 40, _startPosY + 51);
            }
            base.DrawTransport(g);
        }
    }
}