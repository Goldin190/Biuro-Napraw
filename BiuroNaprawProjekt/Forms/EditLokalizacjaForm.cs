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
    public partial class EditLokalizacjaForm : Form
    {
        public Lokalizacja currLok;
        string iniName;
        private List<Lokalizacja> Lokalizacje;
        private NpgsqlHandler DbManager;
        public EditLokalizacjaForm()
        {
            DbManager = new NpgsqlHandler();
            if (DbManager.Initialize_connection())
            {
                this.Lokalizacje =  DbManager.SelectLokacje();
                
            }
            InitializeComponent();
            
            
        }

        private void EditLokalizacjaForm_Load(object sender, EventArgs e)
        {
            this.NazwaTextbox.Text = currLok.nazwa;
        }
        private bool ValidateInput()
        {
            if (this.NazwaTextbox.Text != "")
            {
                foreach (Lokalizacja lok in Lokalizacje)
                {
                    if (lok.nazwa != currLok.nazwa && this.NazwaTextbox.Text == lok.nazwa)
                    {
                        MessageBox.Show("Lokalizacja już istnieje");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij nazwę lokalzacji");
                return false;
            }
            return true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateInput())
            {
                if (DbManager.Initialize_connection())
                {
                    if (DbManager.CheckConnection())
                    {
                        if (DbManager.UpdateLokacje(currLok.id, this.NazwaTextbox.Text))
                        {
                            MessageBox.Show("Dodano Lokalizację");
                        }
                    }
                    else
                    {
                        MessageBox.Show(DbManager.eMessage);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Błąd Połączenia");
                }
            }
                       
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
