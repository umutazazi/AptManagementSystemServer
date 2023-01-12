using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CinsAptServer
{
    public class Currency
    {
        string exchangeRate;
        XmlDocument xmlDoc;
        string usd;
        string eur;

        public string getCurrency()
        {
            exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
            xmlDoc = new XmlDocument();
            xmlDoc.Load(exchangeRate);
            usd = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod ='USD']/BanknoteSelling").InnerXml;
            eur = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod ='EUR']/BanknoteSelling").InnerXml;

            return  "\n"+usd.Substring(0, 5) +"\n"+eur.Substring(0, 5);
        }


    }
}
