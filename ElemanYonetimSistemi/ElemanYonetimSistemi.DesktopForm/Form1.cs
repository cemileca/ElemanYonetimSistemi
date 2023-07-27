using ElemanYonetimSistemi.Business.Interfaces;
using ElemanYonetimSistemi.Domain.Entities;
using ElemanYonetimSistemi.Domain.Entities.Common;
using ElemanYonetimSistemi.Persistence.Repositories;

namespace ElemanYonetimSistemi.DesktopForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      private  readonly CategoryWriteRepository _categoryWriteRepository;

       
        private async void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        public async Task Ekle()
        {
            Category category = new Category();
            category.CategoryName = "jhfkhfkjrhg";
            category.CategoryDescription = "jhdkjfhdhfgdkf";
            await _categoryWriteRepository.AddAsync(category);
            await _categoryWriteRepository.SaveAsync();
           
            MessageBox.Show("Test");
        }

    }
}