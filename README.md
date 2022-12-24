As I understand it, you're trying to make a stack of "entities" where each has a label and three textboxes. These entities are in a container with a maximum size and you want to be able to scroll through them. One way to do this would be to use a `FlowLayoutPanel` which has this functionality built in. Here's a code snippet that adds 5 custom `Card` controls and it's scrollable. Does this help?

[![scrolling textboxes][1]][1]

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

I [tested](https://github.com/IVSoftware/flow-layout-panel-00.git) this answer with a [minimal reproducible example](https://stackoverflow.com/help/minimal-reproducible-example) `Card` class is created in the designer and can expose the textboxes as `public` elements of offer other methods to access the controls therein contained.

  [1]: https://i.stack.imgur.com/BcuVB.png