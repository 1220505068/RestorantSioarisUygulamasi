using MySql.Data.MySqlClient;
using RestoranSiparisUygulaması.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace RestoranSiparisUygulaması
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadSiparisRaporu();
            LoadMenu();
        }

        private void LoadSiparisRaporu()
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = @"
                        SELECT 
                            s.SiparisID, 
                            m.UrunAdi, 
                            sd.Miktar, 
                            s.ToplamTutar, 
                            s.SiparisDurumu 
                        FROM siparis s
                        JOIN siparisdetay sd ON s.SiparisID = sd.SiparisID
                        JOIN menu m ON sd.UrunID = m.UrunID
                        ORDER BY s.SiparisID DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewSiparisRapor.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void LoadMenu()
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT UrunID, UrunAdi, Kategori, Fiyat FROM menu ORDER BY Kategori, UrunAdi";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewMenu.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "INSERT INTO menu (UrunAdi, Fiyat, Kategori) VALUES (@UrunAdi, @Fiyat, @Kategori)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text.Trim());
                    command.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(txtFiyat.Text.Trim()));
                    command.Parameters.AddWithValue("@Kategori", txtKategori.Text.Trim());

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ürün eklendi.");
                    LoadMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                int urunID = Convert.ToInt32(dataGridViewMenu.SelectedRows[0].Cells["UrunID"].Value);

                using (MySqlConnection connection = DatabaseHelper.GetConnection())
                {
                    try
                    {
                        string query = "DELETE FROM menu WHERE UrunID = @UrunID";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UrunID", urunID);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ürün silindi.");
                        LoadMenu();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}");
                    }
                }
            }
        }
    }
}
