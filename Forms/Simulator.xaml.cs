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
using System.Windows.Shapes;

namespace Forms
{
    public partial class Simulator : Window
    {

        //Grid Size
        int ColumnsNumber;
        int RowsNumber;

        //Elements
        Rectangle[,] CellGraphic;

        public Simulator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Read of the grid dimensions
            this.ColumnsNumber = Convert.ToInt32((ColumnsBox.Text));
            this.RowsNumber = Convert.ToInt32((RowsBox.Text));

            //Panel Creation
            CellGraphic = new Rectangle[RowsNumber, ColumnsNumber];
            CanvasGrid.Height = RowsNumber * 15;
            CanvasGrid.Width = ColumnsNumber * 15;

            //Definition & Creation of the Rectangle
            for (int r = 0; r < RowsNumber; r++)
            {
                for (int c = 0; c < ColumnsNumber; c++)
                {
                    //Defintion
                    Rectangle rect = new Rectangle();
                    //Rectangle Parameters
                    rect.Width = 15;rect.Height = 15;
                    rect.Fill = new SolidColorBrush(Colors.White);
                    rect.StrokeThickness = 0.5;
                    rect.Stroke = Brushes.Black;
                    Rectangle rect_1 = rect;
                    CanvasGrid.Children.Add(rect);
                    Canvas.SetTop(rect, (r) * 15);
                    Canvas.SetLeft(rect, (c) * 15);
                    rect.Tag = new Point(r, c);
                }
            }
        }
    }
}
