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
    public partial class AddLokalizacjaForm : Form
    {
        public NpgsqlHandler DbManager;
        public List<Lokalizacja> lokalizace;
        public AddLokalizacjaForm()
        {
            DbManager = new NpgsqlHandler();
            InitializeComponent();
        }

        private bool isDuplicate()
        {
            for(int i = 0; i < lokalizace.Count; i++)
            {
                if(this.NazwaTextbox.Text == lokalizace[i].nazwa)
                {
                    return true;
                }
            }
            return false;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(this.NazwaTextbox.Text != "")
            {
                if (DbManager.Initialize_connection())
                {
                    if (isDuplicate())
                    {
                        MessageBox.Show("Lokalizacja już istnieje");
                    }
                    else
                    {
                        if (DbManager.CheckConnection())
                        {
                            DbManager.InsertLokacje(this.NazwaTextbox.Text);
                            MessageBox.Show("Dodano Lokalizację");
                        }
                        else
                        {
                            MessageBox.Show(DbManager.eMessage);
                        }
                        
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

        private void AddLokalizacjaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
