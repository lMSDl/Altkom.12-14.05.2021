using ArchitecturalPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ArchitecturalPatterns.Views
{
    public partial class MvcView : Page
    {
        private readonly Model _model;

        public MvcView()
        {
            InitializeComponent();
            _model = new Model();
        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            _model.Value = TextBox_Input.Text;
            Label_Value.Content = _model.Value;
        }

        private void Button_Load(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text = _model.Value;
        }
    }
}
