using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA1300
{
    public partial class StartScreen : Form
    {

        GameScreen inGameScreen = new GameScreen();
        HelpScreen inHelpScreen = new HelpScreen();

        public StartScreen()
        {
            InitializeComponent();
            
        }

        private void LoadGame(object sender, EventArgs e)
        {
            inGameScreen.Show();

            this.Hide();
        }

        private void LoadHelp(object sender, EventArgs e)
        {
            inHelpScreen.Show();
        }

        private void QuitApplication(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
