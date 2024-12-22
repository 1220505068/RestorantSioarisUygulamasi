namespace RestoranSiparisUygulaması
{
    partial class MusteriForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewYiyecekler;
        private System.Windows.Forms.ListView listViewIcecekler;
        private System.Windows.Forms.ListView listViewSepet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Label lblYiyecekler;
        private System.Windows.Forms.Label lblIcecekler;
        private System.Windows.Forms.Label lblSepet;

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
            this.listViewYiyecekler = new System.Windows.Forms.ListView();
            this.listViewIcecekler = new System.Windows.Forms.ListView();
            this.listViewSepet = new System.Windows.Forms.ListView();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.lblYiyecekler = new System.Windows.Forms.Label();
            this.lblIcecekler = new System.Windows.Forms.Label();
            this.lblSepet = new System.Windows.Forms.Label();
            this.btnSepettenSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewYiyecekler
            // 
            this.listViewYiyecekler.BackColor = System.Drawing.Color.FloralWhite;
            this.listViewYiyecekler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewYiyecekler.Location = new System.Drawing.Point(20, 44);
            this.listViewYiyecekler.Name = "listViewYiyecekler";
            this.listViewYiyecekler.Size = new System.Drawing.Size(449, 320);
            this.listViewYiyecekler.TabIndex = 0;
            this.listViewYiyecekler.UseCompatibleStateImageBehavior = false;
            this.listViewYiyecekler.View = System.Windows.Forms.View.List;
            // 
            // listViewIcecekler
            // 
            this.listViewIcecekler.BackColor = System.Drawing.Color.FloralWhite;
            this.listViewIcecekler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewIcecekler.Location = new System.Drawing.Point(526, 44);
            this.listViewIcecekler.Name = "listViewIcecekler";
            this.listViewIcecekler.Size = new System.Drawing.Size(457, 320);
            this.listViewIcecekler.TabIndex = 1;
            this.listViewIcecekler.UseCompatibleStateImageBehavior = false;
            this.listViewIcecekler.View = System.Windows.Forms.View.List;
            // 
            // listViewSepet
            // 
            this.listViewSepet.BackColor = System.Drawing.Color.AliceBlue;
            this.listViewSepet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewSepet.Location = new System.Drawing.Point(11, 430);
            this.listViewSepet.Name = "listViewSepet";
            this.listViewSepet.Size = new System.Drawing.Size(630, 239);
            this.listViewSepet.TabIndex = 2;
            this.listViewSepet.UseCompatibleStateImageBehavior = false;
            this.listViewSepet.View = System.Windows.Forms.View.List;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSepeteEkle.Location = new System.Drawing.Point(364, 370);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(201, 48);
            this.btnSepeteEkle.TabIndex = 3;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSiparisiTamamla.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(675, 445);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(221, 112);
            this.btnSiparisiTamamla.TabIndex = 4;
            this.btnSiparisiTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = false;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // lblYiyecekler
            // 
            this.lblYiyecekler.AutoSize = true;
            this.lblYiyecekler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYiyecekler.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblYiyecekler.Location = new System.Drawing.Point(20, 9);
            this.lblYiyecekler.Name = "lblYiyecekler";
            this.lblYiyecekler.Size = new System.Drawing.Size(130, 32);
            this.lblYiyecekler.TabIndex = 5;
            this.lblYiyecekler.Text = "Yiyecekler";
            // 
            // lblIcecekler
            // 
            this.lblIcecekler.AutoSize = true;
            this.lblIcecekler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIcecekler.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIcecekler.Location = new System.Drawing.Point(526, 9);
            this.lblIcecekler.Name = "lblIcecekler";
            this.lblIcecekler.Size = new System.Drawing.Size(115, 32);
            this.lblIcecekler.TabIndex = 6;
            this.lblIcecekler.Text = "İçecekler";
            // 
            // lblSepet
            // 
            this.lblSepet.AutoSize = true;
            this.lblSepet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSepet.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSepet.Location = new System.Drawing.Point(20, 395);
            this.lblSepet.Name = "lblSepet";
            this.lblSepet.Size = new System.Drawing.Size(77, 32);
            this.lblSepet.TabIndex = 7;
            this.lblSepet.Text = "Sepet";
            // 
            // btnSepettenSil
            // 
            this.btnSepettenSil.Location = new System.Drawing.Point(693, 587);
            this.btnSepettenSil.Name = "btnSepettenSil";
            this.btnSepettenSil.Size = new System.Drawing.Size(179, 50);
            this.btnSepettenSil.TabIndex = 8;
            this.btnSepettenSil.Text = "Sepetten Sil";
            this.btnSepettenSil.UseVisualStyleBackColor = true;
            this.btnSepettenSil.Click += new System.EventHandler(this.btnSepettenSil_Click);
            // 
            // MusteriForm
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1060, 681);
            this.Controls.Add(this.btnSepettenSil);
            this.Controls.Add(this.listViewYiyecekler);
            this.Controls.Add(this.listViewIcecekler);
            this.Controls.Add(this.listViewSepet);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.lblYiyecekler);
            this.Controls.Add(this.lblIcecekler);
            this.Controls.Add(this.lblSepet);
            this.Name = "MusteriForm";
            this.Text = "Müşteri Ekranı";
            this.Load += new System.EventHandler(this.MusteriForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnSepettenSil;
    }
}
