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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;



namespace WpfLibrary1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        System.Windows.Shapes.Rectangle re = new System.Windows.Shapes.Rectangle();
        Ellipse el = new Ellipse();
        Polygon tre = new Polygon();
        Polygon po = new Polygon();
        public int TpeyroPos = 0;
        public int EllipsePos = 0;
        public int RectanglePos = 0;
        public int PomaPos = 0;
        private int TpeyroCord = 0;
        private int EllipseCord = 0;
        private int RectangleCord = 0;
        private int PomaCord = 0;
        private int win = 0;
        Random rnd = new Random();
        public Page1()
        {
            InitializeComponent();
            RandomGenerate();
           // kukech.ShowGridLines = true;
        }
        public void CleanParameters()
        {
             TpeyroPos = 0;
             EllipsePos = 0;
             RectanglePos = 0;
             PomaPos = 0;
             TpeyroCord = 0;
             EllipseCord = 0;
             RectangleCord = 0;
             PomaCord = 0;
             kukech.Children.Remove(re);
             kukech.Children.Remove(el);
             kukech.Children.Remove(tre);
             kukech.Children.Remove(po);
             win = 0;
        }



        public void RandomGenerate()
        {

            TpeyroPos = rnd.Next(0,4); //2
            if (TpeyroPos == 0)
            {
                TpeyroCord = 132;
            }
            else if (TpeyroPos == 1)
            {
                TpeyroCord = 549;
            }
            else if (TpeyroPos == 2)
            {
                TpeyroCord = 936;
            }
            else if (TpeyroPos == 3)
            {
                TpeyroCord = 1314;
            }
            EllipsePos = rnd.Next(0, 4);//2
            for (int i = 0; i < 6; i++)
            {
                if (EllipsePos == TpeyroPos)
                {
                    EllipsePos = rnd.Next(0, 4);//3
                }
                else
                {
                    if (EllipsePos == 0)
                    {
                        EllipseCord = 132;
                    }
                    else if(EllipsePos == 1)    
                    {
                        EllipseCord = 549;
                    }
                    else if (EllipsePos == 2)
                    {
                        EllipseCord = 936;
                    }
                    else if (EllipsePos == 3)
                    {
                        EllipseCord = 1314;
                    }
                    break;
                }
            }        
            RectanglePos = rnd.Next(0, 4);
            for (int i = 0; i < 6; i++)
            {
                if (RectanglePos == EllipsePos || RectanglePos == TpeyroPos)
                {
                    RectanglePos = rnd.Next(0, 4);//1
                }
                else
                {
                    if (RectanglePos == 0)
                    {
                        RectangleCord = 132;
                    }
                    else if (RectanglePos == 1)
                    {
                        RectangleCord = 549;
                    }
                    else if (RectanglePos == 2)
                    {
                        RectangleCord = 936;
                    }
                    else if (RectanglePos == 3)
                    {
                        RectangleCord = 1314;
                    }
                    break;
                }
            }
            PomaPos = rnd.Next(0, 4);
            for (int i = 0; i < 320; i++) //гнилой 
            {
                if (PomaPos == EllipsePos || PomaPos == TpeyroPos || PomaPos == RectanglePos)
                {
                    PomaPos = rnd.Next(0, 4);
                }
                else
                {
                    if (PomaPos == 0)
                    {
                        PomaCord = 132;
                    }
                    else if (PomaPos == 1)
                    {
                        PomaCord = 549;
                    }
                    else if (PomaPos == 2)
                    {
                        PomaCord = 936;
                    }
                    else if (PomaPos == 3)
                    {
                        PomaCord = 1314;
                    }
                    break;
                }
            }
            PrintEllipse();
            PrintRectangle();
            PrintTpeyro();
            PrintPoma();
        }

        public void PrintEllipse()
        {
            
            el.MouseMove += new MouseEventHandler(FF_MouseMove);
            el.MouseUp += new MouseButtonEventHandler(FF_MouseUp);
            el.MouseDown += new MouseButtonEventHandler(FF_MouseDown);
            el.Width = 190;
            el.Height = 200;
            el.VerticalAlignment = VerticalAlignment.Center;
            el.Fill = Brushes.WhiteSmoke;
            el.Stroke = Brushes.BlueViolet;
            el.StrokeThickness = 3;
            el.Tag = ellipse1;
            Canvas.SetTop(el, 400);
            Canvas.SetLeft(el, EllipseCord);
            kukech.Children.Add(el);
           
                        
        }
        public void PrintRectangle()
        {
            
            re.Tag = rectangle1;
            re.MouseMove += new MouseEventHandler(FF_MouseMove);
            re.MouseUp += new MouseButtonEventHandler(FF_MouseUp);
            re.MouseDown += new MouseButtonEventHandler(FF_MouseDown);
            re.Width = 180;
            re.Height = 200;
            re.VerticalAlignment = VerticalAlignment.Center;
            re.Fill = Brushes.WhiteSmoke;
            re.Stroke = Brushes.BlueViolet;
            re.StrokeThickness = 3;
            re.HorizontalAlignment = HorizontalAlignment.Center;
            Canvas.SetTop(re, 400);
            Canvas.SetLeft(re, RectangleCord);
            kukech.Children.Add(re);
        }


        public void PrintTpeyro()
        {
            
            tre.Tag = polygon1;
            tre.Points = new PointCollection(new[]
            { 
                new System.Windows.Point(50, 300), 
                new System.Windows.Point(125, 98), 
                new System.Windows.Point(200, 300) 
            });
            tre.MouseMove += new MouseEventHandler(FF_MouseMove);
            tre.MouseUp += new MouseButtonEventHandler(FF_MouseUp);
            tre.MouseDown += new MouseButtonEventHandler(FF_MouseDown);
            tre.VerticalAlignment = VerticalAlignment.Center;
            tre.Fill = Brushes.WhiteSmoke;
            tre.Stroke = Brushes.BlueViolet;
            tre.StrokeThickness = 3;
            Canvas.SetTop(tre, 300);
            Canvas.SetLeft(tre, TpeyroCord);
            kukech.Children.Add(tre);

        }
        public void PrintPoma()
        {
           
            po.Tag = polygon2;
            po.Points = new PointCollection(new[]
            {
                new System.Windows.Point(8, 200),
                new System.Windows.Point(100, 98),
                new System.Windows.Point(193, 200),
                new System.Windows.Point(100, 300)
            });
            po.MouseMove += new MouseEventHandler(FF_MouseMove);
            po.MouseUp += new MouseButtonEventHandler(FF_MouseUp);
            po.MouseDown += new MouseButtonEventHandler(FF_MouseDown);
            po.Fill = Brushes.WhiteSmoke;
            po.Stroke = Brushes.BlueViolet;
            po.StrokeThickness = 3;
            Canvas.SetTop(po, 300);
            Canvas.SetLeft(po, PomaCord);
            kukech.Children.Add(po);
        }


        int countZ = 0;
        bool _canMove = false;
        System.Windows.Point _offsetPoint = new(0, 0);
        

        private void FF_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _canMove = true;
            // Передвигаемый элемент будет всегда сверху.
            countZ++;
            // Универсальное приведение для всех тестируемых элементов.
            FrameworkElement ffElement = (FrameworkElement)sender;
            Grid.SetZIndex(ffElement, countZ);

            System.Windows.Point posCursor = e.MouseDevice.GetPosition(this);
            /*_offsetPoint = 
               new Point(posCursor.X - ffElement.Margin.Left, posCursor.Y - ffElement.Margin.Top);*/
            _offsetPoint = new System.Windows.Point(
                    posCursor.X - Canvas.GetLeft(ffElement),
                    posCursor.Y - Canvas.GetTop(ffElement)
            );

            // Чтобы курсор не отрывался от фигуры
            // при резком движении мышью.
            //  Захват устройства мышь. 
            e.MouseDevice.Capture(ffElement);
        }

        private void FF_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (_canMove == true)
            {
                FrameworkElement ffElement = (FrameworkElement)sender;

                if (e.MouseDevice.Captured == ffElement)
                {
                    System.Windows.Point p = e.MouseDevice.GetPosition(this);

                    /*Thickness margin = new(p.X - _offsetPoint.X, p.Y - _offsetPoint.Y, 0, 0);
                    ffElement.Margin = margin;*/
                    Canvas.SetLeft(ffElement, p.X - _offsetPoint.X);
                    Canvas.SetTop(ffElement, p.Y - _offsetPoint.Y);
                   
                }
            }
        }

        private void FF_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            _canMove = false;
            e.MouseDevice.Capture(null);

            FrameworkElement ffElement = (FrameworkElement)sender;
            FrameworkElement target = (FrameworkElement)ffElement.Tag;

            if (Math.Abs(Canvas.GetLeft(ffElement) - Canvas.GetLeft(target)) < 100 &&
                Math.Abs(Canvas.GetTop(ffElement) - Canvas.GetTop(target)) < 100
                )
            {
                Canvas.SetLeft(ffElement, Canvas.GetLeft(target));
                Canvas.SetTop(ffElement, Canvas.GetTop(target));
                win = win + 1; 
                if (win==4)
                {
                    MessageBox.Show("Рома За тобой мама не придет :)");
                    
                    CleanParameters();
                    RandomGenerate();
                   
                }
            }
        }

    }
}
