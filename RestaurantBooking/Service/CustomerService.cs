using RestaurantBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBooking.Service
{
    public class CustomerService
    {
        public void CustomerAdd(Customer customer)
        {
            RestaurantBookingContext context = new RestaurantBookingContext();
            context.Customers.Add(customer);
            context.SaveChanges();
           
        }
        public List<Customer> GetAllCustomer()
        {
            RestaurantBookingContext context = new RestaurantBookingContext();
            List<Customer> customer=context.Customers.ToList();
            return customer;

        }
        public void Delete(int id)
        {
            RestaurantBookingContext context = new RestaurantBookingContext();
            Customer customer= context.Customers.FirstOrDefault(x => x.Id == id);
            context.Customers.Remove(customer);
            context.SaveChanges();

        }
        //public void Update(Customer customer)
        //{
        //    RestaurantBookingContext context = new RestaurantBookingContext();
        //    Customer customer1 = context.Customers.FirstOrDefault(x => x.Id ==customer.Id);
            
        //    customer1.Email=customer.Email;
        //    customer1.Phone=customer.Phone;

        //    context.SaveChanges();

        //}
    }
}
