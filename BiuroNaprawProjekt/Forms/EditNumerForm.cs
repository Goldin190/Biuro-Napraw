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
    public partial class EditNumerForm : Form
    {
        public NumberClass currNumb;
        public List<string> lokacje;
        private NpgsqlHandler DbManager;

        public EditNumerForm()
        {
            InitializeComponent();
            currNumb = new NumberClass();
            DbManager = new NpgsqlHandler();
            lokacje = new List<string>();
            
        }
        public void IniControls()
        {
            this.NumberNumerical.Value = currNumb.numer;
            this.Stacyjna1Numeric.Value = currNumb.stacyjna[0];
            this.Stacyjna2Numeric.Value = currNumb.stacyjna[1];
            this.Stacyjna3Numeric.Value = currNumb.stacyjna[2];
            this.KoncentratorNumerical.Value = currNumb.koncetntrator;
            this.Liniowa1Numeric.Value = currNumb.liniowa[0];
            this.Liniowa2Numeric.Value = currNumb.liniowa[1];
            this.PrzydzialCombobox.SelectedIndex = currNumb.jwID;
            this.NazwaTextbox.Text = currNumb.nazwa;
            this.AdresTextbox.Text = currNumb.adres;
            this.OgraniczeniaNumeric.Value = currNumb.ograniczenia;
            this.TrasaTextbox.Text = currNumb.trasa;
            this.UwagiTextbox.Text = currNumb.uwagi;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            currNumb.numer = this.NumberNumerical.Value;
            currNumb.stacyjna[0] = this.Stacyjna1Numeric.Value;
            currNumb.stacyjna[1] = this.Stacyjna2Numeric.Value ;
            currNumb.stacyjna[2] = this.Stacyjna3Numeric.Value;
            currNumb.koncetntrator = this.KoncentratorNumerical.Value;
            currNumb.liniowa[0] = this.Liniowa1Numeric.Value;
            currNumb.liniowa[1] = this.Liniowa2Numeric.Value;
            currNumb.jwID = this.PrzydzialCombobox.SelectedIndex+1;
            currNumb.nazwa = this.NazwaTextbox.Text;
            currNumb.adres = this.AdresTextbox.Text;
            currNumb.ograniczenia = this.OgraniczeniaNumeric.Value;
            currNumb.trasa = this.TrasaTextbox.Text;
            currNumb.uwagi = this.UwagiTextbox.Text;
            DbManager.Initialize_connection();
            if (DbManager.CheckConnection())
            {
                if (DbManager.UpdateNumer(currNumb))
                {
                    MessageBox.Show("Uaktualniono numer !");
                }
                else
                {
                    MessageBox.Show("Operacja nie powiodła się !");
                }
            }
            else
            {
                MessageBox.Show(DbManager.eMessage);
            }
            
        }
        private void populateCombobox()
        {
            this.PrzydzialCombobox.DataSource = lokacje;
        }
        private void EditNumerForm_Load(object sender, EventArgs e)
        {
            this.populateCombobox();
            IniControls();
            
        }

        private void Stacyjna1Numeric_ValueChanged(object sender, EventArgs e)
        {
            this.KoncentratorNumerical.Value = (sender as NumericUpDown).Value;
        }

        private void LiniowaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
