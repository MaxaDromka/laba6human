using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba5human
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetTeacher();

        }
            private void GetTeacher()
            {
                string URL = "https://www.mivlgu.ru/fakultety/fitr/pin/prepodavatelskiy-sostav";

                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;

                HtmlDocument doc = new HtmlDocument();

                doc.LoadHtml(webClient.DownloadString(URL).Replace("<div class=\"h_query\"></div>", "<div class=\"h_query\">"));

            //var gg = doc.GetElementbyId("content").Elements("div").ToList();

                var elements = doc.GetElementbyId("content").Elements("div").Where(e => e.Attributes["class"].Value.Contains("teacher_inf"));

                List<Teacher> Teachers = new List<Teacher>();
                foreach (var element in elements)
                {
                    Teacher teacher = new Teacher();
                    //HtmlNode info = element.Elements("div").Where(e =>e.Attributes["class"].Value == "teacher_inf teacher_id_154").ToList()[0];

                    string imgUrl = URL;
                    imgUrl += element.Elements("div").Where(e => e.Attributes["class"].Value == "teacher_photo").ToList()[0].Element("a").Element("img").Attributes["src"].Value;

                    teacher.ImageUrl = new Uri(imgUrl);

                    //HtmlNode shortInfo = info.Elements("div").Where(e => e.Attributes["class"].Value =="pers_data").ToList()[0];

                    //teacher.name = shortInfo.Element("").InnerText;

                    //teacher.Url = new Uri(shortInfo.Element("h2").Element("a").Attributes["href"].Value);

                    //teacher._academic_degree = shortInfo.Elements("div").Where(e => e.Attributes["class"].Value =="maincont").ToList()[0].Elements("div").ToList()[1].InnerText;
                    //Teachers.Add(teacher);
                }
                //listbox.ItemsSource = Teachers;
            }
        
    }
}
