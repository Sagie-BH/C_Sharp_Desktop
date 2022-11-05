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
using WpfCalculator.Presentor;

namespace WpfCalculator
{
    /// <summary>
    /// Mvp Wpf Calculator
    /// </summary>
    public partial class Calculator : Window, ICalculator
    {
        public int Zero => int.Parse(btnZero.Content.ToString());

        public int One => int.Parse(btnOne.Content.ToString());

        public int Two => int.Parse(btnTwo.Content.ToString());

        public int Three => int.Parse(btnThree.Content.ToString());

        public int Four => int.Parse(btnFour.Content.ToString());

        public int Five => int.Parse(btnFive.Content.ToString());

        public int Six => int.Parse(btnSix.Content.ToString());

        public int Seven => int.Parse(btnSeven.Content.ToString());

        public int Eight => int.Parse(btnEight.Content.ToString());

        public int Nine => int.Parse(btnNine.Content.ToString());

        public string Result { get => txtResult.Text; set => txtResult.Text = value; }

        public CalcPresentor Presentor { private get; set ; }

        public string Plus => btnPlus.Content.ToString();

        public string Subtract => btnSubtract.Content.ToString();

        public string Multiply => btnMultiply.Content.ToString();

        public string Divided => btnDivide.Content.ToString();

        public Calculator()
        {
            InitializeComponent();
            Presentor = new CalcPresentor(this);
        }


        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddOne();
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddTwo();
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddThree();
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddFour();
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddFive();
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddSix();
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddSeven();
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddEight();
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddNine();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddPlus();
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddSubtract();
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddMultiply();
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddDivide();
        }

        private void btnOff_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            Presentor.CalcResult();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            Presentor.DeleteAll();
        }

        private void btnR_Click(object sender, RoutedEventArgs e)
        {
            Presentor.R();
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            Presentor.AddZero();
        }

        private void btnR_Click_1(object sender, RoutedEventArgs e)
        {
            Presentor.R();
        }
    }
}
