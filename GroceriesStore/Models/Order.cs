using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceriesStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage ="Please enter your First Name")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your Address")]
        [Display(Name = "Street Address")]
        [StringLength(150)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your ZipCode")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your Phone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        public List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }

    }
}
