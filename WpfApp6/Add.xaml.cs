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
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        podgotovkaEntities db = new podgotovkaEntities();
        informazia p1 = new informazia();
        public Add()
        {
            InitializeComponent();
        }

        private void dobavit(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (idi.Text.Length == 0) errors.AppendLine("Введите ID");
            if (familia.Text.Length == 0) errors.AppendLine("Введите фамилию");
            if (imya.Text.Length == 0) errors.AppendLine("Введите имя");
            if (otchestvo.Text.Length == 0) errors.AppendLine("Введите отчество");
            if (vosrast.Text.Length == 0) errors.AppendLine("Введите возраст");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            p1.id = Convert.ToInt32(idi.Text);
            p1.familia = familia.Text;
            p1.name = imya.Text;
            p1.otchestvo = otchestvo.Text;
            p1.vosrast = Convert.ToInt32(vosrast.Text);
            try
            {
                db.informazia.Add(p1);
                db.SaveChanges();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
