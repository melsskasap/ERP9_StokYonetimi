using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.ComplexTypes;
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
    public partial class LoginForm : Form
    {
        private IRepository<Client, int> _clientRepository;
        public LoginForm()
        {
            InitializeComponent();
            _clientRepository = new Repository<Client, int>();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var model = new LoginViewModel()
            {
                Email = txtEmail.Text,
                Password = txtSifre.Text
            };

            var user = _clientRepository.Query(predicate: X => X.Email == model.Email && X.Password == model.Password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show(text: "Email veya Şifre Hatalıdır!");
                return;
            }
            else
            {
                MessageBox.Show("Hoşgeldiniz ");
                
            }
            StockSettings.UserInfo = new UserInfoViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname,
                ApplicationRole = user.ApplicationRole
            };
            this.Close();
        }
    }
}
