using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fanjian.Controllers
{
    public class fanjianServletController : Controller
    {
        public IActionResult Index(String page, String code)
        {
            Response.ContentType=("text/plain;charset=utf-8");
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.Headers.Add("Access-Control-Allow-Methods", "POST");
            Response.Headers.Add("Access-Control-Allow-Headers",
                "x-requested-with,content-type");
            String url = "http://m.ifanjian.net";
            if (code != null && code!=(""))
            {
                url = url + "/post/" + code;
            }
            else if (page!=("1"))
            {
                url = url + "/latest-" + page;
            }
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.UserAgent = "Mozilla/5.0 (Linux; U; Android 8.1.0; zh-cn; BLA-AL00 Build/HUAWEIBLA-AL00) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/57.0.2987.132 MQQBrowser/8.9 Mobile Safari/537.36";


            Stream responseStream = (request.GetResponse() as HttpWebResponse).GetResponseStream();
            StreamReader sr = new StreamReader(responseStream);
            var result = sr.ReadToEnd();
            sr.Close();
            sr.Dispose();
            responseStream.Close();
            responseStream.Dispose();
            return Content(result);
        }
    }
}