using System.Drawing.Configuration;

namespace RestoranSiparisUygulaması
{
    partial class SiparisForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewSiparisler = new System.Windows.Forms.DataGridView();
            this.dataGridViewSiparisDetay = new System.Windows.Forms.DataGridView();
            this.comboBoxSiparisDurumu = new System.Windows.Forms.ComboBox();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.labelSiparisler = new System.Windows.Forms.Label();
            this.labelSiparisDetay = new System.Windows.Forms.Label();
            this.labelDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSiparisler
            // 
            this.dataGridViewSiparisler.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dataGridViewSiparisler.ColumnHeadersHeight = 34;
            this.dataGridViewSiparisler.GridColor = System.Drawing.Color.DarkOliveGreen;
            this.dataGridViewSiparisler.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewSiparisler.Name = "dataGridViewSiparisler";
            this.dataGridViewSiparisler.RowHeadersWidth = 62;
            this.dataGridViewSiparisler.Size = new System.Drawing.Size(760, 250);
            this.dataGridViewSiparisler.TabIndex = 0;
            this.dataGridViewSiparisler.SelectionChanged += new System.EventHandler(this.dataGridViewSiparisler_SelectionChanged);
            // 
            // dataGridViewSiparisDetay
            // 
            this.dataGridViewSiparisDetay.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dataGridViewSiparisDetay.ColumnHeadersHeight = 34;
            this.dataGridViewSiparisDetay.Location = new System.Drawing.Point(12, 330);
            this.dataGridViewSiparisDetay.Name = "dataGridViewSiparisDetay";
            this.dataGridViewSiparisDetay.RowHeadersWidth = 62;
            this.dataGridViewSiparisDetay.Size = new System.Drawing.Size(760, 150);
            this.dataGridViewSiparisDetay.TabIndex = 1;
            // 
            // comboBoxSiparisDurumu
            // 
            this.comboBoxSiparisDurumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.comboBoxSiparisDurumu.Items.AddRange(new object[] {
            "Hazırlanıyor",
            "Hazır",
            "Teslim Edildi"});
            this.comboBoxSiparisDurumu.Location = new System.Drawing.Point(782, 79);
            this.comboBoxSiparisDurumu.Name = "comboBoxSiparisDurumu";
            this.comboBoxSiparisDurumu.Size = new System.Drawing.Size(168, 33);
            this.comboBoxSiparisDurumu.TabIndex = 2;
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDurumGuncelle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDurumGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDurumGuncelle.Location = new System.Drawing.Point(782, 127);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(168, 79);
            this.btnDurumGuncelle.TabIndex = 3;
            this.btnDurumGuncelle.Text = "Durum Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // labelSiparisler
            // 
            this.labelSiparisler.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSiparisler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSiparisler.Location = new System.Drawing.Point(12, 9);
            this.labelSiparisler.Name = "labelSiparisler";
            this.labelSiparisler.Size = new System.Drawing.Size(145, 28);
            this.labelSiparisler.TabIndex = 4;
            this.labelSiparisler.Text = "Siparişler";
            // 
            // labelSiparisDetay
            // 
            this.labelSiparisDetay.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSiparisDetay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSiparisDetay.Location = new System.Drawing.Point(12, 302);
            this.labelSiparisDetay.Name = "labelSiparisDetay";
            this.labelSiparisDetay.Size = new System.Drawing.Size(111, 34);
            this.labelSiparisDetay.TabIndex = 5;
            this.labelSiparisDetay.Text = "Sipariş Detayları";
            // 
            // labelDurum
            // 
            this.labelDurum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDurum.Location = new System.Drawing.Point(782, 40);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(168, 36);
            this.labelDurum.TabIndex = 6;
            this.labelDurum.Text = "Durum Seçin:";
            // 
            // SiparisForm
            // 
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(980, 500);
            this.Controls.Add(this.dataGridViewSiparisler);
            this.Controls.Add(this.dataGridViewSiparisDetay);
            this.Controls.Add(this.comboBoxSiparisDurumu);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.labelSiparisler);
            this.Controls.Add(this.labelSiparisDetay);
            this.Controls.Add(this.labelDurum);
            this.Name = "SiparisForm";
            this.Text = "Sipariş Görüntüleme ve Güncelleme";
            this.Load += new System.EventHandler(this.SiparisForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisDetay)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridViewSiparisler;
        private System.Windows.Forms.DataGridView dataGridViewSiparisDetay;
        private System.Windows.Forms.ComboBox comboBoxSiparisDurumu;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.Label labelSiparisler;
        private System.Windows.Forms.Label labelSiparisDetay;
        private System.Windows.Forms.Label labelDurum;
    }
}
