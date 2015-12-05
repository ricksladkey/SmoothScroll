using Microsoft.VisualStudio.Text.Editor;
using System.Windows.Input;

namespace SmoothScroll
{
    internal sealed class SmoothScrollMouseProcessor : MouseProcessorBase
    {
        IWpfTextView _wpfTextView;

        internal SmoothScrollMouseProcessor(IWpfTextView wpfTextView)
        {
            _wpfTextView = wpfTextView;
        }

        public override void PreprocessMouseWheel(MouseWheelEventArgs e)
        {
            if (!Keyboard.IsKeyDown(Key.LeftCtrl) && !Keyboard.IsKeyDown(Key.RightCtrl))
            {
                _wpfTextView.ViewScroller.ScrollViewportVerticallyByPixels(e.Delta);
                e.Handled = true;
            }
        }
    }
}
