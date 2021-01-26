using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFramework
{
    public partial class MailConfig
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int IdBaseConfig { get; set; }

        public virtual BaseConfig IdBaseConfigNavigation { get; set; }
    }
}
