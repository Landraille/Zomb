using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Zombicide.Extensions
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, string color)
        {
            TextRange tr = new TextRange(box.Document.ContentEnd, box.Document.ContentEnd) {Text = text};
            try
            {
                if (string.IsNullOrWhiteSpace(color))
                    color = "BlackBrush";

                var brush = Application.Current.Resources[color] as SolidColorBrush;

                if (brush != null)
                    tr.ApplyPropertyValue(TextElement.ForegroundProperty, brush);
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}