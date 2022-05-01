using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PABAIDU
{
    public static class Download
    {
        public static Stream DownLoadFile(string URL)
        {
            HttpWebRequest httpWeb = (HttpWebRequest)WebRequest.Create(URL);
            httpWeb.KeepAlive = false;
            httpWeb.Timeout = 30 * 1000;
            httpWeb.Method = "GET";
            httpWeb.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8";
            httpWeb.Host = "image.baidu.com";
            httpWeb.Referer = "https://image.baidu.com/search/index?tn=baiduimage&ps=1&ct=201326592&lm=-1&cl=2&nc=1&ie=utf-8&dyTabStr=MCw0LDYsMSw1LDMsNyw4LDIsOQ%3D%3D&word=attach.bbs.miui.com";
            httpWeb.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:99.0) Gecko/20100101 Firefox/99.0";
            HttpWebResponse webResponse = (HttpWebResponse)httpWeb.GetResponse();
            if (webResponse.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }
            return webResponse.GetResponseStream();
        }
        public static Boolean DownLoadFile(string URL, string Filename, string referer)
        {
            HttpWebRequest httpWeb = (HttpWebRequest)WebRequest.Create(URL);
            httpWeb.KeepAlive = false;
            httpWeb.Timeout = 30 * 1000;
            httpWeb.Method = "GET";
            httpWeb.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8";
            httpWeb.Host = URL.Split('/')[2];
            httpWeb.Referer = referer;
            httpWeb.UserAgent = GetUA();
            HttpWebResponse webResponse = (HttpWebResponse)httpWeb.GetResponse();
            if (webResponse.StatusCode != HttpStatusCode.OK)
            {
                return false;
            }
            //using (StreamReader sr = new StreamReader(webResponse.GetResponseStream()))
            //{
            //    Console.WriteLine(sr.ReadToEnd());
            //}
            using (FileStream fs = new FileStream(Filename, FileMode.Create))
            {
                webResponse.GetResponseStream().CopyTo(fs);
            }
            return true;
        }

        private static string GetUA()
        {
            string[] userAgent = {
                "Chrome Mobile	Mozilla/5.0 (Linux; U; Android 9; en-US; SM-G950F Build/PPR1.180610.011) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/78.0.3904.108 UCBrowser/13.4.0.1306 Mobile Safari/537.36",
"Chrome Mobile	Mozilla/5.0 (Linux; U; Android 9; zh-cn; RVL-AL09 Build/HUAWEIRVL-AL09) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/66.0.3359.126 MQQBrowser/10.7 Mobile Safari/537.36",
"Chrome Mobile	Mozilla/5.0 (Linux; U; Android 9; zh-cn; PDBM00 Build/PPR1.180610.011) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/77.0.3865.120 MQQBrowser/11.9 Mobile Safari/537.36 COVC/045709",
"Chrome Mobile	Mozilla/5.0 (Linux; Android 9; INE-AL00; HMSCore 6.1.0.313; GMSCore 19.6.29) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.93 HuaweiBrowser/11.1.5.310 Mobile Safari/537.36",
"Chrome Mobile	Mozilla/5.0 (Linux; Android 9; V1913A Build/P00610; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/87.0.4280.141 Mobile Safari/537.36 VivoBrowser/10.2.11.6",
"Chrome Mobile	Mozilla/5.0 (Linux; Android 9; V1934A Build/PPR1.180610.011; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/68.0.3440.91 Mobile Safari/537.36 iThunder;thirdChannel_SHOUJIXUNLEI/7.09.2.7123 xl_cloud",
"Chrome Mobile	Mozilla/5.0 (Linux; U; Android 9; zh-cn; MI 6X Build/PKQ1.180904.001) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/89.0.4389.116 Mobile Safari/537.36 XiaoMi/MiuiBrowser/15.4.12",
"Chrome Mobile	Mozilla/5.0 (Linux; Android 9; Mi Note 3 Build/PKQ1.181007.001; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/80.0.3987.99 Mobile Safari/537.36 iThunder;thirdChannel_SHOUJIXUNLEI/7.32.0.7705 xl_cloud statusBarHeight/66 statusBarHeightDp/24.0",
"Chrome Mobile	Mozilla/5.0 (Linux; U; Android 9; zh-cn; LLD-AL30 Build/HONORLLD-AL30) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/89.0.4389.72 MQQBrowser/12.0 Mobile Safari/537.36 COVC/045817",
"Chrome Mobile	Mozilla/5.0 (Linux; Android 9; COL-AL10; HMSCore 6.1.0.305; GMSCore 17.7.85) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.93 HuaweiBrowser/11.1.4.301 Mobile Safari/537.36",
"Chrome 9 Mozilla/5.0	(Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/92.0.4515.131 Safari/537.36",
"ChromeMozilla/5.0		(Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36",
"Microsoft Edge 	Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134",
"Chrome 8	Mozilla/5.0 (Windows NT 10.0; ) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36",
"Chrome 8	Mozilla/5.0 (Windows NT 10.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.198 Safari/537.36",
"Chrome 9	Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/94.0.4606.61 Safari/537.36",
"Chrome 8	Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36",
"Chrome 9	Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36",
"Chrome	Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36",
"Firefox 7	Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:78.0) Gecko/20100101 Firefox/78.0"
            };
            Random Ran = new Random();
            int i = Ran.Next(0, userAgent.Length);
            return userAgent[i];
        }
    }
}
