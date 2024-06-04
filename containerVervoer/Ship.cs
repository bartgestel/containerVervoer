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

        public int[] ClearanceRows;
        
        public List<Container> LeftOverContainers = new List<Container>();
        
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
            ClearanceRows = GetClearanceRows();
        }

        public int[] GetClearanceRows()
        {
            List<int> indices = new List<int>();
            for (int i = 2; i < Rows.Count; i += 3)
            {
                indices.Add(i);
            }
            
            return indices.ToArray();
        }

        public void LoadCooledContainer(List<Container> containers)
        {
            var firstRow = Rows[0];
            foreach (Container container in containers)
            {
                if (!firstRow.AddContainer(container))
                {
                    MessageBox.Show("Can't fit all the cooled containers on the ship. \n Please try again.");
                    break;
                }
                
            }
        }
        
        public void LoadNormalContainer(List<Container> containers)
        {
            foreach (var container in containers)
            {
                bool isAdded = false;
                foreach (var row in Rows)
                {
                    if (row.AddContainer(container))
                    {
                        isAdded = true;
                        break;
                    }
                }
                if (!isAdded)
                {
                    LeftOverContainers.Add(container);
                }
            }
        }
        
        public void LoadCooledValuableContainers(List<Container> containers)
        {
            var firstRow = Rows[0];
            foreach (Container container in containers)
            {
                if (!firstRow.AddContainer(container))
                {
                    MessageBox.Show("Can't fit all the valuable cooled containers on the ship. \n Please try again.");
                    break;
                }
            }
        }
        
        public void LoadValuableContainers(List<Container> containers)
        {
            foreach (var container in containers)
            {
                for (int i = 0; i < Rows.Count; i++)
                {
                    if (!ClearanceRows.Contains(i))
                    {
                        StackRow row = Rows[i];
                        if (!row.AddContainer(container))
                        {
                            continue;
                        }
                        break;
                    }
                }
            }
        }

        public void LoadLeftOverContainers()
        {
            foreach (var container in LeftOverContainers)
            {
                foreach (var row in Rows)
                {
                    if (row.AddLeftOverContainer(container))
                    {
                        break;
                    }
                }
            }
        }

    }
}
