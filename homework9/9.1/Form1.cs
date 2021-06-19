using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace _10._1
{
    public partial class Form1 : Form
    {
        [System.ComponentModel.Browsable(false)]
        public static new bool CheckForIllegalCrossThreadCalls = false;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //这样就没有<线程间操作无效: 从不是创建控件"Form1"的线程访问它>报错了
        }
        SimpleCrawler myCrawler = new SimpleCrawler();

        private void button1_Click(object sender, EventArgs e)
        {
            myCrawler.startUrl = startUrlBox.Text;
            myCrawler.urls.Add(myCrawler.startUrl, false);//加入初始页面
            //new Thread(Crawl).Start();
        }
        public void Crawl()
        {
            successCrawlBox.Text = "开始爬行了.... ";
            failedCrawlBox.Text = "开始爬行了.... ";
            while (true)
            {
                string current = null;
                foreach (string url in myCrawler.urls.Keys)
                {
                    if ((bool)myCrawler.urls[url]) continue;//一直爬到下一个是true为止
                    current = url;
                }

                if (current == null || myCrawler.count > 10) break;//如果没有输入的页面或者已经爬完了10个页面
                successCrawlBox.Text+= "\r\n爬行" + current + "页面!";
                string html = DownLoad(current); // 下载
                myCrawler.urls[current] = true;//表示已经爬完
                myCrawler.count++;
                myCrawler.Parse(html);//解析,并加入新的链接
                successCrawlBox.Text += "\r\n爬行结束";
            }
        }
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = myCrawler.count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                successCrawlBox.Text += "\r\n爬取成功！";
                return html;
            }
            catch (Exception ex)
            {
                failedCrawlBox.Text += $"\r\n爬取{url}失败\r\n{ex.Message}";
                return "";
            }
        }

    }
}
