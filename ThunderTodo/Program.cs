using System;
using System.Windows.Forms;

namespace ThunderTodo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

            try
            {
                //GlobalUtil.ExceptionUtil = new ExceptionUtil();

                //设置应用程序处理异常方式：ThreadException处理
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //处理UI线程异常
                Application.ThreadException += Application_ThreadException;
                //处理非UI线程异常
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //判断是否更新完毕
                //if (args.Length > 0)
                //{
                //    string tag = args[0];
                //    if (tag.StartsWith("upgrade:success"))
                //    {
                //        AppConfig.Version = tag.Split(':')[2];
                //    }
                //}

                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    MainForm form = new MainForm();
                    //form.Init();
                    Application.Run(form);
                }
            }
            catch (Exception ex)
            {
                //string code = ExceptionHelper.CreateInstance.Log(ex);
                //MessageBox.Show($"发生系统错误【{code}】，请联系管理员！", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"发生系统错误【{ex.Message}】，请联系管理员！", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //string code = ExceptionHelper.CreateInstance.Log(e.ExceptionObject as Exception);
            //MessageBox.Show($"发生系统错误【{code}】，请联系管理员！", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show($"发生系统错误【{e.ToString()}】，请联系管理员！", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //string code = ExceptionHelper.CreateInstance.Log(e.Exception);
            //MessageBox.Show($"发生系统错误【{code}】，请联系管理员！", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show($"发生系统错误【{e.ToString()}】，请联系管理员！", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
