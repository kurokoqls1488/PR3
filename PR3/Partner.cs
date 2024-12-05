using System;
using System.Collections.Generic;

namespace PR3;

public partial class Partner
{
    public int Id { get; set; }

    public short IdPartner { get; set; }

    public string NamePartner { get; set; } = null!;

    public string LegalAddress { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string Fiodirector { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public float Rating { get; set; }

    public virtual PartnerType IdPartnerNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
