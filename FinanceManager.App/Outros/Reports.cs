using FinanceManager.Domain.Base;
using FinanceManager.Domain.Entities;
using ReaLTaiizor.Forms;

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
            testChart();
        }

        private void testChart()
        {
            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };

            formsPlot1.Plot.Add.Scatter(dataX, dataY);
            formsPlot1.Refresh();
        }
    }
}
