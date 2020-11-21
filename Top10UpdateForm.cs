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
using System.Diagnostics;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace FruitIshido
{
    public partial class Top10UpdateForm : Form
    {
        public Top10UpdateForm()
        {
            InitializeComponent();
        }


        // Declare data table object
        private DataTable dTable = new DataTable();

        // Get-Set final score
        public int piFinalScore { get; set; }

        private void Top10UpdateForm_Load(object sender, EventArgs e)
        {
            try
            {
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
                dgvTop10Update.DataSource = dTable;

                dgvTop10Update.Columns[0].ReadOnly = true;
                dgvTop10Update.Columns[1].ReadOnly = true;
                dgvTop10Update.Columns[0].HeaderText = "Nick Name";
                dgvTop10Update.Columns[1].HeaderText = "Score";
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            } 
        }        

        private void btnSave_Click(object sender, EventArgs e)
        {           

            if (txtNickName.Text == "")
            {
                MessageBox.Show("Error, you've left empty field", "Score  didn't add",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Stored procedure
                string sStoredProc = "SP_Insert_Top10";

                // a list of parameters for stored procedors only!
                List<string> sParams = new List<string>();
                sParams.Clear();
                sParams.Add("@NickName:" + txtNickName.Text);
                sParams.Add("@Score:" + piFinalScore);


                DataTable dt = new DataTable();

                Data da = new Data();

                int iID = da.SP_InsertRecordReturnID(sStoredProc, sParams);

                if (iID > 0)
                {
                    MessageBox.Show("Nickname: " + txtNickName.Text + Environment.NewLine +
                                        "Score: " + piFinalScore, "Score added to database",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
        }
    }
}
