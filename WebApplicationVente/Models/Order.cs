using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVente.Models
{
    public class Order
    {   [BindNever]
        [Key]
        public int OrdereId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        [Required (ErrorMessage ="Veuiller Saisir votre Nom")]
        [Display(Name ="First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Veuiller Saisir votre Prenom")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName{ get; set; }
        [Required(ErrorMessage = "Veuiller Saisir votre Adresse")]
        [Display(Name = "Adrèsse")]
        [StringLength(250)]
        public string AdresseLine1{ get; set; }
        public string AdresseLine2 { get; set; }
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Veuiller Saisir votre Ville")]
        [StringLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Veuiller Saisir votre Ville")]
        [StringLength(50)]
        public string State { get; set; }
        public string Country { get; set; }

        [Required(ErrorMessage = "Veuiller Saisir Votre Phone")]
        [Display(Name = "Téléphone")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
ErrorMessage = "The email address is not entered in a correct format")]
        public string Email { get; set; }
        [BindNever]
        public double OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }






    }
}
