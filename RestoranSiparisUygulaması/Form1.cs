// Form1.cs - Giriş ve Kayıt İşlemleri
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestoranSiparisUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
           
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Form2 kayitFormu = new Form2();
            kayitFormu.ShowDialog();
        }

        private void ValidatePassword(string password)
        {
            if (password.Length < 8 || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit))
            {
                MessageBox.Show("Parola en az 8 karakter uzunluğunda, bir büyük harf, bir küçük harf ve bir sayı içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            string eposta = txtEposta.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(eposta) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("E-posta ve Şifre alanları boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = DAL.DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Kullanici WHERE Eposta = @Eposta AND Sifre = @Sifre";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Eposta", eposta);
                    command.Parameters.AddWithValue("@Sifre", sifre);

                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string rol = reader["Rol"].ToString();
                        MessageBox.Show($"Giriş başarılı! Rolünüz: {rol}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (rol == "Müşteri")
                        {
                            MusteriForm musteriForm = new MusteriForm();
                            this.Hide();
                            musteriForm.ShowDialog();
                            this.Show();
                        }
                        else if (rol == "Çalışan")
                        {
                            SiparisForm siparisForm = new SiparisForm();
                            this.Hide();
                            siparisForm.ShowDialog();
                            this.Show();
                        }
                        else if (rol == "Yönetici")
                        {
                            AdminForm adminForm= new AdminForm();  
                            this.Hide(); 
                            adminForm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tanımsız bir rol!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("E-posta veya Şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
