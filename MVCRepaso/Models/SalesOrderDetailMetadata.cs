using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVCRepaso.Models;

[ModelMetadataType(typeof(SalesOrderDetailMetadata))]
public partial class SalesOrderDetail { }

public class SalesOrderDetailMetadata
{
    public int SalesOrderID { get; set; }
    public int SalesOrderDetailID { get; set; }
   
    [Required]
    public string? CarrierTrackingNumber { get; set; }
    public short OrderQty { get; set; }
    public int ProductID { get; set; }
    public int SpecialOfferID { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal UnitPriceDiscount { get; set; }
    public decimal LineTotal { get; set; }
    public Guid rowguid { get; set; }
    public DateTime ModifiedDate { get; set; }
}