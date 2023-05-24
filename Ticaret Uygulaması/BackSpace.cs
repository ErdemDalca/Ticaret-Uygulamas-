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
using System.Xml;
using Ticaret_Uygulaması.Sınıflar;

namespace Ticaret_Uygulaması
{
	public partial class BackSpace : Form
	{
		private string AuthDomain;
		private string ApiKey;
		private string FDDdomain;
		private string FSDdomain;
		private Ayarlar ayarlar;

		public LogInUC logIn;
		public SignInUC signIn;

		private FirebaseAuthClient client;

		public BackSpace(Ayarlar ayarlar)
		{
			InitializeComponent();

			this.ayarlar = ayarlar;
			this.AuthDomain = ayarlar.AuthDomain;
			this.ApiKey = ayarlar.ApiKey;
			this.FDDdomain = ayarlar.FDDomain;
			this.FSDdomain = ayarlar.FSDomain;

			yüklemePanel.BackColor = Color.FromArgb(128, Color.Gray);

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

		public async void SigninBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var userCredential = await client.CreateUserWithEmailAndPasswordAsync(signIn.emailTxt.Text.Trim(), signIn.passwordTxt.Text.Trim());
                
                MessageBox.Show("Kullanıcı ıd: "+userCredential.User.Info.Uid + "\nBaşarıyla Oluşturuldu.\nGiriş ekranına yönlendiriliyorsunuz");
				
                

                userCredential.User.Info.LastName = signIn.soyisimtextbox.Text;


                lb_Click(this, new EventArgs());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Kaıt İşlemi Başarısız :" + ex.Message);
			}
			finally
			{

			}
		}

		private async void LoginBtn_Click(object sender, EventArgs e)
		{
			yüklemePanel.Visible = true;
			logIn.loginBtn.Enabled = false;
			try
			{
				var userCredential = await client.SignInWithEmailAndPasswordAsync(logIn.emailTxt.Text.Trim(),
																			  logIn.passwordTxt.Text.Trim());
				//MessageBox.Show(userCredential.User.Info.Uid);

				//buradan devam edecek giriş işlemi.

				var menu = new MenuScreen(userCredential,ayarlar);
                this.Hide();//backspace'i kapattı/sakladı.
                menu.Closed += (s, args) => this.Close();
				menu.Show();
				
			}
			catch(Exception ex) 
			{
				MessageBox.Show("Giriş İşlemi Başarısız :" + ex.Message);
				logIn.loginBtn.Enabled = true;
				yüklemePanel.Visible = false;
			}
			finally
			{

			}
			yüklemePanel.Visible =false;
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

		private void BackSpace_Load(object sender, EventArgs e)
		{
			Timer timer = new Timer();
			timer.Interval = 500; // 10 milisaniye

			// Zamanlayıcı her çalıştığında ne yapacağını belirle
			timer.Tick += (s, args) =>
			{
				// Barın değerini %1 arttır
				cpb.Increment(cpb.Maximum / 20);

				// Barın değeri maksimuma ulaştıysa sıfırla
				if (cpb.Value == cpb.Maximum)
					cpb.Value = 0;
			};

			// Zamanlayıcıyı başlat
			timer.Start();
		}
	}
}
