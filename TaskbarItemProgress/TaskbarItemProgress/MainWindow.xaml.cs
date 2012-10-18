using System.Windows;
using System.Windows.Controls;
using System.Windows.Shell;
using FluentWpf;

namespace TaskbarItemProgress
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TaskbarItemInfo = new TaskbarItemInfo();

            TaskbarItemInfo.ProgressValue = 0.5;

            Content = new StackPanel()
                .AddChildren(
                    new Button() { Content = "Normal" } 
                        .AddClick((s, e) => TaskbarItemInfo.ProgressState = TaskbarItemProgressState.Normal),
                    new Button() { Content = "Paused" } 
                        .AddClick((s, e) => TaskbarItemInfo.ProgressState = TaskbarItemProgressState.Paused),
                    new Button() { Content = "Error" } 
                        .AddClick((s, e) => TaskbarItemInfo.ProgressState = TaskbarItemProgressState.Error),
                    new Button() { Content = "Indeterminate" } 
                        .AddClick((s, e) => TaskbarItemInfo.ProgressState = TaskbarItemProgressState.Indeterminate),
                    new Button() { Content = "None" } 
                        .AddClick((s, e) => TaskbarItemInfo.ProgressState = TaskbarItemProgressState.None),
                    new Button() { Content = "Increase" } .AddClick((s, e) => TaskbarItemInfo.ProgressValue += 0.10),
                    new Button() { Content = "Decrease" } .AddClick((s, e) => TaskbarItemInfo.ProgressValue -= 0.10));
        }
    }
}
