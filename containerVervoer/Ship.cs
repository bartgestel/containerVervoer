using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containerVervoer
{
    public class Ship
    {
        public int Width { get; private set; }
        public int Length { get; private set; }
        public int MaxWeight { get; private set; }
        
        public List<StackRow> Rows = new List<StackRow>();
        public Ship(int width, int length) 
        {
            Width = width;
            Length = length;
            MaxWeight = width * length * 150000;
            for (int i = 0; i < length; i++)
            {
                Rows.Add(new StackRow(width));
            }
        }

        public bool LoadCargo()
        {
            return true;
        }

    }
}
