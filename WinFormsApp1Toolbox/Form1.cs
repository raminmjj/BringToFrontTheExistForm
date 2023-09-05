namespace WinFormsApp1Toolbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenVisibleFormSample();
        }

        private void OpenVisibleFormSample()
        {
            //If there is an existing instance of visibleform, move to front, if not, open
            var opendForms = Application.OpenForms.OfType<VisibleFormSample>();
            if (opendForms.Count() == 1)
            {
                opendForms.First().BringToFront();
            }
            else
            {
                var visibleForm = new VisibleFormSample();
                visibleForm.Show();
            }
        }
    }
}