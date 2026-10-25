using HamzaeljayiEXOFINAL.Bll;
using HamzaeljayiEXOFINAL.Models;
using System.Drawing.Text;


namespace HamzaeljayiEXOFINAL.UI
{
    public partial class MainForm : Form
    {
        private FAQService _faqService;

        public MainForm()
        {
            InitializeComponent();
            _faqService = new FAQService();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadFAQs();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            if (dgvFAQs.Columns["Id"] != null)
                dgvFAQs.Columns["Id"].Visible = false;

            if (dgvFAQs.Columns["IsActive"] != null)
                dgvFAQs.Columns["IsActive"].Visible = false;

            dgvFAQs.Columns["Question"].HeaderText = "Question";
            dgvFAQs.Columns["Answer"].HeaderText = "Réponse";
            dgvFAQs.Columns["Category"].HeaderText = "Catégorie";
            dgvFAQs.Columns["CreatedDate"].HeaderText = "Date de création";

            dgvFAQs.Columns["CreatedDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void LoadCategories()
        {
            try
            {
                cmbcategorie.Items.Clear();
                cmbcategorie.Items.Add("Toutes");

                var categories = _faqService.GetAllCategories();
                foreach (var cat in categories)
                {
                    cmbcategorie.Items.Add(cat);
                }

                cmbcategorie.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ShowError($"Erreur lors du chargement des catégories: {ex.Message}");
            }
        }

        private void LoadFAQs()
        {
            try
            {
                DisplayFAQs(_faqService.GetAllFAQs());
            }
            catch (Exception ex)
            {
                ShowError($"Erreur lors du chargement des FAQs: {ex.Message}");
            }
        }

        private void DisplayFAQs(List<FAQItem> faqs)
        {
            dgvFAQs.DataSource = null;
            dgvFAQs.DataSource = faqs;

            if (dgvFAQs.Columns["Id"] != null)
                dgvFAQs.Columns["Id"].Visible = false;

            if (dgvFAQs.Columns["IsActive"] != null)
                dgvFAQs.Columns["IsActive"].Visible = false;

            UpdateStatusBar(faqs.Count);
        }

        private void UpdateStatusBar(int count)
        {
            lblstatus.Text = "FAQs affichées :";
            lblcount.Text = count.ToString();
        }




        private void ShowError(string message)
        {
            MessageBox.Show(message, "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var keyword = txtSearch.Text.Trim();
                DisplayFAQs(_faqService.SearchFAQs(keyword));
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void cmbcategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbcategorie.SelectedItem.ToString() == "Toutes")
                {
                    LoadFAQs();
                }
                else
                {
                    DisplayFAQs(
                        _faqService.GetFAQsByCategory(cmbcategorie.SelectedItem.ToString())
                    );
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

        }

        private void btnreinitialiser_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbcategorie.SelectedIndex = 0;
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            try
            {
                var form = new AddFaqForm(_faqService.GetAllCategories());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _faqService.AddFAQ(form.Question, form.Answer, form.Category);
                    MessageBox.Show(
                     "La FAQ a été ajoutée avec succès.",
                     "Ajout réussi",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                );
                    LoadFAQs();
                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvFAQs.CurrentRow != null)
                {
                    var result = MessageBox.Show(
                        "Êtes-vous sûr de vouloir supprimer cette FAQ ?",
                        "Confirmation de suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        int id = (int)dgvFAQs.CurrentRow.Cells["Id"].Value;
                        _faqService.DeleteFAQ(id);

                        MessageBox.Show(
                            "La FAQ a été supprimée avec succès.",
                            "Suppression réussie",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadFAQs();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Veuillez sélectionner une FAQ à supprimer.",
                        "Aucune sélection",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        

        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbcategorie.SelectedIndex = 0;
            LoadFAQs();

        }
    }
}


