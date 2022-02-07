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
    public partial class CreateNumberForm : Form
    {
        public List<decimal> existingNumers;
        public List<string> lokacje;
        private NumberClass currNumb;
        private NpgsqlHandler DbManager;
        string Message;
        
        private bool CheckIfNumberExists(decimal number)
        {
            foreach(decimal n in existingNumers)
            {
                if(number == n)
                {
                    Message += "Numer już istnieje \n";
                    return true;
                }
            }
            return false;
        }
        public void populateCombobox()
        {
            this.PrzydzialCombobox.DataSource = lokacje.ToArray();
        }
        public CreateNumberForm()
        {
            Message = "";            
            InitializeComponent();
            existingNumers = new List<decimal>();
            lokacje = new List<string>();
            currNumb = new NumberClass();
            DbManager = new NpgsqlHandler();
            populateCombobox();
            
        }
        private bool CheckForEmpyFields()
        {
            bool returnValue = false;
            if (this.Stacyjna1Numeric.Value == 0 && this.Stacyjna2Numeric.Value == 0 && this.Stacyjna3Numeric.Value == 0)
            {
                Message += "Uzupełnij pole \'Stacyjna\' \n";
                returnValue = true;

            }
            if (this.NazwaTextbox.Text == "" || this.NazwaTextbox.Text == null)
            {
                Message += "Uzupełnij pole \'Nazwa\' \n";
                returnValue = true;
            }
            if (this.AdresTextbox.Text == "" || this.AdresTextbox.Text == null)
            {
                Message += "Uzupełnij pole \'Adres\' \n";
                returnValue = true;
            }

            return returnValue;
        }
        private bool ValidateInput()
        {
            Message += "Błędne dane, proszę poprawić :\n";
            if (CheckIfNumberExists(this.NumberNumerical.Value) || CheckForEmpyFields())
            {
                MessageBox.Show(Message);
                Message = "";
                return false;
            }
            Message = "";
            return true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                AddNumber();
            }
        }
        private void AddNumber()
        {
            List<string> record = new List<string>();
            
            record.Add(this.NumberNumerical.Value.ToString());
            record.Add(this.Stacyjna1Numeric.Value.ToString() + "-"+
                this.Stacyjna2Numeric.Value.ToString() + "-" +
                this.Stacyjna3Numeric.Value.ToString());
            record.Add(this.KoncentratorNumerical.Value.ToString());
            record.Add(this.Liniowa1Numeric.Value.ToString() + "-" +
                this.Liniowa2Numeric.Value.ToString());
            record.Add((this.PrzydzialCombobox.SelectedIndex + 1).ToString());
            record.Add(this.NazwaTextbox.Text);
            record.Add(this.AdresTextbox.Text);
            record.Add(this.OgraniczeniaNumeric.Value.ToString());
            record.Add(this.TrasaTextbox.Text);
            record.Add(this.UwagiTextbox.Text);
            currNumb.stacyjna = new List<decimal>();
            currNumb.PopulateFromList(record);
            DbManager.Initialize_connection();
            if (DbManager.CheckConnection())
            {
                if (DbManager.AddNumber(this.currNumb))
                {
                    MessageBox.Show("Dodano numer pomyślnie");
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
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumberNumerical_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Stacyjna1Numeric_ValueChanged(object sender, EventArgs e)
        {
            this.KoncentratorNumerical.Value = this.Stacyjna1Numeric.Value;
        }

        private void CreateNumberForm_Load(object sender, EventArgs e)
        {
            
        }

        private void PrzydzialCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
 * currNumb.stacyjna[0] = this.Stacyjna1Numeric.Value;
            currNumb.stacyjna[1] = this.Stacyjna2Numeric.Value;
            currNumb.stacyjna[2] = this.Stacyjna3Numeric.Value;
            currNumb.koncetntrator = this.KoncentratorNumerical.Value;
            currNumb.liniowa[0] = this.Liniowa1Numeric.Value;
            currNumb.liniowa[1] = this.Liniowa2Numeric.Value;
            currNumb.jwID = this.PrzydzialCombobox.SelectedIndex + 1;
            currNumb.nazwa = this.NazwaTextbox.Text;
            currNumb.adres = this.AdresTextbox.Text;
            currNumb.ograniczenia = this.OgraniczeniaNumeric.Value;
            currNumb.trasa = this.TrasaTextbox.Text;
            currNumb.uwagi = this.UwagiTextbox.Text;
*/
