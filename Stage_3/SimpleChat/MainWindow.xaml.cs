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

namespace SimpleChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void AnnaMsg(object sender, EventArgs e)
        {
            MessageBox.Show($"Anna texted: {Anna.Text}");
        }

        public void ChloeMsg(object sender, EventArgs e)
        {
            MessageBox.Show($"Chloe texted: {Chloe.Text}");
        }

        public void Chat(object sender, EventArgs e)
        {
            MessageBox.Show("Conversation started!");
        }

    }
}
