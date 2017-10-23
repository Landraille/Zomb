using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using Core.GlobalVar;

namespace Zombicide.Extensions
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, string brushName)
        {
            TextRange tr = new TextRange(box.Document.ContentEnd, box.Document.ContentEnd) {Text = text};
            try
            {
                if (string.IsNullOrWhiteSpace(brushName))
                    brushName = DesignGlobalVar.DEFAULT_BRUSH;

                var brush = Application.Current.Resources[brushName] as SolidColorBrush;

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