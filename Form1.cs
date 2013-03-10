using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace Frank.MyDownloader
{
    public partial class Form1 : Form
    {
        //定义时间全局变量
        //定时器
        Timer timer = new Timer();
        //时间数
        long timeCount = 0;


        public Form1()
        {
            InitializeComponent();

            //加载窗体时，不激发计时器事件
            timer.Enabled = false;
            timer.Interval = 1000;
        }

        /// <summary>
        /// 开始下载
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //下载
            //计时器开始
            timer.Enabled = true;            
            timer.Tick += new EventHandler(timer_Tick);

            //使用using自动释放资源
            using (WebClient wc = new WebClient())
            {
                //使用WebClient下载数据
                //判断下载地址是否合法
                if (string.IsNullOrEmpty(txtLink.Text.Trim()))
                {
                    MessageBox.Show("请输入下载地址", "提示");
                }
                else if (string.IsNullOrEmpty(txtFilename.Text.Trim()))
                {
                    MessageBox.Show("请输入文件存储名", "提示");
                }
                else
                { //开始下载
                    try
                    {
                        //Uri：统一资源标示符
                        Uri address = new Uri(txtLink.Text.Trim());
                        //1.调用DownFile下载文件到本地
                        //注意：使用此方法会使窗体界面卡住，不推荐使用
                        ///wc.DownloadFile(address, txtFilename.Text.Trim());

                        //2.推荐使用DownloadFileAsync异步下载文件
                        wc.DownloadFileAsync(address, txtFilename.Text.Trim());

                        //如果不出错的话，文件已经下载到本地了。

                        //进度条显示
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);

                        //下载完毕提示
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);

                    }
                    catch (Exception ex)
                    { 
                        //抛出异常
                        MessageBox.Show(ex.Message, "出错啦~~");
                    }
                    
                }
            }
        }

        /// <summary>
        /// 计时器的执行委托
        /// </summary>
        void timer_Tick(object sender, EventArgs e)
        {
            timeCount++;
        }

        /// <summary>
        /// 定义进度条响应事件
        /// </summary>
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// 提示下载完成，并显示下载文件所用时
        /// </summary>
        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("文件下载完毕！共用时：" + timeCount + " 秒", "恭喜~~下载完成~~");
        }

        /// <summary>
        /// 打开文件
        /// </summary>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //打开文件的方法
            System.Diagnostics.Process.Start(txtFilename.Text.Trim());
        }

        /// <summary>
        /// 打开文件目录
        /// </summary>
        private void btnOpenFileDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath);
        }
    }
}
