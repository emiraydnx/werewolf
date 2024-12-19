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

            // Yeni UserControl'� panele ekler
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }
        public void ShowStartScreen()
        {
            // Panel i�eri�ini temizle
            mainPanel.Controls.Clear();

            // Start ve Exit butonlar�n� panelin �st�ne geri ekle
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(button2);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            uc1.ReturnToForm1 += UserControl1_ReturnToForm1; // Event'e ba�lan�yoruz
            LoadControl(uc1);


        }

        private void UserControl1_ReturnToForm1(object sender, EventArgs e)
        {
            ShowStartScreen(); // Start ekran�n� tekrar g�ster
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
