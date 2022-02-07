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
    public partial class JednostkiForm : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        private List<Lokalizacja> lokalizacjeList;
        public NpgsqlHandler DbManager;
        private Form activeForm;
        public JednostkiForm()
        {
            DbManager = new NpgsqlHandler();
            DbManager.Initialize_connection();
            
            
            InitializeComponent();
            if (DbManager.CheckConnection())
            {
                this.GetLokalizacje();
                this.LoadDatatoListView();
            }
            else
            {
                MessageBox.Show(DbManager.eMessage);
            }
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
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
            childForm.FormClosed += new FormClosedEventHandler(ChildClosed);
            childForm.BringToFront();
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Show();
        }
        private void ChildClosed(object sender, EventArgs e)
        {
            this.UpdateDataInListView();
        }
        private void JednostkiForm_Load(object sender, EventArgs e)
        {

        }
        private void GetLokalizacje()
        {
            if (DbManager.Initialize_connection())
            {
                lokalizacjeList = DbManager.SelectLokacje();
            }
            else
            {
                MessageBox.Show("Xml Failed");
            }
        }
        private void UpdateDataInListView()
        {
            this.GetLokalizacje();
            this.listView1.Items.Clear();
            this.LoadDatatoListView();
        }

        private void LoadDatatoListView()
        {
            ListViewItem item;
            foreach(Lokalizacja lok in lokalizacjeList)
            {
                item = new ListViewItem(lok.id.ToString(), 0);
                item.SubItems.Add(lok.nazwa);
                this.listView1.Items.Add(item);
            }
        }

        private void AddLokacjaButton_Click(object sender, EventArgs e)
        {
            Forms.AddLokalizacjaForm addLokalizacjaForm = new Forms.AddLokalizacjaForm();
            addLokalizacjaForm.lokalizace = lokalizacjeList;
            LoadChildForm(sender,addLokalizacjaForm);
        }

        private void UpdateLokalizacjaButton_Click(object sender, EventArgs e)
        {
            Forms.EditLokalizacjaForm edit = new Forms.EditLokalizacjaForm();
            Lokalizacja currLok = new Lokalizacja();
            if(this.listView1.SelectedItems.Count > 0)
            {
                currLok.id = int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text);
                currLok.nazwa = this.listView1.SelectedItems[0].SubItems[1].Text;
                edit.currLok = currLok;
                LoadChildForm(sender, edit);
            }
            
        }

        private void DeleteLokalizacjaButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz usunąć tą instancę ?","Potwierdź usunięcie",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if (this.DbManager.DeleteLokacje(int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text)))
                {
                    MessageBox.Show("Usunięto Lokalizację");
                    this.UpdateDataInListView();
                }
                else
                {
                    MessageBox.Show("Nie udało się usunąć lokalizacji");
                }
            }
            
        }
    }
}
