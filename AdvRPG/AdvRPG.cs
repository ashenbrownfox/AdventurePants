using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace AdvRPG
{
    public partial class AdvRPG : Form
    {
        public AdvRPG()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house");

            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house.";
            _player = new Player();
            _player.CurrentHitPoints = 100;
            _player.MaximumHitPoints = 100;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private Player _player;
        private void btnTest_Click(object sender, EventArgs e)
        {
            label2.Text = "Hey I changedz!";
            lblExperience.Text = "230000";
        }
    }
}
