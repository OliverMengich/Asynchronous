using System;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.Collections;
using System.IO;
namespace AsyncModels
{
    class Program
    {
       static void Main(string[] args)
       {
            MyClass class1= new MyClass();
            // class1.DownloadHtmlAsync("");
       }
    }
    class MyClass
    {
        public async Task DownloadHtmlAsync(string url)
        {
            var webclient = new WebClient();
            var html = webclient.DownloadStringTaskAsync(url);
            using(var stringwriter = new StreamWriter(url))
            {
                await stringwriter.WriteAsync('r');
            }
        }
        public void OnBtnFetchClicked(object sender, EventArgs e)
        {
          var html = GetHtml("vcvdfbcx");
        }
        public string GetHtml(string url)
        {
           var webclient1 = new WebClient();
           return webclient1.DownloadString(url);   
        }
    }    
}
