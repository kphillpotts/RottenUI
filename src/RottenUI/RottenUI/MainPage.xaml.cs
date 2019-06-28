using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RottenUI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            // super-lame binding to get data for the screen
            this.BindingContext = Data.MockRepository.Movies[0];
            InitializeComponent();
        }

        private void SKCanvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            using (SKPaint paint = new SKPaint())
            {
                // define the color for the shadow
                SKColor shadowColor = Color.FromHex("#5ACB6E").ToSKColor();

                paint.IsDither = true;
                paint.IsAntialias = true;
                paint.Color = shadowColor;

                // create filter for drop shadow
                paint.ImageFilter = SKImageFilter.CreateDropShadow(
                    dx: 0, dy: 0, 
                    sigmaX: 40, sigmaY: 40, 
                    color: shadowColor, 
                    shadowMode: SKDropShadowImageFilterShadowMode.DrawShadowOnly);

                // define where I want to draw the object
                var margin = info.Width / 10;
                var shadowBounds = new SKRect(margin, -40, info.Width - margin, 10);
                canvas.DrawRoundRect(shadowBounds, 10, 10, paint);

            }

        }
    }
}
