using BidingSources.Models;

namespace BidingSources
{
    public partial class Form1 : Form
    {
        private PessoaRepository _pessoaRepository = new PessoaRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = _pessoaRepository.GetAll();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
