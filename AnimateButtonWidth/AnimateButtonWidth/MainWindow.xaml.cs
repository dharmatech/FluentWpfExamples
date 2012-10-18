using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FluentWpf;

namespace AnimateButtonWidth
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Title = "Animate Property using a Storyboard";

            Panel panel;

            Button button;

            Content =
                panel = new StackPanel()
                    .AddChildren(
                        button = new Button() { Content = "Button" });

            var storyboard =
                new Storyboard()
                    .AddChildren(
                        new DoubleAnimation()
                        {
                            From = 200,
                            To = 300,
                            Duration = new Duration(TimeSpan.FromMilliseconds(1000))
                        }
                            .SetTargetObject(this, button, Button.WidthProperty));

            panel.AddChildren(
                new Button() { Content = "Start" }
                    .AddClick((s, args) => storyboard.Begin(this)));
        }
    }
}
