namespace task8
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }
        private int openDocuments = 0;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button != null)
            {
                switch (button.Tag.ToString())
                {
                    case "NewDoc":
                        ParentForm newChild = new ParentForm();
                        newChild.MdiParent = this;
                        newChild.Show();
                        newChild.Text = newChild.Text + " " + ++openDocuments;
                        break;
                    case "Cascade":
                        this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                        break;
                    case "Title":
                        this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                        break;
                }
            }
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
