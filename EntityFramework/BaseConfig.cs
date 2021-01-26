using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFramework
{
    public partial class BaseConfig
    {
        //public BaseConfig()
        //{
        //    MailConfigs = new HashSet<MailConfig>();
        //    WebServiceConfigs = new HashSet<WebServiceConfig>();
        //}

        public int Id { get; set; }
        public string Value { get; set; }

        public virtual MailConfig MailConfigs { get; set; }
        public virtual WebServiceConfig WebServiceConfigs { get; set; }
    }
}
