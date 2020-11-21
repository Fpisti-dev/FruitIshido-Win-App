using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Data.SqlClient;

namespace FruitIshido
{
    public partial class TOP10Form : Form
    {
        public TOP10Form()
        {
            InitializeComponent();
        }        

        private void TOP10Form_Load(object sender, EventArgs e)
        {          

            try
            {
                // Declare data table object
                DataTable dTable = new DataTable();

                //Stored procedure
                string sStoredProc = "SP_Read_Top10";

                // a list of parameters for stored procedors only!
                List<string> sParams = new List<string>();
                sParams.Clear();

                Data da = new Data();

                SqlDataReader objDataReader = da.ExecuteReader(sStoredProc, sParams);

                dTable.Load(objDataReader);

                objDataReader.Close();     

                // Fill datagrid
                dgvTOP10.DataSource = dTable;

                dgvTOP10.Columns[0].ReadOnly = true;
                dgvTOP10.Columns[1].ReadOnly = true;
                dgvTOP10.Columns[0].HeaderText = "Nick Name";
                dgvTOP10.Columns[1].HeaderText = "Score";                
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }            
        }
    }
}
