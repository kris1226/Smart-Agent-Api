using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smart_Agent.Web.Models
{
    public class Client
    {
        public Guid ClientKey { get; set; }
        public List<Guid> ClientLocationKey { get; set; }
        public List<Guid> FacilityKey { get; set; }
        public List<String> OrderMap { get; set; }
        public List<String> ClientLocationName { get; set; }
        public String ClientName { get; set; }
        public String Tpid { get; set; }
        public String FacilityId { get; set; }
        public String ClientId { get; set; }
    }
}