using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
using System.Data.SqlClient;

namespace PalcoNet.Historial_Cliente
{
    public partial class FormClientHistory : Form
    {
        public int clientId { get; set; }
        public int userId { get; set; }
        private int totalRecords;
        private const int pageSize = 10;
        public DataSet ds;

        public FormClientHistory(int userId)
        {
            InitializeComponent();

            this.userId = userId;
            this.clientId = ClientConnection.GetClientIdWithUserId(userId);
            txt_clientId.Text = Convert.ToString(this.clientId);

            setClientData(this.clientId);
            this.ds = setHistoryData(this.clientId);

            dgv_list.DataSource = this.ds.Tables[0];
            this.totalRecords = this.ds.Tables[0].Rows.Count;
           
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList(this.totalRecords);

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            int offset = (int)bindingSource1.Current;

            DataSet ds1 = this.ds; 
            DataSet ds2 = new DataSet();
            ds2 = ds1.Clone(); 
            
            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
            {
                ds2.Tables[0].ImportRow(ds1.Tables[0].Rows[i]);
            }
            
            dgv_list.DataSource = ds2.Tables[0];
        
        }

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }
            public int totalRecors{ get; set;}

            public PageOffsetList(int totalRecors)
            {
                this.totalRecors = totalRecors;
            }

            public System.Collections.IList GetList()
            {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < this.totalRecors; offset += pageSize)
                    pageOffsets.Add(offset);

                return pageOffsets;
            }
        }


        private void setClientData(int clientId)
        {
            SqlDataReader reader = ClientConnection.GetClientData(clientId);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txt_name.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    txt_surname.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    txt_email.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    txt_number_doc.Text = reader.IsDBNull(3) ? "" : reader.GetDecimal(3).ToString(); ;
                    
                }
            }

            reader.Close();
        }

        private DataSet setHistoryData(int clientId)
        {
            //DataSet ds = ClientConnection.GetHistoryDataByClient(clientId); //.Tables[0];
            DataSet ds = ClientConnection.ListExistingClients(null, null, null, null);

            return ds;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
