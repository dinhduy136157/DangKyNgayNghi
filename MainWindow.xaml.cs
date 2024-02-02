using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DangKyNgayNghi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<NgayNghi> ngayNghis = new();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            // Kiểm tra xem tất cả các trường dữ liệu có được nhập hay không
            if (string.IsNullOrWhiteSpace(Id.Text) ||
                TuNgay.SelectedDate == null ||
                TuNgay.SelectedDate == null ||
                string.IsNullOrWhiteSpace(LyDo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            //Kiểm tra đến ngày phải lớn hơn hoặc bằng từ ngày
            if (DenNgay.SelectedDate <= TuNgay.SelectedDate)
            {
                MessageBox.Show("Đến ngày phải lớn hơn Từ ngày.");
                return;
            }
            //Add data
            NgayNghi data = new()
            {
                Id = Id.Text,
                tuNgay = TuNgay.SelectedDate.Value,
                denNgay = DenNgay.SelectedDate.Value,
                lyDo = LyDo.Text,
            };
            ngayNghis.Add(data);
            dgvEmployeeInfo.ItemsSource = null;
            dgvEmployeeInfo.ItemsSource = ngayNghis;
        }
        
        private void btnChiTiet_Click(object sender, RoutedEventArgs e)
        {
            List<NgayNghi> data = ngayNghis.Where(nn => nn.lyDo == "Nghỉ phép").ToList();
            new ChiTiet(data.ToList()).ShowDialog();
        }
    }
}