using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataDictonary_DynamicSQL
{
    public partial class Form1 : Form
    {
        const string connString = @"Server=PL11\MTCDEVDB;Database=master;Trusted_Connection=True;";
        SqlConnection sqlConn = new SqlConnection(connString);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("sp_SelectAllDatabases", sqlConn);
            DataTable dtDatabases = new DataTable();
            int dbID;
            string DatabaseName;
            try
            {
                sqlDa.Fill(dtDatabases);

                foreach(DataRow drDbName in dtDatabases.Rows)
                {
                    dbID = int.Parse(drDbName.ItemArray[1].ToString());
                    DatabaseName = drDbName.ItemArray[0].ToString();
                    ComboObject comboObject = new ComboObject(dbID, DatabaseName);
                    cbDataBaseNames.Items.Add(comboObject.DatabaseName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbDataBaseNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Create a ComboObject and set it to the current dropdown box value
            ComboObject currentObject = (ComboObject)cbDataBaseNames.SelectedItem;
            int DatabaseID = currentObject.DatabaseID;
            string xtype = @"'U','ID','V','P'";
            DataTable dtTables = new DataTable();

            try
            {
                //Declare a SQL Command, give it the stored procedure and SQL Connection
                SqlCommand sqlCommand = new SqlCommand("sp_SelectAllTablesFromDatabase", sqlConn);
                /*Set the Command type to Stored Procedure*/
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue(@"databaseID", DatabaseID);
                sqlCommand.Parameters.AddWithValue(@"xtype", xtype);

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCommand);
                sqlDA.Fill(dtTables);

                dgvTablesView.DataSource = dtTables;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public class ComboObject
        {
            int dbID;
            string dbName;

            public ComboObject(int DatabaseID, string DatabaseName)
            {
                dbID = DatabaseID;
                dbName = DatabaseName;
            }

            public string DatabaseName
            {
                get { return dbName; }
                set { dbName = value; }
            }

            public int DatabaseID
            {
                get { return dbID; }
                set { dbID = value; }
            }
        }

        
    }
}
