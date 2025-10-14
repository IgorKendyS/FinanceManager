using ReaLTaiizor.Forms;
using ScottPlot;

namespace FinanceManager.App.Outros
{
    public partial class Reports : MaterialForm
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
            CreateChart();
        }

        private void CreateChart()
        {
            double[] dataX = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] dataY = { 10, 20, 30, 25, 15, 40, 50, 60, 70, 80 };

            var plt = formsPlot1.Plot;
            plt.Clear();

            plt.AddBar(dataY, dataX);
            plt.Title("Gráfico de Barras");
            plt.XLabel("Dias");
            plt.YLabel("Valores");

            formsPlot1.Refresh();
        }

        private void formsPlot2_Load(object sender, EventArgs e)
        {
            CreateMonthlyChart();
        }

        private void CreateMonthlyChart()
        {
            var plt = formsPlot2.Plot; // <<< AQUI ESTAVA O ERRO!
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
