using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Ticaret_Uygulaması
{
	public partial class BackSpace : Form
	{
		private string AuthDomain;
		private string ApiKey;

		public LogInUC logIn;
		public SignInUC signIn;

		private FirebaseAuthClient client;

		public BackSpace(string authDomain, string apiKey)
		{
			InitializeComponent();
			this.AuthDomain = authDomain;
			this.ApiKey = apiKey;

			logIn = new LogInUC();
			signIn = new SignInUC();

			lb_Click(this, new EventArgs());

			logIn.loginBtn.Click += LoginBtn_Click;
			signIn.signinBtn.Click += SigninBtn_Click;



			// Configure...
			var config = new FirebaseAuthConfig
			{
				ApiKey = ApiKey,
				AuthDomain = AuthDomain,
				Providers = new FirebaseAuthProvider[] {new EmailProvider()},
			};

			// ...and create your FirebaseAuthClient
			this.client = new FirebaseAuthClient(config);
		}

		private async void SigninBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("kayıt tıklandı");
		}

		private async void LoginBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var userCredential = await client.SignInWithEmailAndPasswordAsync(logIn.emailTxt.Text.Trim(),
																			  logIn.passwordTxt.Text.Trim());
				//MessageBox.Show(userCredential.User.Info.Uid);

				//buradan devam edecek giriş işlemi.

				var menu = new MenuScreen();
                this.Hide();//backspace'i kapattı/sakladı.
                menu.Closed += (s, args) => this.Close();
                menu.Show();
				
				


			}
			catch(Exception ex) 
			{
				MessageBox.Show("Giriş İşlemi Başarısız :" + ex.Message);
			}
			finally
			{

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void lb_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();
			panel1.Controls.Add(logIn);
		}

		private void kb_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();
			panel1.Controls.Add(signIn);
		}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
		
        }

        private void button1_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
