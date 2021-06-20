using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_1_
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
        SimpleCrawler myCrawler = new SimpleCrawler(10);
        Thread thread;

        private void button1_Click(object sender, EventArgs e)
        {
            myCrawler.urls.Clear();
            myCrawler.startUrl = startUrlBox.Text;
            myCrawler.urls.Add(myCrawler.startUrl, false);//加入初始页面
            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(Crawl);
            thread.Start();
        }
        public void Crawl()
        {
            successCrawlBox.Text = "开始爬行了.... ";
            failedCrawlBox.Text = "开始爬行了.... ";
            myCrawler.pending.Enqueue(myCrawler.startUrl);
            List<Task> tasks = new List<Task>();
            while (tasks.Count < myCrawler.MaxPage)
            {
                string current = null;
                if (!myCrawler.pending.TryDequeue(out string url))
                {
                    if (myCrawler.completedCount < tasks.Count)
                    {
                        continue;
                    }
                    else
                    {
                        break;//所有任务都完成，队列无url
                    }
                }
                current = url;
                successCrawlBox.Text += "\r\n爬行" + current + "页面!";
                
                Task task = Task.Run(() => DownloadAndParse(current));
                tasks.Add(task);
                //if (completedCount >= tasks.Count) break;
            }
            Task.WaitAll(tasks.ToArray()); //等待剩余任务全部执行完毕
            successCrawlBox.Text += "\r\n爬行结束";
        }
        private void DownloadAndParse(string current)
        {
            string html = DownLoad(current); // 下载
            myCrawler.urls[current] = true;//表示已经爬完
            myCrawler.Parse(html);//解析,并加入新的链接
            myCrawler.completedCount++;
        }
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = myCrawler.completedCount.ToString();
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
