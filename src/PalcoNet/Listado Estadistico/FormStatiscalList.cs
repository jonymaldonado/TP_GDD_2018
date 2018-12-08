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
using System.Configuration;
using System.Data.SqlClient;

namespace PalcoNet.Listado_Estadistico
{
    public partial class FormStatiscalList : Form
    {
        public static string systemDate = ConfigurationManager.AppSettings["FechaSistema"];

        public FormStatiscalList()
        {
            InitializeComponent();

            LoadComboYears();
            LoadComboQuarters();
            LoadComboListings();
            ViewFieldsFilter(false);
        }

        private void LoadComboYears()
        {
            string a = systemDate;
            DateTime b = DateTime.Parse(a.ToString());
            int yearCurrent = b.Year;

            for (int i = 2018; i <= yearCurrent; i++) cmb_year.Items.Add(i);

            cmb_year.SelectedIndex = cmb_year.Items.Count - 1;
        }

        private void LoadComboQuarters()
        {
            cmb_trimester.Items.Add(1);
            cmb_trimester.Items.Add(2);
            cmb_trimester.Items.Add(3);
            cmb_trimester.Items.Add(4);

            cmb_trimester.SelectedIndex = 0;
        }

        private void LoadComboListings()
        {
            cmb_list.Items.Insert(0, "Clientes con mayores puntos vencidos");
            cmb_list.Items.Insert(1, "Clientes con mayor cantidad de compras");
            cmb_list.Items.Insert(2, "Empresas con mayor cantidad de localidades no vendidas");

            cmb_list.SelectedIndex = 0;
        }

        private void ViewFieldsFilter(bool state)
        {
            lbl_grade_visibility.Visible = state;
            cmb_grade_visibility.Visible = state;
            lbl_month.Visible = state;
            cmb_month.Visible = state;
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_list.SelectedIndex == 2)
            {
                cmb_grade_visibility.Items.Clear();
                LoadComboPriorities();
                ViewFieldsFilter(true);
                cmb_grade_visibility.SelectedIndex = 0;
            }
            else
            {
                ViewFieldsFilter(false);
            }
        }

        private void LoadComboPriorities()
        {
            SqlDataReader reader = StatiscalListConnection.GetPriorities();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //cmb_grade_visibility.Items.Add(reader.GetString(0));
                    ComboboxItem item = new ComboboxItem();
                    item.Text = reader.GetString(1);
                    item.Value = reader.GetInt32(0);
                    cmb_grade_visibility.Items.Add(item);

                }
            }

            reader.Close();
        }

        private void cmb_trimester_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_trimester.SelectedIndex)
            {
                case 0: cmb_month.Items.Clear(); LoadComboMonths("Enero", 1,"Febrero",2, "Marzo",3); break;
                case 1: cmb_month.Items.Clear();  LoadComboMonths("Abril", 4,"Mayo",5, "Junio",6); break;
                case 2: cmb_month.Items.Clear();  LoadComboMonths("Julio",7, "Agosto", 8, "Septiembre",9); break;
                case 3: cmb_month.Items.Clear();  LoadComboMonths("Octubre",10, "Noviembre",11, "Diciembre",12); break;
            }
        }

        private void LoadComboMonths(String month1, int m1, String month2, int m2, String month3, int m3)
        {

            ComboboxItem item = new ComboboxItem();

            item.Text = month1;
            item.Value = m1;
            cmb_month.Items.Add(item);

            item = new ComboboxItem();
            item.Text = month2;
            item.Value = m2;
            cmb_month.Items.Add(item);

            item = new ComboboxItem();
            item.Text = month3;
            item.Value = m3;
            cmb_month.Items.Add(item);

            cmb_month.SelectedIndex = 0;
        }

        private void btn_to_list_Click(object sender, EventArgs e)
        {
            //String gradeVisibility = "";
            //String month = "";
            int gradeVisibility = 0;
            int month = 0;

            int year = int.Parse(cmb_year.Text);
            int monthFrom = cmb_trimester.SelectedIndex * 3 + 1;
            int monthTo = monthFrom + 2;

            DateTime dateFrom = new DateTime(year, monthFrom, 1);
            DateTime dateTo;

            if (cmb_trimester.SelectedIndex == 0 || cmb_trimester.SelectedIndex == 3) dateTo = new DateTime(year, monthTo, 31);
            else dateTo = new DateTime(year, monthTo, 30);

            String selectedList = "";

            switch (cmb_list.SelectedIndex)
            {
                case 0: 
                    selectedList = "EL_GROUP_BY.LISTAR_CLIENTES_MAYORES_PUNTOS_VENCIDOS";
                    year = 0; //El año no se usa en este sp, no debe mandarse
                    break;
                case 1: 
                    selectedList = "EL_GROUP_BY.LISTAR_CLIENTES_MAYOR_CANTIDAD_COMPRAS";
                    year = 0; //El año no se usa en este sp, no debe mandarse
                    break;
                case 2:
                    {
                        selectedList = "EL_GROUP_BY.LISTAR_EMPRESAS_MAYOR_CANTIDAD_LOCALIDADES_NO_VENDIDAS";

                        ComboboxItem item = new ComboboxItem();
                        item = (ComboboxItem)cmb_grade_visibility.SelectedItem;
                        gradeVisibility = (int)item.Value; 
                        
                        item = new ComboboxItem();
                        item = (ComboboxItem)cmb_month.SelectedItem;
                        month = (int)item.Value; 
                        
                        break;
                    }
            }

            dgv_list.DataSource = StatiscalListConnection.GenerateSelectedList(selectedList, dateFrom, dateTo, gradeVisibility, month, year).Tables[0];

            if (dgv_list.RowCount == 0) MessageBox.Show("La filtros ingresados no han generado estadísticas.");
        }

        private void returnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
