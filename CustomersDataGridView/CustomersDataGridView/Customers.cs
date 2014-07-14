/* Class:	CustomersDataGridView
 * Name:	Rick Larsen
 * Date:	8/15/2013
 * Purpose:	Enable users to view database records for Customers table in a grid layout. Users can 
 *          edit, delete, or create new records. 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomersDataGridView
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        // event handler for save button
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.customersDataSet);
            }

            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Grid is loaded with records when form loads.
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.Fill(this.customersDataSet.Customers);
            }

            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
