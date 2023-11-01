using System.Data.SqlClient;

namespace orderMaker
{
    public partial class Form1 : Form
    {
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            createConnection();
        }

        private void createConnection()
        {
            try
            {
                String strConnection = "Server=HANGOCLINH45AC;Database=BikeStores;Integrated Security = true";
                conn = new SqlConnection(strConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi SQL " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbStaffName.Text = AppData.fullname;
        }

        private void getCustomers()
        {
            //TODO: get toan bo thong tin nguoi dung
        }
    }
}