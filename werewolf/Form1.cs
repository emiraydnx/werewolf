namespace werewolf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; 
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }
        
        private void LoadControl(UserControl control)
        {
            // Paneli temizler
            mainPanel.Controls.Clear();

            // Yeni UserControl'ü panele ekler
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }
        public void ShowStartScreen()
        {
            // Panel içeriðini temizle
            mainPanel.Controls.Clear();

            // Start ve Exit butonlarýný panelin üstüne geri ekle
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(button2);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            uc1.ReturnToForm1 += UserControl1_ReturnToForm1; // Event'e baðlanýyoruz
            LoadControl(uc1);


        }

        private void UserControl1_ReturnToForm1(object sender, EventArgs e)
        {
            ShowStartScreen(); // Start ekranýný tekrar göster
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
