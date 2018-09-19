using System;
using UnityEngine;


namespace Assets._Game.Scripts.Cammon
{
    class ScreenLimit
    {
        public sbyte MinX { get; private set; }
        public sbyte MaxX { get; private set; }
        public sbyte MinY { get; private set; }
        public sbyte MaxY { get; private set; }

        public ScreenLimit()
        {

            MinX = -7;
            MinY = -5;
            MaxX = 7;
            MaxY = 5;
        }

    }
}
