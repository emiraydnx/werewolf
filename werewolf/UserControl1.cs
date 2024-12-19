using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace werewolf
{
    public partial class UserControl1 : UserControl
    {
        private int height = 56;
        private List<TextBox> playerTextBoxes = new List<TextBox>();
        
        private int playerCount = 1;
        public event EventHandler ReturnToForm1;


        public UserControl1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnToForm1?.Invoke(this, EventArgs.Empty);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            richTextBox1.KeyPress += richTextBox1_KeyPress;
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            richTextBox1.MouseDown += richTextBox1_MouseDown;
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            checkedListBox1.SetItemChecked(0, true); // "Item 1" işaretli
            checkedListBox1.SetItemChecked(1, true); // "Item 2" işaretli
        }

        private void button3_Click(object sender, EventArgs e)
        {


            TextBox newTextBox = new TextBox();
            newTextBox.Text = "player " + playerCount;
            newTextBox.TextAlign = HorizontalAlignment.Center;
            newTextBox.Size = new Size(125, 27);
            newTextBox.Location = new Point(700, 214 + height * (playerCount - 4));
            newTextBox.TabIndex = 10;
            newTextBox.Font = new Font("Showcard gothic", 9);
            this.Controls.Add(newTextBox);
            playerTextBoxes.Add(newTextBox);
            playerCount++;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (playerTextBoxes.Count > 0)
            {
                TextBox lastTextBox = playerTextBoxes[playerTextBoxes.Count - 1];
                this.Controls.Remove(lastTextBox);
                lastTextBox.Dispose();
                playerTextBoxes.RemoveAt(playerTextBoxes.Count - 1);
                playerCount--;
            }
        }


        private Image ResizeImage(Image img, int width, int height)
        {
            // Yeni bir Bitmap oluştur ve boyutlandır
            Bitmap resizedImg = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(resizedImg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }

            return resizedImg;
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // "Item 1" ve "Item 2" öğelerinin değiştirilmesini engelliyoruz
            if (e.Index == 0 || e.Index == 1)
            {
                e.NewValue = e.CurrentValue; // Değişiklik yapılmasını engeller
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (sender is CheckedListBox checkedListBox)
            {
                if (checkedListBox.SelectedIndex != -1)
                {
                    richTextBox1.Clear();
                    string selectedItem = checkedListBox.SelectedItem.ToString();


                    // Metni kontrol ederek ekle
                    switch (selectedItem)
                    {
                        case "Wolf":
                            Image img1 = Image.FromFile("C:\\Users\\Emirhan\\Desktop\\werewolf\\werewolf\\wolf.png");
                            Image resizedImg1 = ResizeImage(img1, 150, 150);
                            Clipboard.SetImage(resizedImg1);

                            richTextBox1.Paste();
                            Clipboard.Clear();
                            richTextBox1.AppendText("Team: Werewolves\r\n\nGoal: Outnumber the villagers to win.\r\n\nAbilities: Every night, werewolves secretly choose a player to eliminate.");
                            break;

                        case "Villager":
                            Image img2 = Image.FromFile("C:\\Users\\Emirhan\\Desktop\\werewolf\\werewolf\\3943611.png");
                            Image resizedImg2 = ResizeImage(img2, 150, 150);
                            Clipboard.SetImage(resizedImg2);
                            richTextBox1.Paste();
                            Clipboard.Clear();
                            richTextBox1.AppendText("Team: Villagers\r\n\nGoal: Eliminate all the werewolves.\r\n\nAbilities: No special powers, but they can vote during the day to eliminate suspected werewolves.");
                            break;

                        case "Doctor":
                            Image img3 = Image.FromFile("C:\\Users\\Emirhan\\Desktop\\werewolf\\werewolf\\doctor.png");
                            Image resizedImg3 = ResizeImage(img3, 150, 150);
                            Clipboard.SetImage(resizedImg3);
                            richTextBox1.Paste();
                            Clipboard.Clear();
                            richTextBox1.AppendText("Team: Villagers\r\n\nGoal: Protect villagers from being killed by werewolves.\r\n\nAbilities: Can protect one player (including themselves) from being eliminated each night.");
                            break;

                        case "Seer":
                            Image img4 = Image.FromFile("C:\\Users\\Emirhan\\Desktop\\werewolf\\werewolf\\seer.png");
                            Image resizedImg4 = ResizeImage(img4, 150, 150);
                            Clipboard.SetImage(resizedImg4);
                            richTextBox1.Paste();
                            Clipboard.Clear();
                            richTextBox1.AppendText("Team: Villagers\r\n\nGoal: Help identify and eliminate werewolves.\r\n\nAbilities: Each night, the Seer can secretly check one player’s role.");
                            break;

                        case "Jester":
                            Image img5 = Image.FromFile("C:\\Users\\Emirhan\\Desktop\\werewolf\\werewolf\\harlequin.png");
                            Image resizedImg5 = ResizeImage(img5, 150, 150);
                            Clipboard.SetImage(resizedImg5);
                            richTextBox1.Paste();
                            Clipboard.Clear();
                            richTextBox1.AppendText("Team: Neutral (Solo role)\r\n\nGoal: Get lynched (voted out) during the day phase to win the game.\r\n\nAbilities: No special powers other than trying to act suspicious or manipulating others into voting for them.");
                            break;

                        case "Hunter":
                            Image img6 = Image.FromFile("C:\\Users\\Emirhan\\Desktop\\werewolf\\werewolf\\man.png");
                            Image resizedImg6 = ResizeImage(img6, 150, 150);
                            Clipboard.SetImage(resizedImg6);
                            richTextBox1.Paste();
                            Clipboard.Clear();
                            richTextBox1.AppendText("Team: Villagers\r\n\nGoal: Eliminate werewolves.\r\n\nAbilities: If the Hunter is eliminated, they can take down one other player with them.");
                            break;

                        case "BodyGuard":
                            Image img7 = Image.FromFile("C:\\Users\\Emirhan\\Desktop\\werewolf\\werewolf\\bodyguard.png");
                            Image resizedImg7 = ResizeImage(img7, 150, 150);
                            Clipboard.SetImage(resizedImg7);
                            richTextBox1.Paste();
                            Clipboard.Clear();
                            richTextBox1.AppendText("Team: Villagers\r\n\nGoal: Protect villagers from werewolves.\r\n\nAbilities: Similar to the Doctor but may die in place of the person they protect.");
                            break;
                    }
                }
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Kullanıcı girişini tamamen engeller
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true; // Klavye tuşlarını etkisizleştirir
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Mouse tıklaması ile metni seçmeyi engelle
            richTextBox1.SelectionLength = 0;
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionLength = 0; // Seçim yapılmasını engeller
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Showcard gothic", 9);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            if (playerTextBoxes.Count < 5)
            {
                MessageBox.Show("Oyunu başlatmak için en az 5 oyuncu gereklidir!");
                return;
            }
            if (checkedListBox1.CheckedItems.Count < 3)
            {
                MessageBox.Show("En az 3 rol seçmelisiniz");
                return;
            }
            MessageBox.Show("Oyun başlıyor");
            StartGame();
        }
        private void StartGame()
        {
            List<string> Roles = new List<string>();
            foreach (var Item in checkedListBox1.CheckedItems)
            {
                Roles.Add(Item.ToString());
            }
            while (Roles.Count < playerTextBoxes.Count)
            {
                Roles.Add("Villager");
            }

            Random random = new Random();
            List<string> AssignedRoles = new List<string>();
            foreach(TextBox textBox in playerTextBoxes)
            {
                int randomIndex = random.Next(Roles.Count);//rastgele rol seç
                string assignedRole = Roles[randomIndex];//rolü al
                Roles.RemoveAt(randomIndex);// atanan rolü listeden çıkar
                AssignedRoles.Add($"{textBox.Text}: {assignedRole}");//oyuncuya rol ata
            }
            //oyuncuların rolerin atanmasını ekranda göster
            string message = "Roller atanmıştır:\n" + string.Join("\n", AssignedRoles);
            MessageBox.Show(message, "Roller");
        }
    }
}
