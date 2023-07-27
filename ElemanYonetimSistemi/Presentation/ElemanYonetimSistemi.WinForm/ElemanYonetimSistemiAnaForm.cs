using ElemanYonetimSistemi.Domain.Entities.Common;

namespace ElemanYonetimSistemi.WinForm
{
    public partial class ElemanYonetimSistemiAnaForm : Form
    {
        public ElemanYonetimSistemiAnaForm()
        {
            InitializeComponent();
        }



        private void ElemanYonetimSistemiAnaForm_Load(object sender, EventArgs e)
        {
            Personal pp = new Personal();
            pp.IndividualNo = "jhfjhfd";
            pp.FirstName = "nanay";
            pp.Lastname = "dayday";
            pp.BirthDate = DateTime.Now;
            pp.PhotoUrl = "http";
            MessageBox.Show("Test");
        }
    }
}
