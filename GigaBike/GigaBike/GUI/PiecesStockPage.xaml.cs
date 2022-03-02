﻿using System;
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

namespace GigaBike
{
    /// <summary>
    /// Logique d'interaction pour PiecesStockPage.xaml
    /// </summary>
    public partial class PiecesStockPage : Page {
        private Action goBackToStockCallback = null;
        private Action goToOrderPiecesCallback = null;

        public PiecesStockPage() {
            InitializeComponent();
        }

        private void DataGridPiecesStock(object sender, SelectionChangedEventArgs e) {

        }

        private void ButtonOrderPiece(object sender, RoutedEventArgs e) {
            if (goToOrderPiecesCallback is not null) goToOrderPiecesCallback();
        }

        private void ButtonGoBackToStock(object sender, RoutedEventArgs e) {
            if (goBackToStockCallback is not null) goBackToStockCallback();
        }

        public Action GoBackToStockCallback {
            set {
                goBackToStockCallback = value;
            }
        }

        public Action GoToOrderPiecesCallback {
            set {
                goToOrderPiecesCallback = value;
            }
        }
    }
}
