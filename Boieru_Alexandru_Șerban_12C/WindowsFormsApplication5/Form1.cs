using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazin_Electrocasnice_si_ElectroniceDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazin_Electrocasnice_si_ElectroniceDataSet.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.magazin_Electrocasnice_si_ElectroniceDataSet.Clienti);
            magazin_Electrocasnice_si_ElectroniceDataSet.EnforceConstraints = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            



        }
    }
}
