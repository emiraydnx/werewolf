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
            LoadControl(new UserControl1());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
