using ASP_MVC_E_Commerce_Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_MVC_E_Commerce_Final_Project.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}