using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace DoubleColoredBall
{
    public class Reptile
    {
        HttpHelper httpHelper = new HttpHelper();

        public string GetHtml()
        {
            HttpItem httpItem = new HttpItem()
            {
                Host = "www.cwl.gov.cn",
                URL = "http://www.cwl.gov.cn/cwl_admin/kjxx/findDrawNotice?name=ssq&issueCount=30",
                Accept = "application/json, text/javascript, */*; q=0.01",
                Referer = "http://www.cwl.gov.cn/kjxx/ssq/kjgg/",
                ResultCookieType = ResultCookieType.CookieCollection,
                ResultType = ResultType.String
            };
            
            HttpResult httpResult = httpHelper.GetHtml(httpItem);
            string jsonString = httpResult.Html;
            
            //解析json


            return jsonString;
        }
    }
}
