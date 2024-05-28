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
            shipyard.AddShip(5, 10);
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
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void btnLoadCargo_Click(object sender, EventArgs e)
        {

        }
    }
}
