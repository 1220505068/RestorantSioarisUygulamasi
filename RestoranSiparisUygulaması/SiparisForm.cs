using MySql.Data.MySqlClient;
using RestoranSiparisUygulaması.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace RestoranSiparisUygulaması
{
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void SiparisForm_Load_1(object sender, EventArgs e)
        {
            LoadSiparisler();
        }

        private void LoadSiparisler()
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = @"
                SELECT 
                    s.SiparisID, 
                    s.MusteriID, 
                    s.SiparisDurumu, 
                    s.ToplamTutar, 
                    m.UrunAdi, 
                    sd.Miktar AS Adet
                FROM 
                    siparis s
                INNER JOIN 
                    siparisdetay sd ON s.SiparisID = sd.SiparisID
                INNER JOIN 
                    menu m ON sd.UrunID = m.UrunID";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewSiparisler.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadSiparisDetaylar(int siparisID)
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = @"
                        SELECT m.UrunAdi, sd.Miktar 
                        FROM siparisdetay sd
                        INNER JOIN menu m ON sd.UrunID = m.UrunID
                        WHERE sd.SiparisID = @SiparisID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SiparisID", siparisID);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewSiparisDetay.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewSiparisler.SelectedRows.Count > 0)
            {
                int siparisID = Convert.ToInt32(dataGridViewSiparisler.SelectedRows[0].Cells["SiparisID"].Value);
                string yeniDurum = comboBoxSiparisDurumu.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(yeniDurum))
                {
                    MessageBox.Show("Lütfen bir durum seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection connection = DatabaseHelper.GetConnection())
                {
                    try
                    {
                        string query = "UPDATE siparis SET SiparisDurumu = @Durum WHERE SiparisID = @SiparisID";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Durum", yeniDurum);
                        command.Parameters.AddWithValue("@SiparisID", siparisID);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Sipariş durumu güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadSiparisler();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sipariş seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewSiparisler_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSiparisler.SelectedRows.Count > 0)
            {
                int siparisID = Convert.ToInt32(dataGridViewSiparisler.SelectedRows[0].Cells["SiparisID"].Value);
                LoadSiparisDetaylar(siparisID);
            }
        }

    }
}
