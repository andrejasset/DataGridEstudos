using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;


namespace DataGridEstudos
{
    public partial class FormPrincipal : Form
    {
        //string de conexão
        private string connectionString = "Server=localhost;Port=3306;Database=ExemploDataGridView;Uid=root;Pwd=Info@2025;";
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormAdicionarCliente cadastrar = new FormAdicionarCliente();
            cadastrar.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregarDados();

        }

        private void CarregarDados()
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Clientes";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();  
                    adapter.Fill(dataTable);    
                    dataGridView1.DataSource = dataTable;   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
