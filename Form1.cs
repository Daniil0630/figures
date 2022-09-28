namespace figures
{
    public partial class Form1 : Form
    {
        int CountRectangle = 3;
        int CountCircle = 3;
        Graphics g;
        SolidBrush solidBrush;
        Rectangle rectangle1 = new Rectangle();
        Rectangle rectangle2 = new Rectangle();
        Rectangle rectangle3 = new Rectangle();
        Circle circle1 = new Circle();
        Circle circle2 = new Circle();
        Circle circle3 = new Circle();
        Pen penRectangle1 = new Pen(Color.White, 1);
        Pen penRectangle2 = new Pen(Color.White, 1);
        Pen penRectangle3 = new Pen(Color.White, 1);
        Pen penCircle1 = new Pen(Color.White, 1);
        Pen penCircle2 = new Pen(Color.White, 1);
        Pen penCircle3 = new Pen(Color.White, 1);
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            rectangle1.PaintRectangle();
            rectangle1.ChangeColor();
            solidBrush = new SolidBrush(Color.FromArgb(rectangle1.RandColor[0], rectangle1.RandColor[1], rectangle1.RandColor[2]));
            g.FillRectangle(solidBrush, rectangle1.CenterCoordinates[0] - rectangle1.WidthRectangle / 2, rectangle1.CenterCoordinates[1] - rectangle1.HeightRectangle / 2, rectangle1.WidthRectangle, rectangle1.WidthRectangle);
            g.DrawRectangle(penRectangle1, rectangle1.CenterCoordinates[0] - rectangle1.WidthRectangle / 2, rectangle1.CenterCoordinates[1] - rectangle1.HeightRectangle / 2, rectangle1.WidthRectangle, rectangle1.WidthRectangle);


            rectangle2.PaintRectangle();
            rectangle2.ChangeColor();
            solidBrush = new SolidBrush(Color.FromArgb(rectangle2.RandColor[0], rectangle2.RandColor[1], rectangle2.RandColor[2]));
            g.FillRectangle(solidBrush, rectangle2.CenterCoordinates[0] - rectangle2.WidthRectangle / 2, rectangle2.CenterCoordinates[1] - rectangle2.HeightRectangle / 2, rectangle2.WidthRectangle, rectangle2.WidthRectangle);
            g.DrawRectangle(penRectangle2, rectangle2.CenterCoordinates[0] - rectangle2.WidthRectangle / 2, rectangle2.CenterCoordinates[1] - rectangle2.HeightRectangle / 2, rectangle2.WidthRectangle, rectangle2.WidthRectangle);

            rectangle3.PaintRectangle();
            rectangle3.ChangeColor();
            solidBrush = new SolidBrush(Color.FromArgb(rectangle3.RandColor[0], rectangle3.RandColor[1], rectangle3.RandColor[2]));
            g.FillRectangle(solidBrush, rectangle3.CenterCoordinates[0] - rectangle3.WidthRectangle / 2, rectangle3.CenterCoordinates[1] - rectangle3.HeightRectangle / 2, rectangle3.WidthRectangle, rectangle3.WidthRectangle);
            g.DrawRectangle(penRectangle3, rectangle3.CenterCoordinates[0] - rectangle3.WidthRectangle / 2, rectangle3.CenterCoordinates[1] - rectangle3.HeightRectangle / 2, rectangle3.WidthRectangle, rectangle3.WidthRectangle);


            circle1.PaintCircle();
            circle1.ChangeColor();
            solidBrush = new SolidBrush(Color.FromArgb(circle1.RandColor[0], circle1.RandColor[1], circle1.RandColor[2]));
            g.FillEllipse(solidBrush, circle1.CenterCoordinates[0] - circle1.RadiusCircle, circle1.CenterCoordinates[1] - circle1.RadiusCircle, circle1.RadiusCircle * 2, circle1.RadiusCircle * 2);
            g.DrawEllipse(penCircle1, circle1.CenterCoordinates[0] - circle1.RadiusCircle, circle1.CenterCoordinates[1] - circle1.RadiusCircle, circle1.RadiusCircle * 2, circle1.RadiusCircle * 2);


            circle2.PaintCircle();
            circle2.ChangeColor();
            solidBrush = new SolidBrush(Color.FromArgb(circle2.RandColor[0], circle2.RandColor[1], circle2.RandColor[2]));
            g.FillEllipse(solidBrush, circle2.CenterCoordinates[0] - circle2.RadiusCircle, circle2.CenterCoordinates[1] - circle2.RadiusCircle, circle2.RadiusCircle * 2, circle2.RadiusCircle * 2);
            g.DrawEllipse(penCircle2, circle2.CenterCoordinates[0] - circle2.RadiusCircle, circle2.CenterCoordinates[1] - circle2.RadiusCircle, circle2.RadiusCircle * 2, circle2.RadiusCircle * 2);


            circle3.PaintCircle();
            circle3.ChangeColor();
            solidBrush = new SolidBrush(Color.FromArgb(circle3.RandColor[0], circle3.RandColor[1], circle3.RandColor[2]));
            g.FillEllipse(solidBrush, circle3.CenterCoordinates[0] - circle3.RadiusCircle, circle3.CenterCoordinates[1] - circle3.RadiusCircle, circle3.RadiusCircle * 2, circle3.RadiusCircle * 2);
            g.DrawEllipse(penCircle3, circle3.CenterCoordinates[0] - circle3.RadiusCircle, circle3.CenterCoordinates[1] - circle3.RadiusCircle, circle3.RadiusCircle * 2, circle3.RadiusCircle * 2);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;
            if (rectangle1.TestOwnRectangle(X, Y) == true)
            {
                rectangle1.ChangeColor();
                solidBrush = new SolidBrush(Color.FromArgb(rectangle1.RandColor[0], rectangle1.RandColor[1], rectangle1.RandColor[2]));
                g.FillRectangle(solidBrush, rectangle1.CenterCoordinates[0] - rectangle1.WidthRectangle / 2, rectangle1.CenterCoordinates[1] - rectangle1.HeightRectangle / 2, rectangle1.WidthRectangle, rectangle1.WidthRectangle);
                penRectangle1.Width += 10;
                g.DrawRectangle(penRectangle1, rectangle1.CenterCoordinates[0] - rectangle1.WidthRectangle / 2, rectangle1.CenterCoordinates[1] - rectangle1.HeightRectangle / 2, rectangle1.WidthRectangle, rectangle1.WidthRectangle);
                label4.Text = "Прямоугольник";
                label5.Text = rectangle1.SquareRectangle().ToString();

            }
            if (rectangle2.TestOwnRectangle(X, Y) == true)
            {
                rectangle2.ChangeColor();
                solidBrush = new SolidBrush(Color.FromArgb(rectangle2.RandColor[0], rectangle2.RandColor[1], rectangle2.RandColor[2]));
                g.FillRectangle(solidBrush, rectangle2.CenterCoordinates[0] - rectangle2.WidthRectangle / 2, rectangle2.CenterCoordinates[1] - rectangle2.HeightRectangle / 2, rectangle2.WidthRectangle, rectangle2.WidthRectangle);
                penRectangle2.Width += 10;
                g.DrawRectangle(penRectangle2, rectangle2.CenterCoordinates[0] - rectangle2.WidthRectangle / 2, rectangle2.CenterCoordinates[1] - rectangle2.HeightRectangle / 2, rectangle2.WidthRectangle, rectangle2.WidthRectangle);
                label4.Text = "Прямоугольник";
                label5.Text = rectangle2.SquareRectangle().ToString();
            }
            if (rectangle3.TestOwnRectangle(X, Y) == true)
            {
                rectangle3.ChangeColor();
                solidBrush = new SolidBrush(Color.FromArgb(rectangle3.RandColor[0], rectangle3.RandColor[1], rectangle3.RandColor[2]));
                g.FillRectangle(solidBrush, rectangle3.CenterCoordinates[0] - rectangle3.WidthRectangle / 2, rectangle3.CenterCoordinates[1] - rectangle3.HeightRectangle / 2, rectangle3.WidthRectangle, rectangle3.WidthRectangle);
                penRectangle3.Width += 10;
                g.DrawRectangle(penRectangle3, rectangle3.CenterCoordinates[0] - rectangle3.WidthRectangle / 2, rectangle3.CenterCoordinates[1] - rectangle3.HeightRectangle / 2, rectangle3.WidthRectangle, rectangle3.WidthRectangle);
                label4.Text = "Прямоугольник";
                label5.Text = rectangle3.SquareRectangle().ToString();
            }




            if (circle1.TestOwnCircle(X, Y) == true)
            {
                circle1.ChangeColor();
                solidBrush = new SolidBrush(Color.FromArgb(circle1.RandColor[0], circle1.RandColor[1], circle1.RandColor[2]));
                g.FillEllipse(solidBrush, circle1.CenterCoordinates[0] - circle1.RadiusCircle, circle1.CenterCoordinates[1] - circle1.RadiusCircle, circle1.RadiusCircle * 2, circle1.RadiusCircle * 2);
                penCircle1.Width += 10;
                g.DrawEllipse(penCircle1, circle1.CenterCoordinates[0] - circle1.RadiusCircle, circle1.CenterCoordinates[1] - circle1.RadiusCircle, circle1.RadiusCircle * 2, circle1.RadiusCircle * 2);
                label4.Text = "Круг";
                label5.Text = circle1.SquareCircle().ToString();
            }

            if (circle2.TestOwnCircle(X, Y) == true)
            {
                circle2.ChangeColor();
                solidBrush = new SolidBrush(Color.FromArgb(circle2.RandColor[0], circle2.RandColor[1], circle2.RandColor[2]));
                g.FillEllipse(solidBrush, circle2.CenterCoordinates[0] - circle2.RadiusCircle, circle2.CenterCoordinates[1] - circle2.RadiusCircle, circle2.RadiusCircle * 2, circle2.RadiusCircle * 2);
                penCircle2.Width += 10;
                g.DrawEllipse(penCircle2, circle2.CenterCoordinates[0] - circle2.RadiusCircle, circle2.CenterCoordinates[1] - circle2.RadiusCircle, circle2.RadiusCircle * 2, circle2.RadiusCircle * 2);
                label4.Text = "Круг";
                label5.Text = circle2.SquareCircle().ToString();
            }

            if (circle3.TestOwnCircle(X, Y) == true)
            {
                circle3.ChangeColor();
                solidBrush = new SolidBrush(Color.FromArgb(circle3.RandColor[0], circle3.RandColor[1], circle3.RandColor[2]));
                g.FillEllipse(solidBrush, circle3.CenterCoordinates[0] - circle3.RadiusCircle, circle3.CenterCoordinates[1] - circle3.RadiusCircle, circle3.RadiusCircle * 2, circle3.RadiusCircle * 2);
                penCircle3.Width += 10;
                g.DrawEllipse(penCircle3, circle3.CenterCoordinates[0] - circle3.RadiusCircle, circle3.CenterCoordinates[1] - circle3.RadiusCircle, circle3.RadiusCircle * 2, circle3.RadiusCircle * 2);
                label4.Text = "Круг";
                label5.Text = circle3.SquareCircle().ToString();
            }
        }

       
    }
}