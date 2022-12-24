using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flow_layout_panel_00
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            populateFlowLayoutPanel();
        }
        private void populateFlowLayoutPanel()
        {
            flowLayoutPanel.AutoScroll = true;
            for (int i = 0; i < 5; i++)
            {
                NewCard();
            }
        }
        public void NewCard()
        {
            var userControl = new Card();
            flowLayoutPanel.Controls.Add(userControl);
            flowLayoutPanel.Width = 
                userControl.Width + 
                userControl.Margin.Left + 
                userControl.Margin.Right +
                SystemInformation.VerticalScrollBarWidth;
        }
    }
}
