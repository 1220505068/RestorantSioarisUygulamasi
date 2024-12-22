using MySql.Data.MySqlClient;
using RestoranSiparisUygulaması.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestoranSiparisUygulaması
{
    public partial class MusteriForm : Form
    {
        private List<SepetItem> sepet = new List<SepetItem>(); // Sepet öğelerini tutan liste

        public MusteriForm()
        {
            InitializeComponent();
        }

        private void MusteriForm_Load_1(object sender, EventArgs e)
        {
            LoadMenuItems(); // Menü öğelerini yükle
        }

        private void LoadMenuItems()
        {
            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Menu ORDER BY Kategori, UrunAdi";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    listViewYiyecekler.Items.Clear();
                    listViewIcecekler.Items.Clear();

                    bool hasItems = false;

                    while (reader.Read())
                    {
                        hasItems = true;
                        string kategori = reader["Kategori"].ToString();
                        ListViewItem item = new ListViewItem(reader["UrunAdi"].ToString());
                        item.SubItems.Add(reader["Fiyat"].ToString() + " ₺");
                        item.SubItems.Add(reader["Aciklama"].ToString());

                        if (kategori == "İçecek")
                        {
                            listViewIcecekler.Items.Add(item);
                        }
                        else if (kategori == "Başlangıç" || kategori == "Ana Yemek" || kategori == "Tatlı")
                        {
                            listViewYiyecekler.Items.Add(item);
                        }
                    }

                    if (!hasItems)
                    {
                        MessageBox.Show("Menüde ürün bulunmamaktadır!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (listViewYiyecekler.SelectedItems.Count == 0 && listViewIcecekler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir ürün seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listViewYiyecekler.SelectedItems.Count > 0
                ? listViewYiyecekler.SelectedItems[0]
                : listViewIcecekler.SelectedItems[0];

            decimal fiyat;
            try
            {
                fiyat = Convert.ToDecimal(selectedItem.SubItems[1].Text.Replace("₺", "").Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fiyat hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SepetItem sepetItem = new SepetItem
            {
                UrunAdi = selectedItem.Text,
                Fiyat = fiyat,
                Adet = 1
            };

            sepet.Add(sepetItem);
            MessageBox.Show($"{selectedItem.Text} sepete eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateSepetList();
        }

        private void UpdateSepetList()
        {
            listViewSepet.Items.Clear();
            foreach (var item in sepet)
            {
                ListViewItem listItem = new ListViewItem(item.UrunAdi);
                listItem.SubItems.Add(item.Fiyat.ToString("C2"));
                listItem.SubItems.Add(item.Adet.ToString());
                listViewSepet.Items.Add(listItem);
            }
        }

        private void btnSepettenSil_Click(object sender, EventArgs e)
        {
            if (listViewSepet.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listViewSepet.SelectedItems[0];
            SepetItem itemToRemove = sepet.Find(x => x.UrunAdi == selectedItem.Text);

            if (itemToRemove != null)
            {
                sepet.Remove(itemToRemove);
                MessageBox.Show($"{selectedItem.Text} sepetten silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateSepetList();
            }
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            if (sepet.Count == 0)
            {
                MessageBox.Show("Sepetinizde ürün bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    foreach (var item in sepet)
                    {
                        string query = "INSERT INTO Siparis (musteriID, UrunAdi, ToplamTutar, Adet) VALUES (@musteriID, @UrunAdi, @ToplamTutar, @Adet)";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        // Musteri ID'si burada belirtiliyor. Örneğin, 1 varsayılan müşteri olarak atanıyor.
                        command.Parameters.AddWithValue("@musteriID", 1);
                        command.Parameters.AddWithValue("@UrunAdi", item.UrunAdi);
                        command.Parameters.AddWithValue("@ToplamTutar", item.Fiyat * item.Adet);
                        command.Parameters.AddWithValue("@Adet", item.Adet);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Siparişiniz başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sepet.Clear();
                    UpdateSepetList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }

    public class SepetItem
    {
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
    }
}
