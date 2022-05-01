using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABAIDU
{
    public partial class BaiDuSprider : Form
    {
        public BaiDuSprider()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_SelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "请选择保存图片路径";
            FBD.ShowNewFolderButton = true;
            FBD.SelectedPath = Environment.CurrentDirectory;
            if(FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                t_SavePath.Text = FBD.SelectedPath;
        }

        private void t_SavePath_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            //验证关键词和保存路径是否填写
            string error = "";
            if (t_SavePath.Text == "")
            {
                error += "保存路径";
            }
            if (t_KeyWord.Text == "")
            {
                if(error == "保存路径")
                    error += "和关键词";
                else
                    error += "关键词";
            }
            if (t_KeyWord.Text == "" || t_SavePath.Text == "")
            {
                MessageBox.Show("未填写" + error, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //验证保存路径是否创建文件夹
            if (!Directory.Exists(t_SavePath.Text))
            {
                try
                {
                    Directory.CreateDirectory(t_SavePath.Text);
                }
                catch
                {
                    MessageBox.Show("保存路径错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //验证文件夹可写性
            try
            {
                using (FileStream fs = new FileStream(Path.Combine(t_SavePath.Text, "Test_File.tzt"), FileMode.Create));
                File.Delete(Path.Combine(t_SavePath.Text, "Test_File.tzt"));
            }
            catch
            {
                MessageBox.Show("保存路径不可写", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //下载
            string Url = GetUrl();
            Thread thread = new Thread(() => { Downloads(Url,(int)n_page.Value); });
            thread.Start();
        }
        public int tt = 0;
        private void Downloads(string URL, int pages)
        {
            for (int i = 0; i < pages; i++)
            {
                string url = URL.Replace("[REPLACE]", (50 * i).ToString());
                Stream stream = null;
                try
                {
                    stream = Download.DownLoadFile(url);
                }
                catch
                {
                    continue;
                }
                string Html = null;
                try
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        Html = sr.ReadToEnd();
                    }
                }
                catch
                {
                    continue;
                }
                JObject jobj = JObject.Parse(Html);
                JArray jArr = (JArray)jobj["data"];
                for (int j = 0; j < jArr.Count - 1; j++)
                {
                    try
                    {
                        string PicUrl = jArr[j]["thumbURL"].ToString();
                        string savePath = Path.Combine(t_SavePath.Text + @"\" + ReName(PicUrl.Substring(PicUrl.LastIndexOf("/") + 1)) + ".png");
                        string picReferer = "http://image.baidu.com";
                        if (jArr[j].Contains("replaceUrl"))
                        {
                            PicUrl = jArr[j]["replaceUrl"][0]["ObjURL"].ToString();
                            savePath = Path.Combine(t_SavePath.Text + @"\" + ReName(PicUrl.Substring(PicUrl.LastIndexOf("/") + 1)) + ".png");
                            picReferer = jArr[j]["replaceUrl"][0]["FromURL"].ToString();
                        }
                        if (File.Exists(savePath))
                        {
                            t_logs.Text += "文件存在，已跳过" + Environment.NewLine;
                            continue;
                        }
                        if (Download.DownLoadFile(PicUrl, savePath, picReferer))
                        {
                            ++tt;
                            this.Invoke(new Action(() => { t_logs.Text += string.Format("{0}下载成功，下载数量:{1}" + Environment.NewLine, savePath,tt); }));
                        }
                        else
                        {
                            t_logs.Text += string.Format("{0}下载失败" + Environment.NewLine,savePath);
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }
        private string ReName(string fileAddress)
        {
            fileAddress = fileAddress.Replace(":", "_");
            fileAddress = fileAddress.Replace("*", "_");
            fileAddress = fileAddress.Replace("?", "_");
            fileAddress = fileAddress.Replace("\\", "_");
            fileAddress = fileAddress.Replace("/", "_");
            fileAddress = fileAddress.Replace(@"\", "_");
            fileAddress = fileAddress.Replace("<", "_");
            fileAddress = fileAddress.Replace("|", "_");
            fileAddress = fileAddress.Replace(">", "_");
            fileAddress = fileAddress.Replace(" ", "_");
            return fileAddress;
        }
        private void t_KeyWord_TextChanged(object sender, EventArgs e)
        {
        }

        private void t_KeyWord2_TextChanged(object sender, EventArgs e)
        {
            this.t_logs.Select(this.t_logs.TextLength, 1);
            this.t_logs.ScrollToCaret();
        }

        private void c_color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void c_manual_CheckedChanged(object sender, EventArgs e)
        {
            //尺寸类型自动和手动切换
            if (c_manual.Checked)
            {
                c_size.Enabled = false;
                n_neight.Enabled = true;
                n_width.Enabled = true;
            }
            else
            {
                c_size.Enabled = true;
                n_neight.Enabled = false;
                n_width.Enabled = false;
            }
        }

        private void BaiDuSprider_Load(object sender, EventArgs e)
        {
            c_color.SelectedIndex = 0;
            c_type.SelectedIndex = 0;
            c_size.SelectedIndex = 0;
        }
        private string GetUrl()
        {
            string queryWord, word;
            queryWord = word = UrlEnCode(t_KeyWord.Text);
            string z;
            z = new string[] { "", "1", "2", "3", "9" }[c_size.SelectedIndex];
            string ic;
            ic = new string[] { "0", "1", "2", "4", "8", "16", "32", "64", "128", "256", "512", "1024", "2048" }[c_color.SelectedIndex];
            string st, s, face, lm;
            st = "-1";
            s = face = lm = "";
            switch(c_type.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    s = "1";
                    break;
                case 2:
                    face = "1";
                    break;
                case 3:
                    st = "1";
                    break;
                case 4:
                    st = "2";
                    break;
                case 5:
                    lm = "6";
                    break;
                case 6:
                    lm = "7";
                    break;
            }
            string width = "", height = "";
            if(c_manual.Checked)
            {
                width = n_width.Value.ToString();
                height = n_neight.Value.ToString();
            }
            string URL = string.Format("https://image.baidu.com/search/acjson?tn=resultjson_com&logid=11027332180355435261&ipn=rj&ct=201326592&is=&fp=result&fr=&word={0}&queryWord={1}&cl=2&lm={2}&ie=utf-8&oe=utf-8&adpicid=&st={3}&z={4}&ic={5}&hd=&latest=&copyright=&s={6}&se=&tab=&width={7}&height={8}&face={9}&istype=2&qc=&nc=1&expermode=&nojc=&isAsync=&pn=[REPLACE]&rn=50&gsm=1e&1650788101475=", word,queryWord,lm,st,z,ic,s,width,height,face);
            return URL;
        }
        
        /// <summary>
        /// 转换编码
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private string UrlEnCode(string arr)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(arr);
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }
            return (sb.ToString());
        }

        private void n_page_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t_logs.Text = "";
        }
    }
}
