using System.Windows;
using System.Windows.Input;

namespace AllLaunchWPF
{
    public static class MousePosition
    {
        public static Point GetMousePosition(Window window)
        {
            var position = Mouse.GetPosition(window);

            if (window.WindowState == WindowState.Maximized)
                return new Point(position.X, position.Y);

            return new Point(position.X + window.Left, position.Y + window.Top);
        }
    }
}
