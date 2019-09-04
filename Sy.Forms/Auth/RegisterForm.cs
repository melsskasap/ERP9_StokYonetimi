using Sy.Business.Repository;
using Sy.Core.Entities;
using Sy.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sy.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        private readonly Repository<Client, int> _clientRepository;
        public RegisterForm()
        {
            InitializeComponent();
            _clientRepository = new Repository<Client, int>();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            var model = new RegisterViewModel()
            {
                Email = txtEmail.Text,
                Name = txtAd.Text,
                Surname = txtSoyad.Text,
                Password = txtSifre.Text
            };
            //email var mı kontrol edelim..
            var kontrol = _clientRepository.Query(predicate: X => X.Email == model.Email).Any();
            
            if (kontrol)
            {
                MessageBox.Show(text: "Bu email adresi kullanılmaktadır!");
                return;
            }
            //benzersiz emial kontrolünden sonra kişiyi kaydedelim
            _clientRepository.Insert(new Client()
            {
                Email = model.Email,
                Surname = model.Surname,
                Password = model.Password,
                Name = model.Name

            });
            MessageBox.Show(text: $"Kayıt İşleminiz Başarılıdır. \n {model.Name} {model.Surname}");

            this.Close(); //bulunduğu classı işaret eder.

           

        }
    }
}
