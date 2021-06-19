using System.Collections;
using System.Text.RegularExpressions;
namespace _10._1
{
    class SimpleCrawler
        {
            public Hashtable urls {set;get; }= new Hashtable();
            public int count { get; set; } = 0;
            public string startUrl { set; get; }
            

            public void Parse(string html)
            {
                string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(html|aspx|jsp)[""']";
                //找超链接，要求以html/aspx/jsp结尾
                MatchCollection matches = new Regex(strRef).Matches(html);
                foreach (Match match in matches)
                {
                    strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                              .Trim('"', '\"', '#', '>');//把href标签中的URL取出来
                    if (strRef.Length == 0) continue;//如果没有网址，就找下一个超链接
                                                     //相对路径转绝对路径
                    string temp = @"^[^/]";
                    if (!strRef.Contains("://") && Regex.IsMatch(strRef, temp))
                        strRef = startUrl + strRef;//加上XXX
                    int index = startUrl.IndexOf(':');

                    //如果是指定网址的，就将URL放入hashtable中
                    if (urls[strRef] == null && strRef.Contains(startUrl.Substring(index))) urls[strRef] = false;
                }
            }
        }
    }
