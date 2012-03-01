﻿using System;
using System.Collections.Generic;

namespace JobSystem.DataModel.Entities
{
	[Serializable]
	public class Quote
	{
		public virtual Guid Id { get; set; }
		public virtual string QuoteNumber { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual UserAccount CreatedBy { get; set; }
		public virtual DateTime DateCreated { get; set; }
		public virtual string OrderNumber { get; set; }
		public virtual string AdviceNumber { get; set; }
		public virtual ListItem Currency { get; set; }
		public virtual bool IsActive { get; set; }
		public virtual IList<QuoteItem> QuoteItems { get; set; }

		public Quote()
		{
			QuoteItems = new List<QuoteItem>();
		}
	}
}