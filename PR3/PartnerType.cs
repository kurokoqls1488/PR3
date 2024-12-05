using System;
using System.Collections.Generic;

namespace PR3;

public partial class PartnerType
{
    public short Id { get; set; }

    public string TypeOfPartner { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
