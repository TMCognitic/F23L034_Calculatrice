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

namespace F23L034_Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Value { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Memory Button!!");
            stringBuilder.AppendLine($"Sender Type : {sender.GetType().Name}");
            stringBuilder.AppendLine($"Source Type : {e.Source.GetType().Name}");

            if (e.Source is Button b)
            {
                stringBuilder.AppendLine($"Source Type : {b.Content}");
            }

            MessageBox.Show(stringBuilder.ToString());
            e.Handled = true;
        }

        private void NumericButton_Click(object sender, RoutedEventArgs e)
        {
            if(ScreenTextBlock.Text == "0")
                ScreenTextBlock.Text = ((Button)e.Source).Content.ToString();
            else 
                ScreenTextBlock.Text += ((Button)e.Source).Content.ToString();
            e.Handled = true;
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Operation Button!!");
            stringBuilder.AppendLine($"Sender Type : {sender.GetType().Name}");
            stringBuilder.AppendLine($"Source Type : {e.Source.GetType().Name}");

            if (e.Source is Button b)
            {
                stringBuilder.AppendLine($"Source Type : {b.Content}");
            }

            MessageBox.Show(stringBuilder.ToString());
            e.Handled = true;
        }
    }
}
