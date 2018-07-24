using System;
using System.Drawing;
using System.Collections.Generic;

public struct Pixel
{
    #region variable

    private byte _a, _r, _g, _b;

    public byte A
    {
        get { return _a; }
        set { _a = value; }
    }

    public byte R
    {
        get { return _r; }
        set { _r = value; }
    }

    public byte G
    {
        get { return _g; }
        set { _g = value; }
    }

    public byte B
    {
        get { return _b; }
        set { _b = value; }
    }

    public static Pixel Empty
    {
        get { return new Pixel(0, 0, 0, 0); }
    }

    #endregion variable

    #region constructor

    public Pixel(byte a, byte r, byte g, byte b)
    {
        _a = a;
        _r = r;
        _g = g;
        _b = b;
    }

    public Pixel(Color clr)
    {
        _a = clr.A;
        _r = clr.R;
        _g = clr.G;
        _b = clr.B;
    }

    #endregion constructor

    #region method

    public static Pixel[] PixelArray(Bitmap image)
    {
        Pixel[] hsl = new Pixel[image.Width * image.Height];
        for (int h = 0; h < image.Height; h++)
        {
            for (int w = 0; w < image.Width; w++)
            {
                hsl[(h * image.Width) + w] = (Pixel)image.GetPixel(w, h);
            }
        }
        return hsl;
    }

    public static List<Pixel> PixelList(Bitmap image)
    {
        List<Pixel> hsl = new List<Pixel>();
        for (int h = 0; h < image.Height; h++)
        {
            for (int w = 0; w < image.Width; w++)
            {
                hsl.Add((Pixel)image.GetPixel(w, h));
            }
        }
        return hsl;
    }

    public static Bitmap CreateBitmap(Pixel[] pix, Size bitmapSize)
    {
        Bitmap hsl = new Bitmap(bitmapSize.Width, bitmapSize.Height);
        for (int h = 0; h < hsl.Height; h++)
        {
            for (int w = 0; w < hsl.Width; w++)
            {
                hsl.SetPixel(w, h, (Color)pix[(h * hsl.Width) + w]);
            }
        }
        return hsl;
    }

    public static Bitmap CreateBitmap(List<Pixel> pix, Size bitmapSize)
    {
        Bitmap hsl = new Bitmap(bitmapSize.Width, bitmapSize.Height);
        for (int h = 0; h < hsl.Height; h++)
        {
            for (int w = 0; w < hsl.Width; w++)
            {
                hsl.SetPixel(w, h, (Color)pix[(h * hsl.Width) + w]);
            }
        }
        return hsl;
    }

    public static Bitmap ScaledBitmap(Bitmap image, Size newSize)
    {
        var rW = (double)newSize.Width / image.Width;
        var rH = (double)newSize.Height / image.Height;
        var r = Math.Min(rW, rH);
        var nW = (int)(image.Width * r);
        var nH = (int)(image.Height * r);
        Bitmap hsl = new Bitmap(nW, nH);
        using (var g = Graphics.FromImage(hsl))
        {
            g.DrawImage(image, 0, 0, nW, nH);
        }
        return hsl;
    }

    public static explicit operator Pixel(Color clr)
    {
        return new Pixel(clr.A, clr.R, clr.G, clr.B);
    }

    public static explicit operator Color(Pixel pixel)
    {
        return Color.FromArgb(pixel.A, pixel.R, pixel.G, pixel.B);
    }

    #endregion method
}