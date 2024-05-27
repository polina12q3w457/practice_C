using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace Task
{
    public partial class MainWindow : Window
    {
        private XDocument ShopXml;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(costTextBox.Text) || string.IsNullOrWhiteSpace(dateTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            if (ShopXml == null)
            {
                ShopXml = new XDocument(new XElement("Магазин"));
            }

            ShopXml.Root.Add(new XElement("Продукт",
                new XElement("Название", titleTextBox.Text),
                new XElement("Стоимость", costTextBox.Text),
                new XElement("Срок годности", dateTextBox.Text)));

            productsListBox.Items.Add(titleTextBox.Text);

            titleTextBox.Clear();
            costTextBox.Clear();
            dateTextBox.Clear();
        }

        private void LoadXml_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == true)
            {
                ShopXml = XDocument.Load(openFileDialog.FileName);
                productsListBox.Items.Clear();
                foreach (XElement book in ShopXml.Root.Elements("Продукт"))
                {
                    productsListBox.Items.Add(book.Element("Название").Value);
                }
            }
        }

        private void SaveXml_Click(object sender, RoutedEventArgs e)
        {
            if (ShopXml != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == true)
                {
                    ShopXml.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("Нет данных для сохранения.");
            }
        }

        private void SearchProduct_Click(object sender, RoutedEventArgs e)
        {
            string searchTitle = searchTextBox.Text;
            var book = ShopXml.Root.Elements("Продукт").FirstOrDefault(x => x.Element("Название").Value == searchTitle);
            if (book != null)
            {
                MessageBox.Show($"Продукт найден: {book.Element("Название").Value}, {book.Element("Цена").Value}, {book.Element("Срок годности").Value}");
            }
            else
            {
                MessageBox.Show("Продукт не найден.");
            }
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            string deleteTitle = deleteTextBox.Text;
            var product = ShopXml.Root.Elements("Продукт").FirstOrDefault(x => x.Element("Название").Value == deleteTitle);
            if (product != null)
            {
                product.Remove();
                productsListBox.Items.Remove(deleteTitle);
                MessageBox.Show("Продукт удалён.");
            }
            else
            {
                MessageBox.Show("Продукт не найден.");
            }
        }
    }
}
