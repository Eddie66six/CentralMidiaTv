using System;
using System.Web;

namespace CentralMidiaTv.Aplicacao._2_Data
{
    public class DomainNotification
    {
        public DomainNotification(string key, string value)
        {
            Key = key;
            Value = value;
            Date = DateTime.UtcNow;
            HttpContext.Current.Items["DomainNotification.message"] = this;
        }

        public string Key { get; private set; }
        public string Value { get; private set; }
        public DateTime Date { get; }
    }
}