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
            // https://stackoverflow.com/a/3205512/5438626
            int usableWidth =
                flowLayoutPanel.Width - SystemInformation.VerticalScrollBarWidth;
            List<TextBox> tmp = new List<TextBox>();
            for (int i = 0; i < 25; i++)
            {
                var textBox =
                new TextBox
                {
                    Text = $"TextBox{i}",
                    Name = $"textBox{i}",
                    Margin = new Padding(),
                    Width = usableWidth,
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                };
                textBox.TextChanged += onAnyTextChanged;
                flowLayoutPanel.Controls.Add(textBox);
                tmp.Add(textBox);
            }
            Textboxes = tmp.ToArray();
        }
        // Handle text changes in any box
        private void onAnyTextChanged(object sender, EventArgs e)
        {
            if(sender is TextBox textbox)
            {
                // Do something with the text box that changed.                
            }
        }
        // Access an individual textboxes easily by index
        TextBox[] Textboxes;
    }
}
