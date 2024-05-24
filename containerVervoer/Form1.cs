using System.Diagnostics;

namespace containerVervoer
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship(5, 10, 12000);
        public Form1()
        {
            InitializeComponent();
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
                ship.Containers.Add(container);
                lbxContainers.Items.Clear();
                foreach (Container c in ship.Containers)
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
