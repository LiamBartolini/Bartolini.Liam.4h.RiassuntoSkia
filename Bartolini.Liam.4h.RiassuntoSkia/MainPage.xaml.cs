using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;
using System.IO;
using Xamarin.Essentials;

namespace Bartolini.Liam._4h.RiassuntoSkia
{
    public partial class MainPage : ContentPage
    {
        public int margineSinistro { get; set; } = 100;
        public int margineSuperiore { get; set; } = 100;
        public int larghezzaRettangolo { get; set; } = 200;
        public int altezzaRettangolo { get; set; } = 300;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Tela(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            var info = e.Info;
            var canvas = e.Surface.Canvas;
            canvas.Clear();

            int larghezza = info.Rect.Width;
            int altezza = info.Rect.Height;

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.BlueViolet,
                StrokeWidth = 3
            };

            SKPath rettangolo = AreaDelRettangolo();

            canvas.DrawPath(rettangolo, paint);

            TelaDaDisegno.InvalidateSurface();
        }

        SKPath AreaDelRettangolo()
        {
            SKPath rettangolo = new SKPath();

            rettangolo.MoveTo(margineSinistro, margineSuperiore);
            rettangolo.LineTo(margineSinistro + larghezzaRettangolo, margineSuperiore);
            rettangolo.LineTo(margineSinistro + larghezzaRettangolo, margineSuperiore + altezzaRettangolo);
            rettangolo.LineTo(margineSinistro, margineSuperiore + altezzaRettangolo);
            rettangolo.LineTo(margineSinistro, margineSuperiore);

            return rettangolo;
        }

        private void btnDisegna_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}