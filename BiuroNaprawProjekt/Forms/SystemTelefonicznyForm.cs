using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiuroNaprawProjekt.Forms
{
    public partial class SystemTelefonicznyForm : Form
    {
        private List<Lokalizacja> LokacjeList;
        private List<NumberClass> NumberList;
        private ListViewColumnSorter lvwColumnSorter;
        private List<bool> FieldsToSearchBy;
        private Form activeForm;
        public NpgsqlHandler DbManager;

        public SystemTelefonicznyForm()
        {
            DbManager = new NpgsqlHandler();
            LokacjeList = new List<Lokalizacja>();
            NumberList = new List<NumberClass>();
            FieldsToSearchBy = new List<bool>();
            for(int i = 0; i < 10; i++)
            {
                FieldsToSearchBy.Add(false);
            }
            ClearFieldSelection();
            
            
            InitializeComponent();
            if (DbManager.Initialize_connection())
            {
                if (DbManager.CheckConnection())
                {
                    NumberList = DbManager.SelectNumbers();
                    LokacjeList = DbManager.SelectLokacje();
                    this.LoadDataToListBox();
                    this.LoadDataToComboBox();
                }
                else
                {
                    MessageBox.Show(DbManager.eMessage);
                }

            }
            else
            {
                MessageBox.Show("Xml Failed");
            }

            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
        }

        public void UpdateData()
        {
            DbManager.Initialize_connection();
            NumberList = DbManager.SelectNumbers();
            LokacjeList = DbManager.SelectLokacje();
            this.LoadDataToListBox();

        }
        private void LoadDataToListBox()
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            this.listView1.Items.Clear();
            foreach (NumberClass number in NumberList)
            {
                List<string> numberRow = number.ToList(LokacjeList[(number.jwID-1)].nazwa);
                ListViewItem listViewItem = new ListViewItem(numberRow[0], 0);
                for (int i = 1; i < numberRow.Count; i++)
                {
                    listViewItem.SubItems.Add(numberRow[i]);
                }
                listViewItems.Add(listViewItem);
            }
            foreach(ListViewItem item in listViewItems)
            {
                this.listView1.Items.Add(item);
            }
        }
        private void LoadDataToComboBox()
        {
            List<string> lokacjeStringList = new List<string>();
            foreach (Lokalizacja lokalizacja in LokacjeList)
            {
                lokacjeStringList.Add(lokalizacja.nazwa);
            }
            this.LokacjaCombobox.DataSource = lokacjeStringList;
        }
        private void LoadDataToListBox(List<NumberClass> searchList)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            this.listView1.Items.Clear();
            foreach (NumberClass number in searchList)
            {
                List<string> numberRow = number.ToList(LokacjeList[(number.jwID - 1)].nazwa);
                ListViewItem listViewItem = new ListViewItem(numberRow[0], 0);
                for (int i = 1; i < numberRow.Count; i++)
                {
                    listViewItem.SubItems.Add(numberRow[i]);
                }
                listViewItems.Add(listViewItem);
            }
            foreach (ListViewItem item in listViewItems)
            {
                this.listView1.Items.Add(item);
            }
        }
        private void SystemTelefonicznyForm_Load(object sender, EventArgs e)
        {
            
        }
        

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listView1.Sort();
        }
        private void LoadChildForm(object sender, Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.Dock = DockStyle.None;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.Parent.Parent.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Show();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Forms.CreateNumberForm createNumber = new Forms.CreateNumberForm();
           
            foreach(NumberClass number in NumberList)
            {
                createNumber.existingNumers.Add(number.numer);
            }
            foreach(Lokalizacja lok in LokacjeList)
            {
               createNumber.lokacje.Add(lok.nazwa);
            }
            createNumber.populateCombobox();
            createNumber.FormClosed += new FormClosedEventHandler(ChildClosed);
            LoadChildForm(sender, createNumber);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            if(this.listView1.SelectedItems != null && this.listView1.SelectedItems.Count != 0)
            {
                List<string> row = new List<string>();
                List<string> lokacje = new List<string>();
                Forms.EditNumerForm edit = new Forms.EditNumerForm();
                
                int id = 0;
                for(int i = 0; i < this.listView1.SelectedItems[0].SubItems.Count; i++)
                {
                    row.Add(this.listView1.SelectedItems[0].SubItems[i].Text);
                }
                foreach (Lokalizacja lok in LokacjeList)
                {
                    if (row[4] == lok.nazwa)
                    {
                        id = LokacjeList.IndexOf(lok);
                    }
                    edit.lokacje.Add(lok.nazwa);
                }
                
                edit.currNumb.PopulateFromList(row,id);
                
                //edit.IniControls();
                edit.FormClosed += new FormClosedEventHandler(ChildClosed);
                 
                LoadChildForm(sender, edit);
            }
        }
        void ChildClosed(object sender, EventArgs e)
        {
            this.UpdateData();
        }
        private void SystemTelefonicznyForm_Shown(object sender, EventArgs e)
        {

        }
        private void SystemTelefonicznyForm_Activated(object sender, EventArgs e)
        {
        }
        private void SystemTelefonicznyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void SearchGroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
           this.LoadDataToListBox( SearchForMatchingItemsInList(CreateSearchPatternObject()));
        }
        private List<NumberClass> SearchForMatchingItemsInList(List<string> pattern)
        {
            bool match = true;
            List<NumberClass> searchList = new List<NumberClass>();
            foreach(NumberClass number in this.NumberList)
            {
                match = true;
                List<string> numberAsString = number.ToList();
                for(int i = 0; i < pattern.Count; i++)
                {
                    if (this.FieldsToSearchBy[i])
                    {
                        if (!numberAsString[i].Contains(pattern[i]))
                        {
                            if(i == 4)
                            {
                                if(number.jwID != int.Parse(pattern[i]))
                                {
                                    match = false;
                                }
                            }
                            else
                            {
                                match = false;
                            }
                            
                        }
                    }
                }
                if (match) {
                    
                    searchList.Add(number);
                }
            }
            return searchList;

        }
        private List<string> CreateSearchPatternObject()
        {
            List<string> pattern = new List<string>()
            {
                this.NumerNumeric.Value.ToString(),
                this.Stacyjna1Numeric.Value.ToString() + "-" +
                this.Stacyjna2Numeric.Value.ToString() + "-" +
                this.Stacyjna3Numeric.Value.ToString(),
                this.KoncentratorNumeric.Value.ToString(),
                this.Liniowa1Numeric.Value.ToString() + "-" +
                this.Liniowa2Numeric.Value.ToString(),
                (this.LokacjaCombobox.SelectedIndex +1).ToString(),
                this.NazwaTextBox.Text,
                this.AdresTextbox.Text,
                this.OgraniczeniaNumeric.Value.ToString(),
                this.TrasaTextbox.Text,
                this.UwagiTextbox.Text
            };
            return pattern;

        }
        private void ClearFieldSelection()
        {
            for (int i = 0; i < 10; i++)
            {
                FieldsToSearchBy[i] = false;
            }
        }

        private void ClearAllFields()
        {
            
            foreach(Control control in this.SearchGroupbox.Controls)
            {
                if(control.GetType().Equals(typeof(NumericUpDown)))
                {
                    (control as NumericUpDown).Value = 0;
                }else if (control.GetType().Equals(typeof(TextBox)))
                {
                    (control as TextBox).Text = "";
                }else if (control.GetType().Equals(typeof(ComboBox)))
                {
                    (control as ComboBox).SelectedIndex = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ClearAllFields();
            this.ClearFieldSelection();
        }
        private void NumerNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[0] = true;
        }
        private void Stacyjna1Numeric_ValueChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[1] = true;
        }

        private void Stacyjna2Numeric_ValueChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[1] = true;
        }

        private void Stacyjna3Numeric_ValueChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[1] = true;
        }

        private void KoncentratorNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[2] = true;
        }

        private void Liniowa1Numeric_ValueChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[3] = true;
        }

        private void Liniowa2Numeric_ValueChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[3] = true;
        }

        private void LokacjaCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[4] = true;
        }

        private void NazwaTextBox_TextChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[5] = true;
        }

        private void AdresTextbox_TextChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[6] = true;
        }
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[7] = true;
        }

        private void TrasaTextbox_TextChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[8] = true;
        }

        private void UwagiTextbox_TextChanged(object sender, EventArgs e)
        {
            this.FieldsToSearchBy[9] = true;
        }
    }
}
