using Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;

namespace GradeLaboratoriosFECAP
{
    internal class GradeItem
    {
        public string DiaSemana { get; internal set; } = "";
        public string Horario { get; internal set; } = "";
        public string Laboratorio { get; internal set; } = "";
        public string Materia { get; internal set; } = "";
        public string Professor { get; internal set; } = "";
        public string Curso { get; internal set; } = "";
    }
    partial class PanelSup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            Sexta_RB = new RadioButton();
            Quinta_RB = new RadioButton();
            Quarta_RB = new RadioButton();
            Terca_RB = new RadioButton();
            Segunda_RB = new RadioButton();
            listView1 = new ListView();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            SegHorarioNot = new GroupBox();
            PrimHorarioNot = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Lab106B = new GroupBox();
            InfoLab106 = new Label();
            Lab200B = new GroupBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage5.SuspendLayout();
            PrimHorarioNot.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            Lab106B.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "GRADE FIXA";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Sexta_RB);
            splitContainer1.Panel1.Controls.Add(Quinta_RB);
            splitContainer1.Panel1.Controls.Add(Quarta_RB);
            splitContainer1.Panel1.Controls.Add(Terca_RB);
            splitContainer1.Panel1.Controls.Add(Segunda_RB);
            splitContainer1.Panel1.Controls.Add(listView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl2);
            splitContainer1.Size = new Size(786, 416);
            splitContainer1.SplitterDistance = 113;
            splitContainer1.TabIndex = 0;
            // 
            // Sexta_RB
            // 
            Sexta_RB.AutoSize = true;
            Sexta_RB.Location = new Point(5, 95);
            Sexta_RB.Name = "Sexta_RB";
            Sexta_RB.Size = new Size(93, 19);
            Sexta_RB.TabIndex = 6;
            Sexta_RB.TabStop = true;
            Sexta_RB.Text = "SEXTA-FEIRA";
            Sexta_RB.UseVisualStyleBackColor = true;
            Sexta_RB.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // Quinta_RB
            // 
            Quinta_RB.AutoSize = true;
            Quinta_RB.Location = new Point(5, 70);
            Quinta_RB.Name = "Quinta_RB";
            Quinta_RB.Size = new Size(103, 19);
            Quinta_RB.TabIndex = 5;
            Quinta_RB.TabStop = true;
            Quinta_RB.Text = "QUINTA-FEIRA";
            Quinta_RB.UseVisualStyleBackColor = true;
            // 
            // Quarta_RB
            // 
            Quarta_RB.AutoSize = true;
            Quarta_RB.Location = new Point(5, 49);
            Quarta_RB.Name = "Quarta_RB";
            Quarta_RB.Size = new Size(105, 19);
            Quarta_RB.TabIndex = 4;
            Quarta_RB.TabStop = true;
            Quarta_RB.Text = "QUARTA-FEIRA";
            Quarta_RB.UseVisualStyleBackColor = true;
            // 
            // Terca_RB
            // 
            Terca_RB.AutoSize = true;
            Terca_RB.Location = new Point(5, 24);
            Terca_RB.Name = "Terca_RB";
            Terca_RB.Size = new Size(96, 19);
            Terca_RB.TabIndex = 3;
            Terca_RB.TabStop = true;
            Terca_RB.Text = "TERÇA-FEIRA";
            Terca_RB.UseVisualStyleBackColor = true;
            // 
            // Segunda_RB
            // 
            Segunda_RB.AutoSize = true;
            Segunda_RB.Location = new Point(5, 3);
            Segunda_RB.Name = "Segunda_RB";
            Segunda_RB.Size = new Size(113, 19);
            Segunda_RB.TabIndex = 2;
            Segunda_RB.TabStop = true;
            Segunda_RB.Text = "SEGUNDA-FEIRA";
            Segunda_RB.UseVisualStyleBackColor = true;
            Segunda_RB.CheckedChanged += Segunda_RB_CheckedChanged;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(113, 416);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(669, 416);
            tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(661, 388);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Matutino";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(661, 388);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Vespertino";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(SegHorarioNot);
            tabPage5.Controls.Add(PrimHorarioNot);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(661, 388);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Noturno";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // SegHorarioNot
            // 
            SegHorarioNot.Location = new Point(6, 186);
            SegHorarioNot.Name = "SegHorarioNot";
            SegHorarioNot.Size = new Size(649, 180);
            SegHorarioNot.TabIndex = 1;
            SegHorarioNot.TabStop = false;
            SegHorarioNot.Text = "21h00 às 22h40";
            // 
            // PrimHorarioNot
            // 
            PrimHorarioNot.Controls.Add(flowLayoutPanel1);
            PrimHorarioNot.Location = new Point(6, 3);
            PrimHorarioNot.Name = "PrimHorarioNot";
            PrimHorarioNot.Size = new Size(649, 180);
            PrimHorarioNot.TabIndex = 0;
            PrimHorarioNot.TabStop = false;
            PrimHorarioNot.Text = "19h00 às 20h40";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Lab106B);
            flowLayoutPanel1.Controls.Add(Lab200B);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(643, 158);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Lab106B
            // 
            Lab106B.Controls.Add(InfoLab106);
            Lab106B.Location = new Point(3, 3);
            Lab106B.Name = "Lab106B";
            Lab106B.Size = new Size(137, 67);
            Lab106B.TabIndex = 0;
            Lab106B.TabStop = false;
            Lab106B.Text = "106B";
            // 
            // InfoLab106
            // 
            InfoLab106.AllowDrop = true;
            InfoLab106.Dock = DockStyle.Fill;
            InfoLab106.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 2);
            InfoLab106.Location = new Point(3, 19);
            InfoLab106.Name = "InfoLab106";
            InfoLab106.RightToLeft = RightToLeft.Yes;
            InfoLab106.Size = new Size(131, 45);
            InfoLab106.TabIndex = 0;
            InfoLab106.Text = "4NADS - ENG. SOFTWARE  E ARQ. SIST. - LUCY";
            InfoLab106.TextAlign = ContentAlignment.TopCenter;
            InfoLab106.UseCompatibleTextRendering = true;
            // 
            // Lab200B
            // 
            Lab200B.Location = new Point(146, 3);
            Lab200B.Name = "Lab200B";
            Lab200B.Size = new Size(137, 67);
            Lab200B.TabIndex = 1;
            Lab200B.TabStop = false;
            Lab200B.Text = "200B";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelSup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "PanelSup";
            Text = "  ";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            PrimHorarioNot.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            Lab106B.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private GroupBox SegHorarioNot;
        private GroupBox PrimHorarioNot;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox Lab106B;
        private Label InfoLab106;
        private GroupBox Lab200B;
        private RadioButton Terca_RB;
        private RadioButton Segunda_RB;
        private ListView listView1;
        private RadioButton Quinta_RB;
        private RadioButton Quarta_RB;
        private RadioButton Sexta_RB;
        
        
        public async Task AtualizarGradeInterface()
        {
            try
            {
                string token = await GraphAuth.GetTokenAsync();

                // 1. Encode da SharePoint sharing URL para o formato Graph API
                string shareUrl = "https://edufecap.sharepoint.com/:x:/s/CdigosAnydesk-LaboratriosdeInformtica/IQDnq-xny6TqRpx4KNGO9vTQAejSoqSCz2RoiAWRKcv6iE8?e=AjsH2U";

                string base64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(shareUrl))
                    .TrimEnd('=')
                    .Replace('+', '-')
                    .Replace('/', '_');

                string shareId = "u!" + base64;

                // 2. Baixar o CSV via Graph API shares endpoint
                using var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await httpClient.GetAsync(
                    $"https://graph.microsoft.com/v1.0/shares/{shareId}/driveItem/content");

                response.EnsureSuccessStatusCode();

                using var stream = await response.Content.ReadAsStreamAsync();
                using var reader = new StreamReader(stream);
                string csvCompleto = await reader.ReadToEndAsync();

                // 3. Processar Linhas (igual ao anterior)
                var linhas = csvCompleto.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string diaSelecionado = GetDiaSelecionado();

                foreach (var linha in linhas.Skip(1))
                {
                    var col = linha.Split(',');
                    if (col.Length < 5) continue;

                    var item = new GradeItem
                    {
                        DiaSemana = col[0].Trim().ToLower(),
                        Horario = col[1].Trim(),
                        Laboratorio = col[2].Trim().Replace(" ", ""),
                        Materia = col[3].Trim(),
                        Professor = col[4].Trim()
                    };

                    if (item.DiaSemana == diaSelecionado)
                    {
                        bool isNoturno = Regex.IsMatch(item.Horario, @"^(19|20|21|22)");
                        if (isNoturno)
                            DistribuirParaLabels(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar grade: " + ex.Message);
            }
        
        }

        // Verifica qual RadioButton está marcado
        private string GetDiaSelecionado()
        {
            if (Segunda_RB.Checked) return "segunda";
            if (Terca_RB.Checked) return "terça";
            if (Quarta_RB.Checked) return "quarta";
            if (Quinta_RB.Checked) return "quinta";
            if (Sexta_RB.Checked) return "sexta";
            return "";
        }
    

    private void DistribuirParaLabels(GradeItem item)
        {
            // Tenta encontrar pelo nome exato vindo do CSV (ex: InfoLab106B)
            string nomeLabel = "InfoLab" + item.Laboratorio;
            var label = this.Controls.Find(nomeLabel, true).FirstOrDefault() as Label;

            if (label != null)
            {
                label.Text = $"{item.Materia}\n{item.Professor}";
            }
            else
            {
                // Fallback: se o laboratório for "106B" e o label se chamar apenas "InfoLab106"
                if (item.Laboratorio.StartsWith("106"))
                {
                    InfoLab106.Text = $"{item.Materia}\n{item.Professor}";
                }
            }
        }
        }




public class AnonymousAuthenticationProvider : IAuthenticationProvider
    {
        public Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
            => Task.CompletedTask;
    }
}
