As I now understand it from your comment below, the requirement is to display a stack of "entities" where each has a label and three textboxes. These can be dynamically added and deleted to container with a maximum size, and so you want to be able to scroll through them. 

One way to do this would be to use a `FlowLayoutPanel` which has this functionality built in. Here's a code snippet that adds 5 custom `Card` controls and it's scrollable. Does this help?

[![scrollable cards][1]][1]

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
                SystemInformation.VerticalScrollBarWidth; // https://stackoverflow.com/a/3205512/5438626
        }
    }
***

The class I used to [test](https://github.com/IVSoftware/flow-layout-panel-00.git) this answer is a custom `Card` class is created in the designer. It can expose the textboxes as `public` elements or have other methods to access the controls it contains. I know your entity will be different, this is just a [minimal reproducible example](https://stackoverflow.com/help/minimal-reproducible-example).

[![designer][2]][2]


  [1]: https://i.stack.imgur.com/DEYHt.png
  [2]: https://i.stack.imgur.com/aNEAz.png