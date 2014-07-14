/* Class:	CustomerNames 
 * Name:	Rick Larsen
 * Date:	8/3/2013 
 * Purpose:	Enable users to retrieve a list of customer names from database.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CustomerNames
{
    public partial class Form1 : Form
    {
        private SqlConnection dbConn;
        private SqlCommand dbCmd;
        private SqlDataReader dbReader;
        private Member aMember;
        private string sConnection;
        private string sql;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                // Store the ConnectionState string                
                sConnection = "Data Source=RICKLARSEN-PC;Initial Catalog=Customers;Integrated Security=True;Pooling=False";
                dbConn = new SqlConnection(sConnection);
                dbConn.Open();

                // Store the SQL query
                sql = "SELECT * FROM Customers ORDER BY LastName ASC, FirstName ASC;";
                dbCmd = new SqlCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                // Create a dbReader object.
                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    aMember = new Member
                        (dbReader["FirstName"].ToString(),
                        dbReader["LastName"].ToString());
                    this.lstCustomerNames.Items.Add(aMember);
                }
                dbReader.Close();
                dbConn.Close();
            }

            catch (System.Exception exc)
            {
                this.lblErrorMsg.Text = exc.Message;
            }
        }
    }
}
