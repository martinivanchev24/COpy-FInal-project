using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project
{
    public partial class OrderMenu_Form4 : Form
    {

        string username;
        public OrderMenu_Form4(string givenUsername)
        {
            InitializeComponent();
            username = givenUsername;
        }
        //public OrderMenu_Form4()
        //{
        //    InitializeComponent();
        //}
        private void OrderMenu_Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            nameOfProduct1Label.Visible = false;
            nameOfProduct2Label.Visible = false;
            nameOfProduct3Label.Visible = false;
            quantityOfProduct1ComboBox.Visible = false;
            quantityOfProduct2ComboBox.Visible = false;
            quantityOfProduct3ComboBox.Visible = false;
            priceLabelProduct1.Visible = false;
            priceLabelProduct2.Visible = false;
            priceLabelProduct3.Visible = false;
            deliveryAdressTextBox.ReadOnly = true;
            payInCashRadioButton.Checked = true;
            int orderID = 101;

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=finalproject;Integrated Security=True"))
            {


                connection.Open();
                SqlCommand command2 = new SqlCommand("SELECT TOP 1 * FROM Orders ORDER BY OrderID DESC", connection);
                orderID = (int)command2.ExecuteScalar();

            }
            int numberOfProducts = 0;

            string sqlGetProducts = @"
        SELECT OrderItems.Quantity, OrderItems.Price, OrderItems.TotalPrice, product_inventory.mainPhoto, product_inventory.productName
        FROM OrderItems
        INNER JOIN product_inventory ON OrderItems.ProductID = product_inventory.product_id
        WHERE OrderItems.OrderID = @OrderID";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=finalproject;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand(sqlGetProducts, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    numberOfProducts = table.Rows.Count;

                    switch (numberOfProducts)
                    {
                        case 1:
                            pictureBox1.Image = ByteArrayToImage((byte[])table.Rows[0]["mainPhoto"]);
                            nameOfProduct1Label.Text = table.Rows[0]["productName"].ToString();
                            quantityOfProduct1ComboBox.Text = table.Rows[0]["Quantity"].ToString();
                            priceLabelProduct1.Text = table.Rows[0]["Price"].ToString();
                            pictureBox1.Visible = true;
                            nameOfProduct1Label.Visible = true;
                            quantityOfProduct1ComboBox.Visible = true;
                            priceLabelProduct1.Visible = true;
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                            break;

                        case 2:
                            pictureBox1.Image = ByteArrayToImage((byte[])table.Rows[0]["mainPhoto"]);
                            nameOfProduct1Label.Text = table.Rows[0]["productName"].ToString();
                            quantityOfProduct1ComboBox.Text = table.Rows[0]["Quantity"].ToString();
                            priceLabelProduct1.Text = table.Rows[0]["Price"].ToString();
                            pictureBox2.Image = ByteArrayToImage((byte[])table.Rows[1]["mainPhoto"]);
                            nameOfProduct2Label.Text = table.Rows[1]["productName"].ToString();
                            quantityOfProduct2ComboBox.Text = table.Rows[1]["Quantity"].ToString();
                            priceLabelProduct2.Text = table.Rows[1]["Price"].ToString();
                            pictureBox1.Visible = true;
                            pictureBox2.Visible = true;
                            nameOfProduct1Label.Visible = true;
                            nameOfProduct2Label.Visible = true;
                            quantityOfProduct1ComboBox.Visible = true;
                            quantityOfProduct2ComboBox.Visible = true;
                            priceLabelProduct1.Visible = true;
                            priceLabelProduct2.Visible = true;
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                            break;
                        case 3:
                            pictureBox1.Image = ByteArrayToImage((byte[])table.Rows[0]["mainPhoto"]);
                            nameOfProduct1Label.Text = table.Rows[0]["productName"].ToString();
                            quantityOfProduct1ComboBox.Text = table.Rows[0]["Quantity"].ToString();
                            priceLabelProduct1.Text = table.Rows[0]["Price"].ToString();
                            pictureBox2.Image = ByteArrayToImage((byte[])table.Rows[1]["mainPhoto"]);
                            nameOfProduct2Label.Text = table.Rows[1]["productName"].ToString();
                            quantityOfProduct2ComboBox.Text = table.Rows[1]["Quantity"].ToString();
                            priceLabelProduct2.Text = table.Rows[1]["Price"].ToString();
                            pictureBox3.Image = ByteArrayToImage((byte[])table.Rows[2]["mainPhoto"]);
                            nameOfProduct3Label.Text = table.Rows[2]["productName"].ToString();
                            quantityOfProduct3ComboBox.Text = table.Rows[2]["Quantity"].ToString();
                            priceLabelProduct3.Text = table.Rows[2]["Price"].ToString();
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.Visible = true;
                            pictureBox2.Visible = true;
                            pictureBox3.Visible = true;
                            nameOfProduct1Label.Visible = true;
                            nameOfProduct2Label.Visible = true;
                            nameOfProduct3Label.Visible = true;
                            quantityOfProduct1ComboBox.Visible = true;
                            quantityOfProduct2ComboBox.Visible = true;
                            quantityOfProduct3ComboBox.Visible = true;
                            priceLabelProduct1.Visible = true;
                            priceLabelProduct2.Visible = true;
                            priceLabelProduct3.Visible = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            //            string sql = "SELECT location_details.street, location_of_adress.city, " +
            //"location_of_adress.country\r\nFROM accountdetails\r\n" +
            //"JOIN location_details ON accountdetails.adress_id = location_details.adress_id\r\n" +
            //"JOIN location_of_adress ON location_details.postal_code = location_of_adress.postal_code\r\n" +
            //"WHERE accountdetails.username = @Username";
            string sql = "SELECT Address,Country, City, PostalCode FROM Users Where Username=@Username";




            using (SqlConnection connection2 = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=finalproject;Integrated Security=True"))
            {
                using (SqlCommand command2 = new SqlCommand(sql, connection2))
                {
                    try
                    {
                        command2.Parameters.AddWithValue("@Username", username);
                        connection2.Open();
                        SqlDataReader reader = command2.ExecuteReader();

                        if (reader.Read())
                        {
                            string country = reader["Country"].ToString();
                            string city = reader["City"].ToString();
                            string street = reader["Address"].ToString();
                            string code = reader["PostalCode"].ToString();
                            deliveryAdressTextBox.Text = $"{code},{country}, {city}, {street}";
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        if (connection2.State == ConnectionState.Open)
                        {
                            connection2.Close();
                        }
                    }
                }
            }
        }













        private void payInCashRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string paymentOption = "Cash";
            payWithCardRadioButton.Checked = false;
        }

        private void payWithCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string paymentOption = "Cash";
            payInCashRadioButton.Checked = false;


        }

        private void changeAdressButton_Click(object sender, EventArgs e)
        {
            deliveryAdressTextBox.ReadOnly = false;

        }






        //private void toPaymentButton_Click(object sender, EventArgs e)
        //{
        //    //    try
        //    //    {
        //    //        using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-201A2LL;Initial Catalog=townsApp;Integrated Security=True"))
        //    //        {
        //    //            con.Open();

        //    //            SqlCommand cmd = new SqlCommand("UPDATE User_Profiles SET, firstName=@firstname, lastName=@lastname, country=@country, gender=@gender WHERE username=@username", con);
        //    //            cmd.Parameters.AddWithValue("@firstname", firstNameTextBox.Text);
        //    //            cmd.Parameters.AddWithValue("@lastname", lastNameTextBox.Text);
        //    //            cmd.Parameters.AddWithValue("@country", countryTextBox.Text);
        //    //            cmd.Parameters.AddWithValue("@gender", genderTextBox.Text);
        //    //            cmd.Parameters.AddWithValue("@username", username);
        //    //            int result = cmd.ExecuteNonQuery();
        //    //            MessageBox.Show(result + "");

        //    //        }

        //    //        MessageBox.Show("Data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    }
        //    //    catch (SqlException exc)
        //    //    {
        //    //        MessageBox.Show(exc.Message);
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        MessageBox.Show($"Error uploading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    }
        //    //}




        //    //private byte[] ImageToByteArray(Image picture)
        //    //{
        //    //    using (MemoryStream stream = new MemoryStream())
        //    //    {
        //    //        picture.Save(stream, picture.RawFormat);
        //    //        return stream.ToArray();
        //    //    }
        //    //}
        private Image ByteArrayToImage(byte[] data)
        {
            using (MemoryStream stream = new MemoryStream(data))
            {
                return Image.FromStream(stream);
            }
        }

        private void toPaymentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order sent!");

            string connectionString = @"Data Source=DESKTOP-201A2LL;Initial Catalog=finalproject;Integrated Security=True";
            string query1 = "INSERT INTO Orders (username,OrderDate,DeliveryAddress,PaymentType) VALUES (@username,@OrderDate,@DeliveryAdress,@PaymentType)";
            int OrderID = 0;
            DateTime currentDateTime = DateTime.Now;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Open the connection here

                SqlCommand command = new SqlCommand(query1, connection);
                string paymentType = "";

                if (payWithCardRadioButton.Checked == true)
                {
                    paymentType = "card";
                }
                else
                {
                    paymentType = "cash";
                }

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@OrderDate", currentDateTime);
                command.Parameters.AddWithValue("@DeliveryAdress", deliveryAdressTextBox.Text);
                command.Parameters.AddWithValue("@PaymentType", paymentType);

                command.ExecuteNonQuery();

                // Retrieve the newly inserted OrderID
                SqlCommand command2 = new SqlCommand("SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID DESC", connection);
                OrderID = (int)command2.ExecuteScalar();

               
                if (!string.IsNullOrEmpty(quantityOfProduct3ComboBox.Text))
                {
                    MessageBox.Show("first if");
                    SqlCommand command3 = new SqlCommand("UPDATE OrderItems SET Quantity = @Quantity3 WHERE OrderItemID = (SELECT TOP 1 OrderItemID FROM OrderItems ORDER BY OrderItemID DESC)",connection);
                    command3.Parameters.AddWithValue("@Quantity3", quantityOfProduct3ComboBox.Text);
                    command3.ExecuteNonQuery();
                    SqlCommand command4 = new SqlCommand("UPDATE OrderItems SET Quantity = @Quantity2 WHERE OrderItemID = (SELECT OrderItemID FROM (SELECT OrderItemID FROM OrderItems ORDER BY OrderItemID DESC OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY) AS Subquery)", connection);
                    command4.Parameters.AddWithValue("@Quantity2", quantityOfProduct2ComboBox.Text);
                    command4.ExecuteNonQuery();
                    SqlCommand command5 = new SqlCommand("UPDATE OrderItems SET Quantity = @Quantity1 WHERE OrderItemID = (SELECT OrderItemID FROM (SELECT OrderItemID FROM OrderItems ORDER BY OrderItemID DESC OFFSET 2 ROWS FETCH NEXT 1 ROWS ONLY) AS Subquery)", connection);
                    command5.Parameters.AddWithValue("@Quantity1", quantityOfProduct1ComboBox.Text);
                    command5.ExecuteNonQuery(); 
                }
                if (!string.IsNullOrEmpty(quantityOfProduct2ComboBox.Text))
                {
                    MessageBox.Show("second if");
                    SqlCommand command4 = new SqlCommand("UPDATE OrderItems SET Quantity = @Quantity2 WHERE OrderItemID = (SELECT OrderItemID FROM (SELECT OrderItemID FROM OrderItems ORDER BY OrderItemID DESC OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY) AS Subquery)", connection);
                    command4.Parameters.AddWithValue("@Quantity2", quantityOfProduct1ComboBox.Text);
                    command4.ExecuteNonQuery();
                    SqlCommand command3 = new SqlCommand("UPDATE OrderItems SET Quantity = @Quantity3 WHERE OrderItemID = (SELECT TOP 1 OrderItemID FROM OrderItems ORDER BY OrderItemID DESC)", connection);
                    command3.Parameters.AddWithValue("@Quantity3", quantityOfProduct2ComboBox.Text);
                    command3.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("third if");
                    SqlCommand command3 = new SqlCommand("UPDATE OrderItems SET Quantity = @Quantity3 WHERE OrderItemID = (SELECT TOP 1 OrderItemID FROM OrderItems ORDER BY OrderItemID DESC)", connection);
                    command3.Parameters.AddWithValue("@Quantity3", quantityOfProduct1ComboBox.Text);
                    command3.ExecuteNonQuery();
                }

            }

            MainForm g = new MainForm(username, OrderID);
            g.Show();
            this.Close();
        }




        //}
    }
}
