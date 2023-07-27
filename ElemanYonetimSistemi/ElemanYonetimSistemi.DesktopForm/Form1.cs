using ElemanYonetimSistemi.Business.Interfaces;
using ElemanYonetimSistemi.Domain.Entities;
using ElemanYonetimSistemi.Domain.Entities.Common;
using ElemanYonetimSistemi.Persistence.Contexts;
using ElemanYonetimSistemi.Persistence.Repositories;

namespace ElemanYonetimSistemi.DesktopForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly ElemanYonetimSistemiDbContext _elemanYonetimSistemiDbContext;
        readonly CategoryReadRepository _categoryReadRepository;

        public Form1(ElemanYonetimSistemiDbContext elemanYonetimSistemiDbContext, CategoryReadRepository categoryReadRepository)
        {
            _elemanYonetimSistemiDbContext = elemanYonetimSistemiDbContext;
            _categoryReadRepository = categoryReadRepository;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        public async Task Ekle()
        {
        }

    }
}