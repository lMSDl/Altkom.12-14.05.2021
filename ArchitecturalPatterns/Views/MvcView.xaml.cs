using ArchitecturalPatterns.Models;
using ArchitecturalPatterns.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ArchitecturalPatterns.Views
{
    public partial class MvpView : Page, IView
    {
        private readonly IPresenter _presenter;
        public MvpView()
        {
            InitializeComponent();
            _presenter = new Presenter.Presenter(this);
        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            _presenter.Save(TextBox_Input.Text);
        }

        private void Button_Load(object sender, RoutedEventArgs e)
        {
            _presenter.Load();
        }

        public void Load(string value)
        {
            TextBox_Input.Text = value;
        }

        public void Display(string value)
        {
            Label_Value.Content = value;
        }
    }
}
