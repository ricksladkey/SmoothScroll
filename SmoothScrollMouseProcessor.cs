using Microsoft.VisualStudio.Text.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            _wpfTextView.ViewScroller.ScrollViewportVerticallyByPixels(e.Delta);
            e.Handled = true;
        }
    }
}
