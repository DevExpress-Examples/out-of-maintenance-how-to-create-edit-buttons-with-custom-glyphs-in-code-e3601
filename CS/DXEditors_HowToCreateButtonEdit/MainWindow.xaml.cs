using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using DevExpress.Xpf.Editors;

namespace DXEditors_HowToCreateButtonEdit {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            CreateEditButton(btnEdit, @"/DXEditors_HowToCreateButtonEdit;component\plus.png");
        }

        private void CreateEditButton(ButtonEdit edit, string imgUri) {
            BitmapImage bitmap = new BitmapImage(new Uri(imgUri, UriKind.Relative));
            Image imgSource = new Image() { Source = bitmap };
            ButtonInfo btnInfo = new ButtonInfo() { GlyphKind = GlyphKind.User, Content = imgSource };
            edit.Buttons.Add(btnInfo);
        }
    }
}
