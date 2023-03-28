using ARMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace ARMLibrary.Pages.PagesUser.Admin
{
    /// <summary>
    /// Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {
        Core db = new Core();

        List<Book> productTypes;

        public BookPage()
        {
            InitializeComponent();
            productTypes = new List<Book>
            {
                new Book()
                {
                    idBook = 0,
                    NameBook = "Все типы"
                }
            };
            productTypes.AddRange(db.context.Book.ToList());
            UpdateUI();
        }
        private void UpdateUI()
        {
            List<Book> displayProduct = GetRows();
            foreach (var item in displayProduct)
            {
                Console.WriteLine(item.idBook);
            }
            ProductListView.ItemsSource = displayProduct;
        }
        private List<Book> GetRows()
        {
            List<Book> arrayProduct = db.context.Book.ToList();
            string searchData = FindTextBox.Text.ToUpper();
            if (!String.IsNullOrEmpty(FindTextBox.Text))
            {
                arrayProduct = arrayProduct.Where(x => x.NameBook.ToUpper().Contains(searchData)).ToList();
                arrayProduct = arrayProduct.Where(x => LevenshteinDistance(x.NameBook.ToUpper(), searchData) <= 12).ToList();
            }
            
            return arrayProduct;
        }

        public static int LevenshteinDistance(string source1, string source2)
        {

            /// <summary>
            ///     Calculate the difference between 2 strings using the Levenshtein distance algorithm
            /// </summary>
            /// <param name="source1">First string</param>
            /// <param name="source2">Second string</param>
            /// <returns></returns>

            var source1Length = source1.Length;
            var source2Length = source2.Length;

            var matrix = new int[source1Length + 1, source2Length + 1];

            // First calculation, if one entry is empty return full length
            if (source1Length == 0)
                return source2Length;

            if (source2Length == 0)
                return source1Length;

            // Initialization of matrix with row size source1Length and columns size source2Length
            for (var i = 0; i <= source1Length; matrix[i, 0] = i++) { }
            for (var j = 0; j <= source2Length; matrix[0, j] = j++) { }

            // Calculate rows and collumns distances
            for (var i = 1; i <= source1Length; i++)
            {
                for (var j = 1; j <= source2Length; j++)
                {
                    var cost = (source2[j - 1] == source1[i - 1]) ? 0 : 1;

                    matrix[i, j] = Math.Min(
                        Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1),
                        matrix[i - 1, j - 1] + cost);
                }
            }
            // return result
            return matrix[source1Length, source2Length];


        }

        private void FindTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //FindTextBox.Focus();
            }
        }
    }
}

