using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MyLibrary;

namespace PalcoNet.Comprar
{
    public partial class FormToBuy : Form
    {
        public static string systemDate = ConfigurationManager.AppSettings["FechaSistema"];
        private const int pageSize = 10;
        private int totalRecords;
        private DataSet ds;

        public FormToBuy()
        {
            InitializeComponent();
            dtp_date_from.MinDate = DateTime.Parse(systemDate.ToString());
            dtp_date_to.MinDate = DateTime.Parse(systemDate.ToString());

            LoadCombos();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            int offset = (int) bindingSource1.Current;

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
            public int totalRecords { get; set; }

            public PageOffsetList(int totalRecors)
            {
                this.totalRecords = totalRecors;
            }

            public System.Collections.IList GetList()
            {
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < this.totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);

                return pageOffsets;
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_date_from_ValueChanged(object sender, EventArgs e)
        {
            dtp_date_to.MinDate = dtp_date_from.Value;
        }

        private void LoadCombos()
        {
            SqlDataReader reader = BuyConnection.GetCategories();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = Convert.ToString(reader.GetSqlString(1));
                    item.Value = reader.GetInt32(0); // reader.GetSqlInt32(0);
                    
                    cmb_1.Items.Add(item);
                    cmb_2.Items.Add(item);
                    cmb_3.Items.Add(item);
                }
            }

            reader.Close();

            cmb_1.SelectedIndex = 0;
            cmb_2.SelectedIndex = 0;
            cmb_3.SelectedIndex = 0;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int grade1 = 0;
            int grade2 = 0;
            int grade3 = 0;

            ComboboxItem item = new ComboboxItem();
            item = (ComboboxItem)cmb_1.SelectedItem;
            grade1 = (int)item.Value;

            item = (ComboboxItem)cmb_2.SelectedItem;
            grade2 = (int)item.Value;

            item = (ComboboxItem)cmb_3.SelectedItem;
            grade3 = (int)item.Value;

            DataSet ds = BuyConnection.ListExistingPublications(dtp_date_from.Value.Date
                                                                       , dtp_date_to.Value.Date
                                                                       , txt_desc.Text
                                                                       , grade1 //(cmb_1.Text != "") ? cmb_1.Text.Substring(0,1) : null
                                                                       , grade2 //(cmb_2.Text != "") ? cmb_2.Text.Substring(0,1) : null
                                                                       , grade3); //(cmb_3.Text != "") ? cmb_3.Text.Substring(0,1) : null);
            ds = EmpresaConnection.ListExistingEmpresa(null);
            this.ds = ds;
            dgv_list.DataSource = this.ds.Tables[0];
            this.totalRecords = dgv_list.Rows.Count;
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList(this.totalRecords);
        }

    }
}
