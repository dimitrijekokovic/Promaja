namespace pecanje
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGlavni = new System.Windows.Forms.PictureBox();
            this.pnVrste = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.stapoviContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.stapovi = new System.Windows.Forms.Button();
            this.pnMasinice = new System.Windows.Forms.Button();
            this.pnUdice = new System.Windows.Forms.Button();
            this.pretragaBT = new System.Windows.Forms.Button();
            this.prvaTranzicija = new System.Windows.Forms.Timer(this.components);
            this.panelmenjaj = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGlavni)).BeginInit();
            this.sidebar.SuspendLayout();
            this.stapoviContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnGlavni);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 44);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "PromajaFishing Prodavnica";
            // 
            // btnGlavni
            // 
            this.btnGlavni.Image = ((System.Drawing.Image)(resources.GetObject("btnGlavni.Image")));
            this.btnGlavni.Location = new System.Drawing.Point(12, 14);
            this.btnGlavni.Name = "btnGlavni";
            this.btnGlavni.Size = new System.Drawing.Size(21, 19);
            this.btnGlavni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGlavni.TabIndex = 0;
            this.btnGlavni.TabStop = false;
            this.btnGlavni.Click += new System.EventHandler(this.btnGlavni_Click_1);
            // 
            // pnVrste
            // 
            this.pnVrste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnVrste.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnVrste.Image = ((System.Drawing.Image)(resources.GetObject("pnVrste.Image")));
            this.pnVrste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnVrste.Location = new System.Drawing.Point(0, 20);
            this.pnVrste.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.pnVrste.Name = "pnVrste";
            this.pnVrste.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnVrste.Size = new System.Drawing.Size(200, 45);
            this.pnVrste.TabIndex = 0;
            this.pnVrste.Text = "         Vrste Riba";
            this.pnVrste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnVrste.UseVisualStyleBackColor = false;
            this.pnVrste.Click += new System.EventHandler(this.button2_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidebar.Controls.Add(this.pnVrste);
            this.sidebar.Controls.Add(this.stapoviContainer);
            this.sidebar.Controls.Add(this.pnMasinice);
            this.sidebar.Controls.Add(this.pnUdice);
            this.sidebar.Controls.Add(this.pretragaBT);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 44);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(213, 468);
            this.sidebar.TabIndex = 3;
            // 
            // stapoviContainer
            // 
            this.stapoviContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stapoviContainer.Controls.Add(this.stapovi);
            this.stapoviContainer.Location = new System.Drawing.Point(0, 95);
            this.stapoviContainer.Margin = new System.Windows.Forms.Padding(0);
            this.stapoviContainer.Name = "stapoviContainer";
            this.stapoviContainer.Size = new System.Drawing.Size(200, 48);
            this.stapoviContainer.TabIndex = 4;
            // 
            // stapovi
            // 
            this.stapovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stapovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stapovi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stapovi.Image = ((System.Drawing.Image)(resources.GetObject("stapovi.Image")));
            this.stapovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stapovi.Location = new System.Drawing.Point(0, 0);
            this.stapovi.Margin = new System.Windows.Forms.Padding(0);
            this.stapovi.Name = "stapovi";
            this.stapovi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.stapovi.Size = new System.Drawing.Size(200, 48);
            this.stapovi.TabIndex = 1;
            this.stapovi.Text = "         Stapovi";
            this.stapovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stapovi.UseVisualStyleBackColor = false;
            this.stapovi.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnMasinice
            // 
            this.pnMasinice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnMasinice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnMasinice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMasinice.Image = ((System.Drawing.Image)(resources.GetObject("pnMasinice.Image")));
            this.pnMasinice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnMasinice.Location = new System.Drawing.Point(0, 143);
            this.pnMasinice.Margin = new System.Windows.Forms.Padding(0);
            this.pnMasinice.Name = "pnMasinice";
            this.pnMasinice.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnMasinice.Size = new System.Drawing.Size(200, 48);
            this.pnMasinice.TabIndex = 2;
            this.pnMasinice.Text = "         Masinice";
            this.pnMasinice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnMasinice.UseVisualStyleBackColor = false;
            this.pnMasinice.Click += new System.EventHandler(this.button5_Click);
            // 
            // pnUdice
            // 
            this.pnUdice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnUdice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnUdice.Image = ((System.Drawing.Image)(resources.GetObject("pnUdice.Image")));
            this.pnUdice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnUdice.Location = new System.Drawing.Point(0, 191);
            this.pnUdice.Margin = new System.Windows.Forms.Padding(0);
            this.pnUdice.Name = "pnUdice";
            this.pnUdice.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnUdice.Size = new System.Drawing.Size(200, 45);
            this.pnUdice.TabIndex = 3;
            this.pnUdice.Text = "         Udice";
            this.pnUdice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnUdice.UseVisualStyleBackColor = false;
            this.pnUdice.Click += new System.EventHandler(this.pnUdice_Click);
            // 
            // pretragaBT
            // 
            this.pretragaBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pretragaBT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pretragaBT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretragaBT.Image = ((System.Drawing.Image)(resources.GetObject("pretragaBT.Image")));
            this.pretragaBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pretragaBT.Location = new System.Drawing.Point(0, 256);
            this.pretragaBT.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pretragaBT.Name = "pretragaBT";
            this.pretragaBT.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pretragaBT.Size = new System.Drawing.Size(200, 45);
            this.pretragaBT.TabIndex = 5;
            this.pretragaBT.Text = "         Pretraga";
            this.pretragaBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pretragaBT.UseVisualStyleBackColor = false;
            this.pretragaBT.Click += new System.EventHandler(this.pretragaBT_Click);
            // 
            // prvaTranzicija
            // 
            this.prvaTranzicija.Interval = 10;
            this.prvaTranzicija.Tick += new System.EventHandler(this.prvaTranzicija_Tick);
            // 
            // panelmenjaj
            // 
            this.panelmenjaj.BackColor = System.Drawing.Color.DarkGray;
            this.panelmenjaj.Location = new System.Drawing.Point(239, 64);
            this.panelmenjaj.Name = "panelmenjaj";
            this.panelmenjaj.Size = new System.Drawing.Size(413, 396);
            this.panelmenjaj.TabIndex = 5;
            this.panelmenjaj.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmenjaj_Paint);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(707, 512);
            this.Controls.Add(this.panelmenjaj);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel3);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGlavni)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.stapoviContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnGlavni;
        private System.Windows.Forms.Button pnVrste;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.FlowLayoutPanel stapoviContainer;
        private System.Windows.Forms.Button stapovi;
        private System.Windows.Forms.Button pnMasinice;
        private System.Windows.Forms.Button pnUdice;
        private System.Windows.Forms.Timer prvaTranzicija;
        private System.Windows.Forms.Panel panelmenjaj;
        private System.Windows.Forms.Button pretragaBT;
    }
}

