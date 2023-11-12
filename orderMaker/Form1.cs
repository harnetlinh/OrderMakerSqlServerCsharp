using System.Data;
using System.Data.SqlClient;

namespace orderMaker
{
    public partial class Form1 : Form
    {
        SqlConnection conn;

        List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            createConnection();
            getCustomers();
            getProduct();
            getStore();
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
            string info = AppData.fullname;
            if (AppData.role == 1)
            {
                info += " (admin)";
            }
            lbStaffName.Text = info;
        }

        private void getCustomers()
        {
            conn.Open();
            //TODO: get toan bo thong tin nguoi dung
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM customers";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            // gan du lieu vao combo box
            while (reader.Read())
            {
                int customerId = Int32.Parse(reader["customer_id"].ToString());
                cbCustomer.Items.Add(customerId);
            }
            conn.Close();
        }

        private void getStore()
        {
            conn.Open();
            //TODO: get toan bo thong tin nguoi dung
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM stores";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            // gan du lieu vao combo box
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["store_id"].ToString());
                cbStore.Items.Add(productId);
            }
            conn.Close();
        }

        private void getProduct()
        {
            conn.Open();
            //TODO: get toan bo thong tin nguoi dung
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM products";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            // gan du lieu vao combo box
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["product_id"].ToString());
                string productName = reader["product_name"].ToString();
                double listPrice = Convert.ToDouble(reader["list_price"].ToString());
                Product _product = new Product(productId, productName, listPrice);
                products.Add(_product);
            }
            cbProduct.DataSource = products;
            cbProduct.DisplayMember = "ProductName";
            cbProduct.ValueMember = "productId";
            conn.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            int productId = Convert.ToInt32(cbProduct.SelectedValue);
            Product choosenProduct = products.Find(x => x.productId == productId);

            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("quantity", typeof(int));
            table.Rows.Clear();
            for (int i = 0; i < products.Count;  i++)
            {

            }
        }
    }
}

class Item
{
    public int productId { get; set; }
    public int quantity { get; set; }
    public double listPrice { get; set; }
    public int item { get; set; }

    public Item(int productId, int quantity, double listPrice)
    {
        this.productId = productId;
        this.quantity = quantity;
        this.listPrice = listPrice;
        this.item = 0;
    }
}

class Product
{
    public int productId { get; set; }
    public string productName { get; set; }
    public double listPrice { get; set; }

    public string Text;

    public Product(int ProductId, string ProductName, double listPrice)
    {
        this.productId = ProductId;
        this.productName = ProductName;
        this.listPrice = listPrice;
        this.Text = this.productName + " - " + this.listPrice;
    }

}

class listItem
{
    public List<Item> items { get; set; } = new List<Item>();

    public bool appendList(Item item)
    {
        bool isExisted = false;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].productId == item.productId)
            {
                isExisted = true;
                break;
            }
        }
        if (isExisted)
        {
            return false;
        }
        else
        {
            item.item = items.Count;
            items.Add(item);
            return true;
        }

    }
}
