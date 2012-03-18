﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace JobSystem.Mvc.ViewModels.Orders
{
	public class OrderItemCreateViewModel
	{
		public Guid Id { get; set; }
		public Guid OrderId { get; set; }
		[Display(Name = "Supplier")]
		[Required]
		public Guid SupplierId { get; set; }
		public string Instructions { get; set; }
		public string Description { get; set; }
		[Display(Name = "Part Number")]
		public string PartNo { get; set; }
		[Display(Name = "Delivery Days")]
		public int DeliveryDays { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		[Display(Name = "Currency")]
		public IEnumerable<SelectListItem> Currencies { get; set; }
		public Guid CurrencyId { get; set; }
	}
}