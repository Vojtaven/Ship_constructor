using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ship_constructor
{
    public partial class Form1 : Form
    {
        private List<Modul> list;
        public Form1()
        {
            InitializeComponent();
            list = new List<Modul>();
            list.Add(new Modul("AUX-U00",3,-2,1,-1,0));
            list.Add(new Modul("AUX-U01",4,5));
            list.Add(new Modul("AUX-U02",78,98));
            blockList.DataSource = list;
            lEnergy.Text = "0";
            lMass.Text = "0";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // outputTextbox.Text = blockList.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Modul sel = list[blockList.SelectedIndex];
            outputTextbox.Text = sel.ToString();
            sel.setLevel((int)levelUpDown.Value);
            levelUpDown.Value = 0;
            shipBox.Items.Add(sel);
            shipBox.DisplayMember = "Info";
            lMass.Text = countMass().ToString();
            lEnergy.Text = countEnergy().ToString();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
           
        }

        private void outputTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void removoButton_Click(object sender, EventArgs e)
        {
            shipBox.Items.RemoveAt(shipBox.SelectedIndex);
            lMass.Text = countMass().ToString();
            lEnergy.Text = countEnergy().ToString();
        }

        private int countMass() {
            int mass = 0;
            foreach (Modul m in shipBox.Items)
            {
                mass += m.Weight;
            }
            return mass;
        }

        private int countEnergy()
        {
            int energy = 0;
            foreach (Modul m in shipBox.Items)
            {
                energy += m.Energy;
            }
            return energy;
        }
    }
}
