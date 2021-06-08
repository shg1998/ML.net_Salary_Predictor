using Hello_mlML.Model;
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

namespace Hello_ml
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = salarytextbox.Text.ToString();
            if(text != null)
            {
                ModelInput sampleData = new ModelInput()
                {
                    YearsExperience = float.Parse(text),
                };

                var predictionResult = ConsumeModel.Predict(sampleData);
                PredictionTextBlock.Text = $"Salary: {sampleData.Salary}"
                    + $"\n\nPredicted YearsExperience value {predictionResult.Prediction}";
                    
            }
        }
    }
}
