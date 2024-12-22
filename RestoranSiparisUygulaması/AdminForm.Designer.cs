namespace RestoranSiparisUygulaması
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewSiparisRapor;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunSil;

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
            this.dataGridViewSiparisRapor = new System.Windows.Forms.DataGridView();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSiparisRapor
            // 
            this.dataGridViewSiparisRapor.BackgroundColor = System.Drawing.Color.Brown;
            this.dataGridViewSiparisRapor.ColumnHeadersHeight = 34;
            this.dataGridViewSiparisRapor.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewSiparisRapor.Name = "dataGridViewSiparisRapor";
            this.dataGridViewSiparisRapor.RowHeadersWidth = 62;
            this.dataGridViewSiparisRapor.Size = new System.Drawing.Size(760, 243);
            this.dataGridViewSiparisRapor.TabIndex = 0;
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.Brown;
            this.dataGridViewMenu.ColumnHeadersHeight = 34;
            this.dataGridViewMenu.Location = new System.Drawing.Point(12, 273);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 62;
            this.dataGridViewMenu.Size = new System.Drawing.Size(760, 274);
            this.dataGridViewMenu.TabIndex = 1;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUrunAdi.Location = new System.Drawing.Point(12, 573);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.PlaceholderText = "Ürün Adı";
            this.txtUrunAdi.Size = new System.Drawing.Size(124, 34);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFiyat.Location = new System.Drawing.Point(142, 575);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.PlaceholderText = "Fiyat";
            this.txtFiyat.Size = new System.Drawing.Size(135, 34);
            this.txtFiyat.TabIndex = 3;
            // 
            // txtKategori
            // 
            this.txtKategori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKategori.Location = new System.Drawing.Point(310, 575);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.PlaceholderText = "Kategori";
            this.txtKategori.Size = new System.Drawing.Size(137, 34);
            this.txtKategori.TabIndex = 4;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.Maroon;
            this.btnUrunEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUrunEkle.Location = new System.Drawing.Point(479, 549);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(151, 79);
            this.btnUrunEkle.TabIndex = 5;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.Red;
            this.btnUrunSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUrunSil.Location = new System.Drawing.Point(699, 553);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(136, 75);
            this.btnUrunSil.TabIndex = 6;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.ForeColor = System.Drawing.Color.Maroon;
            this.lbl1.Location = new System.Drawing.Point(792, 134);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(150, 41);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Siparişler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(809, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Menü";
            // 
            // AdminForm
            // 
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(969, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dataGridViewSiparisRapor);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnUrunSil);
            this.Name = "AdminForm";
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lbl1;
        private Label label2;
    }
}
