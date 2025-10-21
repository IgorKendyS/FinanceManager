using FinanceManager.Domain.Base;
using FinanceManager.Domain.Entities;
using ReaLTaiizor.Forms;
using ScottPlot;

namespace FinanceManager.App.Outros
{
    public partial class Reports : MaterialForm
    {
        private readonly IBaseService<Transaction> _transactionService;

        // Modifique o construtor
        public Reports(IBaseService<Transaction> transactionService)
        {
            InitializeComponent();
            _transactionService = transactionService;
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Busca os dados reais do serviço
                var dailyExpenses = _transactionService.GetDailyExpenses();

                if (!dailyExpenses.Any())
                {
                    MessageBox.Show("Não há dados de despesas para exibir no gráfico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2. Prepara os dados para o gráfico
                var sortedData = dailyExpenses.OrderBy(kvp => kvp.Key).ToList();
                double[] values = sortedData.Select(kvp => (double)kvp.Value).ToArray();
                double[] positions = sortedData.Select(kvp => kvp.Key.ToOADate()).ToArray();
                string[] labels = sortedData.Select(kvp => kvp.Key.ToString("dd/MM")).ToArray();

                // 3. Chama seu método para criar o gráfico com os dados reais
                CreateBarChart("Gastos Diários", "Data", "Valor Gasto (R$)", positions, values, labels);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o gráfico: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Pequeno ajuste para aceitar os labels do eixo X
        private void CreateBarChart(string title, string xLabel, string yLabel, double[] positions, double[] values, string[] labels)
        {
            var plt = formsPlot1.Plot;
            plt.Clear();
            
            plt.AddBar(values, positions);
            plt.Title(title);
            plt.XLabel(xLabel);
            plt.YLabel(yLabel);

            // Adiciona os labels formatados no eixo X
            plt.XTicks(positions, labels);
            plt.XAxis.TickLabelStyle(rotation: 45);

            plt.SetAxisLimits(yMin: 0); // Garante que o eixo Y comece em 0
            
            formsPlot1.Refresh();
        }

        private void formsPlot2_Load(object sender, EventArgs e)
        {
            DoubleAxis();
        }

        private void DoubleAxis()
        {
            var plt = formsPlot2.Plot;
            plt.Clear();

            // Sinal 1 → eixo padrão (esquerda)
            double[] sin = DataGen.Sin(51, mult: 10);
            plt.AddSignal(sin, color: System.Drawing.Color.Blue);
            plt.YLabel("Eixo Y Principal");

            // Sinal 2 → eixo da direita
            double[] cos = DataGen.Cos(51, mult: 100);
            var sig2 = plt.AddSignal(cos, color: System.Drawing.Color.Red);
            sig2.YAxisIndex = 1; // usa eixo da direita

            plt.YAxis2.Label("Eixo Y Secundário");
            plt.YAxis2.Ticks(true);
            plt.YAxis2.IsVisible = true; // ESSENCIAL

            plt.XLabel("Índice");
            plt.Title("Dois sinais com dois eixos Y");

            formsPlot2.Refresh();
        }
    }
}
