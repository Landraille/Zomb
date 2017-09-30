using System.Windows.Input;

namespace Zombicide.Command
{
    public class StartGameCommand
    {
            public static readonly RoutedUICommand Start = new RoutedUICommand
                    (
                            "Start",
                            "Start",
                            typeof(StartGameCommand)

                    //new InputGestureCollection()
                    //{
                    //            new KeyGesture(Key.F4, ModifierKeys.Alt)
                    //}
                    );

            //Define more commands here, just like the one above

    }

}