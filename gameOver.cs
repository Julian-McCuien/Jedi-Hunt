using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Jedi_Hunt
{
    public partial class GameSummary : Form
    {
        private LinkedList<Items> playerItems;


        public GameSummary(LinkedList<Items> items)
        {
            InitializeComponent();
            playerItems = items;
            DisplayPlayerItems();
        }
        private void DisplayPlayerItems()
        {
            flowLayoutPanelItems.Controls.Clear();

            int itemSize = 100; 
                        
            foreach (var item in playerItems)
            {
                Panel itemPanel = new Panel();
                itemPanel.AutoSize = true;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = item.item_image;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; 
                pictureBox.Size = new Size(itemSize, itemSize);
                itemPanel.Controls.Add(pictureBox);

                flowLayoutPanelItems.Controls.Add(itemPanel);
            }

        }

        private void GameSummary_Load(object sender, EventArgs e)
        {

        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            game newGame = new game();
            newGame.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
