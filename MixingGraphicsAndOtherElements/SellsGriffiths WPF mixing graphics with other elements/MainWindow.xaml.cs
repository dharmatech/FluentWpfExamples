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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FluentWpf;

namespace SellsGriffiths_WPF_mixing_graphics_with_other_elements
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextBlock textBlock;

            Content = new DockPanel()
                .AddChildren(
                    new StackPanel() { Orientation = Orientation.Horizontal }
                        .SetDock(Dock.Top)
                        .AddChildren(
                            new TextBlock() { Text = "Mix text, " },
                            new Ellipse() { Fill = Brushes.Blue, Width = 40 },
                            new TextBlock() { Text = " and " },
                            new Button() { Content = "Controls" }),
                    new Ellipse() { Fill = Brushes.Green, Width = 100 }.SetDock(Dock.Left),
                    new Button() { Content = "abc" }.SetDock(Dock.Left),
                    textBlock = new TextBlock() { FontSize = 24, TextWrapping = TextWrapping.Wrap }
                        .AddInline("And of course you can put graphics into your text: ")
                        .AddInline(new Ellipse() { Fill = Brushes.Cyan, Width = 50, Height = 20 }));
        }
    }
}
