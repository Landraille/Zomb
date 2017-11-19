using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Core;
using Core.GlobalVar;
using Services.Zombie.dto;
using Zombicide.Dictionary;
using Zombicide.Extensions;

namespace Zombicide.Behavior
{
    public static class RickTextBoxZombieColorBehavior
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.RegisterAttached("Text",
                typeof(string), typeof(RickTextBoxZombieColorBehavior),
                new PropertyMetadata(string.Empty, OnTextChanged));

        public static string GetText(DependencyObject obj)
        {
           return (string) obj.GetValue(TextProperty);
        }

        public static void SetText(DependencyObject obj, string value)
        {
            obj.SetValue(TextProperty, value);
        }

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            RichTextBox textBox = (RichTextBox) d;
            string Text = (string) (e.NewValue);

            if (!string.IsNullOrWhiteSpace(Text))
            {
                textBox.Loaded += Textbox_WithZombieColor;
            }
            else
            {
                textBox.Loaded -= Textbox_WithZombieColor;
            }
        }

        private static void Textbox_WithZombieColor(object sender, RoutedEventArgs routedEventArgs)
        {
            RichTextBox textBox = (RichTextBox)sender;
            try
            {
                var types = GetText(textBox).Split(',').ToList();

                foreach (var stringType in types)
                {
                    ZombieFamilyEnum type;
                    if (Enum.TryParse(stringType, out type))
                    {
                        var brushName = ZombieDictionary.ZombieColors[type];
                        if (string.IsNullOrWhiteSpace(brushName))
                            brushName = DesignGlobalVar.DEFAULT_BRUSH;

                        textBox.AppendText(stringType, brushName);

                        if (!stringType.Equals(types.Last()))
                            textBox.AppendText(", ", DesignGlobalVar.DEFAULT_BRUSH);
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
