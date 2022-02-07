using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiuroNaprawProjekt
{

    /*
     * credits : 
     * usb icon - <div>Icons made by <a href="https://www.flaticon.com/authors/surang" title="surang">surang</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
     * 
     * 
     */
    public partial class MainWindow : Form
    {
        private Form activeForm;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoadChildForm(object sender, Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BackColor = this.MainPanel.BackColor;
            this.MainPanel.Controls.Add(childForm);
            this.MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SystemTelButton_Click(object sender, EventArgs e)
        {
            LoadChildForm(sender, new Forms.SystemTelefonicznyForm ());            
        }

        private void JwButton_Click(object sender, EventArgs e)
        {
            LoadChildForm(sender,new Forms.JednostkiForm());
        }

        private void StatysytkaButton_Click(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            LoadChildForm(sender, new Forms.About());
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
