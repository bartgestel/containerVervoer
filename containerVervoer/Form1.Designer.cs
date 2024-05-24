namespace containerVervoer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxShipWidth = new TextBox();
            tbxShipLength = new TextBox();
            btnAddShip = new Button();
            tbxMaxWeight = new TextBox();
            tbxContainerWeight = new TextBox();
            cbxContainerType = new ComboBox();
            btnAddContainer = new Button();
            lbxContainers = new ListBox();
            btnLoadCargo = new Button();
            SuspendLayout();
            // 
            // tbxShipWidth
            // 
            tbxShipWidth.Location = new Point(12, 12);
            tbxShipWidth.Name = "tbxShipWidth";
            tbxShipWidth.PlaceholderText = "Width in containers";
            tbxShipWidth.Size = new Size(147, 27);
            tbxShipWidth.TabIndex = 0;
            // 
            // tbxShipLength
            // 
            tbxShipLength.Location = new Point(12, 45);
            tbxShipLength.Name = "tbxShipLength";
            tbxShipLength.PlaceholderText = "Length in containers";
            tbxShipLength.Size = new Size(147, 27);
            tbxShipLength.TabIndex = 1;
            // 
            // btnAddShip
            // 
            btnAddShip.Location = new Point(180, 12);
            btnAddShip.Name = "btnAddShip";
            btnAddShip.Size = new Size(94, 93);
            btnAddShip.TabIndex = 2;
            btnAddShip.Text = "Add Ship";
            btnAddShip.UseVisualStyleBackColor = true;
            btnAddShip.Click += btnAddShip_Click;
            // 
            // tbxMaxWeight
            // 
            tbxMaxWeight.Location = new Point(12, 78);
            tbxMaxWeight.Name = "tbxMaxWeight";
            tbxMaxWeight.PlaceholderText = "Max. Weight";
            tbxMaxWeight.Size = new Size(147, 27);
            tbxMaxWeight.TabIndex = 1;
            // 
            // tbxContainerWeight
            // 
            tbxContainerWeight.Location = new Point(302, 12);
            tbxContainerWeight.Name = "tbxContainerWeight";
            tbxContainerWeight.PlaceholderText = "Container Weight";
            tbxContainerWeight.Size = new Size(147, 27);
            tbxContainerWeight.TabIndex = 0;
            // 
            // cbxContainerType
            // 
            cbxContainerType.FormattingEnabled = true;
            cbxContainerType.Items.AddRange(new object[] { "Normal", "Valuable", "Cooled" });
            cbxContainerType.Location = new Point(302, 44);
            cbxContainerType.Name = "cbxContainerType";
            cbxContainerType.Size = new Size(147, 28);
            cbxContainerType.TabIndex = 3;
            cbxContainerType.Text = "Normal";
            // 
            // btnAddContainer
            // 
            btnAddContainer.Location = new Point(465, 12);
            btnAddContainer.Name = "btnAddContainer";
            btnAddContainer.Size = new Size(94, 60);
            btnAddContainer.TabIndex = 2;
            btnAddContainer.Text = "Add Container";
            btnAddContainer.UseVisualStyleBackColor = true;
            btnAddContainer.Click += btnAddContainer_Click;
            // 
            // lbxContainers
            // 
            lbxContainers.FormattingEnabled = true;
            lbxContainers.Location = new Point(302, 94);
            lbxContainers.Name = "lbxContainers";
            lbxContainers.Size = new Size(257, 344);
            lbxContainers.TabIndex = 4;
            // 
            // btnLoadCargo
            // 
            btnLoadCargo.Location = new Point(580, 12);
            btnLoadCargo.Name = "btnLoadCargo";
            btnLoadCargo.Size = new Size(208, 60);
            btnLoadCargo.TabIndex = 5;
            btnLoadCargo.Text = "Load Cargo";
            btnLoadCargo.UseVisualStyleBackColor = true;
            btnLoadCargo.Click += btnLoadCargo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadCargo);
            Controls.Add(lbxContainers);
            Controls.Add(cbxContainerType);
            Controls.Add(btnAddContainer);
            Controls.Add(btnAddShip);
            Controls.Add(tbxMaxWeight);
            Controls.Add(tbxShipLength);
            Controls.Add(tbxContainerWeight);
            Controls.Add(tbxShipWidth);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxShipWidth;
        private TextBox tbxShipLength;
        private Button btnAddShip;
        private TextBox tbxMaxWeight;
        private TextBox tbxContainerWeight;
        private ComboBox cbxContainerType;
        private Button btnAddContainer;
        private ListBox lbxContainers;
        private Button btnLoadCargo;
    }
}
