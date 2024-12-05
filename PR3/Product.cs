using System;
using System.Collections.Generic;

namespace PR3;

public partial class Product
{
    public int Id { get; set; }

    public short IdProductType { get; set; }

    public string NameProduct { get; set; } = null!;

    public string Article { get; set; } = null!;

    public decimal MinCostForPartner { get; set; }

    public virtual ProductType IdProductTypeNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
