using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LifxCloud.NET.Models
{
    public class Colors
    {
        public const string White = "white";
        public const string Red = "red";
        public const string Orange = "orange";
        public const string Yellow = "yellow";
        public const string Cyan = "cyan";
        public const string Green = "green";
        public const string Blue = "blue";
        public const string Purple = "purple";
        public const string Pink = "pink";

        public static string BuildCustomColor(string saturation, string brightness, string kelvin, string hue)
        {
            //check hue
            if (!IsBetween(Convert.ToInt32(hue), 0, 360))
            {
                throw new InvalidConstraintException("Value for Hue is invalid, valid range[0-360]");
            }

            //check saturation
            if (!IsBetween(Convert.ToDouble(saturation), 0.0, 1.0))
            {
                throw new InvalidConstraintException("Value for Saturation is invalid, valid range[0.0-1.0]");
            }

            //check brightness
            if (!IsBetween(Convert.ToDouble(brightness), 0.0, 1.0))
            {
                throw new InvalidConstraintException("Value for Brightness is invalid, valid range[0.0-1.0]");
            }

            //check kelvin
            if (!IsBetween(Convert.ToDouble(kelvin), 1500, 9000))
            {
                throw new InvalidConstraintException("Value for Saturation is invalid, valid range[1500-9000]");
            }

            return $"{FormatString("saturation", saturation)} {FormatString("brightness", brightness)} {FormatString("kelvin", kelvin)} {FormatString("hue", hue)}";
        }

        public static string BuildRGB(int red, int green, int blue)
        {
            //check red
            if (!IsBetween(Convert.ToDouble(red), 0, 255))
            {
                throw new InvalidConstraintException("Value for Red is invalid, valid range[0-255]");
            }

            //check green
            if (!IsBetween(Convert.ToDouble(green), 0, 255))
            {
                throw new InvalidConstraintException("Value for Red is invalid, valid range[0-255]");
            }

            //check blue
            if (!IsBetween(Convert.ToDouble(blue), 0, 255))
            {
                throw new InvalidConstraintException("Value for Red is invalid, valid range[0-255]");
            }
            return $"rgb:{red},{green},{blue}";
        }

        private static string FormatString(string element, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return $"{element}:{value}";
            }
            else
            {
                return string.Empty;
            }
        }

        private static bool IsBetween(double item, double min, double max)
        {
            return item >= min && item <= max;
        }
    }
}
