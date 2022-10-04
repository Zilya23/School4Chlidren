using System;
using System.Collections.Generic;
using System.Linq;
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
using Cora.DataBase;
using Cora;

namespace School4Chlidren.Pages
{
    /// <summary>
    /// Логика взаимодействия для HeadTeacherMainPage.xaml
    /// </summary>
    public partial class HeadTeacherMainPage : Page
    {
        public static List<Teacher> teachersList { get; set; }
        public HeadTeacherMainPage()
        {
            InitializeComponent();
            teachersList = TeacherFunction.GetTeacher();

            this.DataContext = this;
        }

        private void lv_teacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
