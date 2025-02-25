using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinanceManager.Domain.Entities;
using FinanceManager.Domain.Base;

namespace FinanceManager.App.Outros
{
    public partial class Reports : Form
    {
        private readonly IBaseService<Transaction> _transactionService;

        public Reports(IBaseService<Transaction> transactionService)
        {
            _transactionService = transactionService;

            InitializeComponent();
            ConfigurarWebView();
            CarregarGraficos();
        }

        public class CategoriaGasto
        {
            public string Categoria { get; set; }
            public decimal Total { get; set; }
        }

        public class MetodoPagamentoGasto
        {
            public string Metodo { get; set; }
            public decimal Total { get; set; }
        }

        public class GastoPorData
        {
            public string Data { get; set; }
            public decimal Total { get; set; }
        }

        private void ConfigurarWebView()
        {
            webViewReport = new WebView2
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(webViewReport);
            webViewReport.EnsureCoreWebView2Async();
        }

        private void CarregarGraficos()
        {
            var transactions = _transactionService.Get<Transaction>().ToList();

            var gastosPorCategoria = transactions
                .GroupBy(t => t.CategoryId)
                .Select(g => new CategoriaGasto { Categoria = GetCategoryById(g.Key), Total = g.Sum(t => t.Amount) })
                .ToList();

            var gastosPorPagamento = transactions
                .GroupBy(t => t.PaymentMethodId.HasValue ? t.PaymentMethodId.Value : -1)
                .Select(g => new MetodoPagamentoGasto { Metodo = GetPaymentMethodName(g.Key), Total = g.Sum(t => t.Amount) })
                .ToList();

            var gastosPorData = transactions
                .GroupBy(t => t.Date.Date)
                .Select(g => new GastoPorData { Data = g.Key.ToString("yyyy-MM-dd"), Total = g.Sum(t => t.Amount) })
                .OrderBy(g => g.Data)
                .ToList();

            string html = GerarHtml(gastosPorCategoria, gastosPorPagamento, gastosPorData);
            webViewReport.NavigateToString(html);
        }

        private string GetCategoryById(int categoryId)
        {
            var category = _transactionService.GetById<Category>(categoryId);
            return category?.Name ?? "Outros";
        }

        private string GetPaymentMethodName(int paymentMethodId)
        {
            return paymentMethodId switch
            {
                0 => "Crédito",
                1 => "Débito",
                2 => "Dinheiro",
                _ => "Outro"
            };
        }

        private string GerarHtml(List<CategoriaGasto> categorias, List<MetodoPagamentoGasto> metodosPagamento, List<GastoPorData> datas)
        {
            StringBuilder html = new StringBuilder();

            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html lang='pt-br'>");
            html.AppendLine("<head>");
            html.AppendLine("<meta charset='UTF-8'>");
            html.AppendLine("<meta name='viewport' content='width=device-width, initial-scale=1.0'>");
            html.AppendLine("<title>Relatórios Financeiros</title>");
            html.AppendLine("<script src='https://cdn.jsdelivr.net/npm/chart.js'></script>");
            html.AppendLine("<style>");
            html.AppendLine("body { font-family: Arial, sans-serif; text-align: center; background-color: #f4f4f4; }");
            html.AppendLine("canvas { max-width: 600px; margin: 20px auto; display: block; }");
            html.AppendLine("</style>");
            html.AppendLine("</head>");
            html.AppendLine("<body>");

            html.AppendLine("<h2>Gastos por Categoria</h2>");
            html.AppendLine("<canvas id='chartCategoria'></canvas>");
            html.AppendLine("<h2>Gastos por Método de Pagamento</h2>");
            html.AppendLine("<canvas id='chartPagamento'></canvas>");
            html.AppendLine("<h2>Evolução dos Gastos</h2>");
            html.AppendLine("<canvas id='chartLinha'></canvas>");

            html.AppendLine("<script>");
            html.AppendLine("document.addEventListener('DOMContentLoaded', function() {");

            html.AppendLine("new Chart(document.getElementById('chartCategoria'), {");
            html.AppendLine("  type: 'pie',");
            html.AppendLine("  data: {");
            html.AppendLine($"    labels: [{string.Join(",", categorias.Select(c => $"'{c.Categoria}'"))}],");
            html.AppendLine($"    datasets: [{{ data: [{string.Join(",", categorias.Select(c => c.Total))}], backgroundColor: ['#ff6384', '#36a2eb', '#ffce56', '#4bc0c0', '#9966ff', '#ff9f40'] }}]");
            html.AppendLine("  }");
            html.AppendLine("});");

            html.AppendLine("new Chart(document.getElementById('chartPagamento'), {");
            html.AppendLine("  type: 'bar',");
            html.AppendLine("  data: {");
            html.AppendLine($"    labels: [{string.Join(",", metodosPagamento.Select(m => $"'{m.Metodo}'"))}],");
            html.AppendLine($"    datasets: [{{ label: 'Total ($)', data: [{string.Join(",", metodosPagamento.Select(m => m.Total))}], backgroundColor: '#36a2eb' }}]");
            html.AppendLine("  },");
            html.AppendLine("  options: { responsive: true, scales: { y: { beginAtZero: true } } }");
            html.AppendLine("});");

            html.AppendLine("new Chart(document.getElementById('chartLinha'), {");
            html.AppendLine("  type: 'line',");
            html.AppendLine("  data: {");
            html.AppendLine($"    labels: [{string.Join(",", datas.Select(d => $"'{d.Data}'"))}],");
            html.AppendLine($"    datasets: [{{ label: 'Gastos ($)', data: [{string.Join(",", datas.Select(d => d.Total))}], borderColor: '#ff6384', fill: false }}]");
            html.AppendLine("  },");
            html.AppendLine("  options: { responsive: true, scales: { y: { beginAtZero: true } } }");
            html.AppendLine("});");

            html.AppendLine("});");
            html.AppendLine("</script>");

            html.AppendLine("</body>");
            html.AppendLine("</html>");

            return html.ToString();
        }
    }
}
