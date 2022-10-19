using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using ThunderTodo.Domain;
using ThunderTodo.Sqlsugar;
using ThunderTodo.Utils;

namespace ThunderTodo
{
    public partial class LoginForm : XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = TxtUserName.Text.Trim(),
                Password = TxtPassword.Text.Trim()
            };

            Util.CurrentUser = SqlsugarHelper.GetInstance().Queryable<User>().Where(c => c.Name.Equals(user.Name) && c.Password.Equals(user.Password)).First();

            if (Util.CurrentUser != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show("账号或密码错误");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}