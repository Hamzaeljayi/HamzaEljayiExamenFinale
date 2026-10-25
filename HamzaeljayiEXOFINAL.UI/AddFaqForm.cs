
namespace HamzaeljayiEXOFINAL.UI
{
    public partial class AddFaqForm : Form
    {
        public string Question { get; private set; }
        public string Answer { get; private set; }
        public string Category { get; private set; }

        public AddFaqForm(List<string> categories)
        {
            InitializeComponent();
            LoadCategories(categories);
        }

        private void LoadCategories(List<string> categories)
        {
            cmbCategory.Items.Clear();
            foreach (var cat in categories)
            {
                cmbCategory.Items.Add(cat);
            }

            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text) ||
               string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                MessageBox.Show("Question et Réponse sont obligatoires");
                return;
            }

            Question = txtQuestion.Text.Trim();
            Answer = txtAnswer.Text.Trim();
            Category = cmbCategory.Text;

            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }
    }
}


