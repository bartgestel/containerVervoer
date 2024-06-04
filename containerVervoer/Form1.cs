using System.Diagnostics;

namespace containerVervoer
{
    public partial class Form1 : Form
    {
        Shipyard shipyard = new Shipyard();
        Ship ship;
        public Form1()
        {
            InitializeComponent();
            shipyard.AddShip(3, 3);
            ship = shipyard.Ship;
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {

        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            try
            {
                int containerWeight = Convert.ToInt32(tbxContainerWeight.Text);
                ContainerType containerType = (ContainerType)cbxContainerType.SelectedIndex;
                Container container = new Container(containerWeight, containerType);
                shipyard.AddContainer(container);
                lbxContainers.Items.Clear();
                foreach (Container c in shipyard.Containers)
                {
                    lbxContainers.Items.Add(c);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void btnLoadCargo_Click(object sender, EventArgs e)
        {
            shipyard.LoadContainers();
            lbxContainers.Items.Clear();
            lbxRows.Items.Clear();
            for (int i = 0; i < ship.Rows.Count; i++)
            {
                StackRow row = ship.Rows[i];
                lbxRows.Items.Add(i + 1);
            }
        }

        private void lbxRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxRows.SelectedIndex;
            lbxStacks.Items.Clear();
            foreach (ContainerStack stack in ship.Rows[index].ContainerStacks)
            {
                lbxStacks.Items.Add(stack.ToString());
            }
        }

        private void lbxStacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = lbxRows.SelectedIndex;
            int stackIndex = lbxStacks.SelectedIndex;
            ContainerStack stack = ship.Rows[rowIndex].ContainerStacks[stackIndex];
            lbxShipContainers.Items.Clear();
            foreach (Container c in stack.Containers)
            {
                lbxShipContainers.Items.Add(c);
            }
        }
    }
}
