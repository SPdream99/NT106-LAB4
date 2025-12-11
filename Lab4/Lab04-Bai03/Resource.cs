using System;
using System.Windows.Forms;

namespace Lab4_WebBrowser
{
    public partial class Resource : Form
    {
        public Resource()
        {
            InitializeComponent();
        }

        private void Resource_Load(object sender, EventArgs e)
        {
        }

        public void SetSource(string source)
        {
            tbViewSource.Text = source;
        }
    }
}