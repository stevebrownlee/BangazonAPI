using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bangazon.Models
{
  public class CustomerFave
  {
    [Key]
    public int CustomerFaveId {get;set;}
    public int CustomerId { get; set; }

    public Customer Customer { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }

    [Required]
    [Range(0,1)]
    public byte Like { get; set; }
  }
}
