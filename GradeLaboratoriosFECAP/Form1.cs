using System.Threading.Tasks;

namespace GradeLaboratoriosFECAP
{
    public partial class PanelSup : Form
    {
        public PanelSup()
        {
            InitializeComponent();
        }

        private async Task radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            await AtualizarGradeInterface();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void Segunda_RB_CheckedChanged(object sender, EventArgs e)
        {
            await AtualizarGradeInterface();
        }
    }
}
