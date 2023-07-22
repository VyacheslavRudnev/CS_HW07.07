using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainForHW.Models
{
    public class Website
    {
        private string _siteName;
        private string _siteUrl;
        private string _siteDescription;
        private string _siteIp;
        
        public string SiteName
        {
            get { return _siteName; }
            set { _siteName = value; }
        }
        public string SiteUrl
        {
            get { return _siteUrl; }
            set { _siteUrl = value; }
        }
        public string SiteDescription
        {
            get { return _siteDescription; }
            set { _siteDescription = value; }
        }
        public string SiteIp
        {
            get { return _siteIp; }
            set { _siteIp = value; }
        }
        public Website() { }
        public Website(string siteName, string siteUrl, string siteDescription, string siteIp)
        {
            SiteName = siteName;
            SiteUrl = siteUrl;
            SiteDescription = siteDescription;
            SiteIp = siteIp;
        }
        public override string ToString()
        {
            return  $"Site name: {SiteName}\n" +
                    $"Site url: {SiteUrl}\n" +
                    $"Site description: {SiteDescription}\n" +
                    $"Site ip: {SiteIp}\n";
        }
        public void SetInfo()
        {
            Console.Write("Вкажіть назву сайту (компанії): ");
            SiteName = Console.ReadLine();
            Console.Write("Вкажіть повну адресу сайту (url): ");
            SiteUrl = Console.ReadLine();
            Console.WriteLine("Вкажіть опис сайту: ");
            SiteDescription = Console.ReadLine();
            Console.WriteLine("Вкажіть IP-адресу сайту:");
            SiteIp = Console.ReadLine();
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Назва сайту (компанії): {SiteName}\n" +
                $"Адреса сайту (url): {SiteUrl}\n" +
                $"Опис сайту: {SiteDescription}\n" +
                $"IP-адреса сайту: {SiteIp}");
        }
        
        


    }
}
