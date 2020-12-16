using System.Windows;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double width = SystemParameters.PrimaryScreenWidth / SystemParameters.CaretWidth;
            double height = SystemParameters.PrimaryScreenHeight / SystemParameters.CaretWidth;
            int WidthConvert = (int)width;
            int HeightConvert = (int)height;
            MessageBox.Show($"{WidthConvert}x{HeightConvert}");
        }
    }
}
