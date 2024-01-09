﻿using System;
using System.Collections.Generic;

namespace Pet_Shop2.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? OrderNumber { get; set; }

    public int? Quantity { get; set; }

    public decimal? Total { get; set; }

    public virtual Order? Order { get; set; }
}
