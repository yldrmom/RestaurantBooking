using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RestaurantBooking.Models;
using RestaurantBooking.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBooking.Forms
{
    public partial class CustomerFrm : Form
    {
        public CustomerFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                Customer customer = new Customer();
                customer.Name = txtName.Text.Trim();
                customer.Surname = txtSurname.Text.Trim();
                customer.Email = txtEmail.Text.Trim();
                customer.Address = txtAdress.Text.Trim();
                customer.Phone = txtPhone.Text.Trim();
                if (Name.IsNullOrEmpty() || customer.Surname.IsNullOrEmpty() || customer.Address.IsNullOrEmpty() || customer.Phone.IsNullOrEmpty())
                {
                    MessageBox.Show("Lütfen müşterinin ad, soyad, telefon ve adres bilgilerini giriniz");
                    return;

                }

                CustomerService customerServices = new CustomerService();
                customerServices.CustomerAdd(customer);
                MessageBox.Show("Müşteri başarıyla eklendi");
                LoadData();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Müşteri eklenirken bir hata oluştu");
            }
        }

        private void CustomerFrm_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void LoadData()
        {
            CustomerService customerService = new CustomerService();
            List<Customer> customers = customerService.GetAllCustomer();
            dtGridCustomer.DataSource = customers;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(dtGridCustomer.CurrentRow.Cells["id"].Value);
            CustomerService customerService = new CustomerService();
            customerService.Delete(selectedId);
            LoadData();

        }

      
      

        private void dtGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtGridCustomer.CurrentRow.Cells["id"].Value);

            RestaurantBookingContext context = new RestaurantBookingContext();
            Customer customer = context.Customers.FirstOrDefault(x => x.Id == id);
           
            txtCstmrAdress.Text = customer.Address;
            txtCstmrEmail.Text = customer.Email;

        }
        //private void btnUpdate_Click(object sender, EventArgs e)
        //{

        //    int id = Convert.ToInt32(dtGridCustomer.CurrentRow.Cells["id"].Value);
        //    RestaurantBookingContext context = new RestaurantBookingContext();
        //    Customer customer = context.Customers.FirstOrDefault(x => x.Id == id);
        //    customer.Address = txtCstmrAdress.Text;
        //    customer.Email = txtCstmrEmail.Text;
        //    CustomerService customerService = new CustomerService();
        //    customerService.Update(customer);
        //    LoadData();


        //}
    }
}
    
