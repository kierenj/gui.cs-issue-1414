using System;
using Terminal.Gui;

namespace guirepro
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();

            var top = Application.Top;

            var win = new Window("One")
            {
                X = 0,
                Y = 1,
                Width = Dim.Fill(),
                Height = Dim.Fill() - 1
            };
            top.Add(win);

            var status = new StatusBar(new[]
            {
                new StatusItem(Key.Null, "Test", () => {
                    var win2 = new Window("Hello")
                    {
                        X = 0,
                        Y = 0,
                        Width = Dim.Fill(),
                        Height = Dim.Fill()
                    };
                    top.Add(win2);
                })
            });
            top.Add(status);

            top.KeyPress += e =>
            {
                if (e.KeyEvent.Key == Key.Esc)
                {
                    Application.RequestStop();
                }
            };

            Application.Run();
        }
    }
}
