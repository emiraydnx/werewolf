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
        private int verticalPosition = 50; // İlk ComboBox ve Button'un başlangıç Y konumu
        private int controlSpacing = 10;
        public UserControl1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComboBox newComboBox = new ComboBox
            {
                Size = new Size(150, 30),
                Location = new Point(256, verticalPosition + 170) // ComboBox bir altına yerleştiriliyor
            };

            // ComboBox'a örnek öğeler ekle
            newComboBox.Items.AddRange(new string[] { "Wolf", "Villager", "Doctor", "Wizard", "Joker", "Hunter" });




            // Yeni ComboBox ve butonu forma ekle
            this.Controls.Add(newComboBox);


            // Yükseklik değerini güncelle
            verticalPosition += 50 + controlSpacing;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
