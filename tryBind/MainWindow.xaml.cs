using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace tryBind
{

    public partial class MainWindow : Window
    {
        public static VM_CList VM_CategoryList = new VM_CList();
        public static VM_sList VM_sl = new VM_sList();
        public MainWindow()
        {
            InitializeComponent();

            this.lv_category.DataContext = VM_CategoryList;
            this.lstFileManager.DataContext = VM_sl;
        }

        private void ListView_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var GetControl = GetAncestorOfType<ListBoxItem>(sender as ListView);
                //var info = GetControl.Content as VM_s;
                var info = GetControl.DataContext as VM_s;
                var yy = info.Name_;
                Console.WriteLine(yy);
            }
            catch (Exception) { }
        }
        public T GetAncestorOfType<T>(FrameworkElement child) where T : FrameworkElement
        {
            var parent = VisualTreeHelper.GetParent(child);
            if (parent != null && !(parent is T))
                return (T)GetAncestorOfType<T>((FrameworkElement)parent);
            return (T)parent;
        }
        private void btn_loadAll_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_userSetting_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btn_setting_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lv_category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            List<string> aaa = new List<string>();
            aaa.Add("asdasdas");
            aaa.Add("asdasdaadsads");

            var displayData = new List<VM_s>();
            displayData.Add(new VM_s { XYXY = "AC",QAQA =aaa,Name_="" });
            displayData.Add(new VM_s { XYXY = "BC" });
            displayData.Add(new VM_s { XYXY = "CC" });

            VM_sl.SList = new ObservableCollection<VM_s>(displayData);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var displayData = new List<VM_Category>();

            displayData.Add(new VM_Category { Name = "A" });
            displayData.Add(new VM_Category { Name = "B" });
            displayData.Add(new VM_Category { Name = "C" });

            VM_CategoryList.CList = new ObservableCollection<VM_Category>(displayData);
        }
    }
}
