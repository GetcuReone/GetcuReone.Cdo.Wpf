using GetcuReone.Cdi.MvvmFrameWpf;
using System.Windows;

namespace GetcuReone.Cdo.Wpf.Models
{
    /// <summary>
    /// Model for text.
    /// </summary>
    public sealed class TextModel : GrModelBase
    {
        /// <summary>
        /// Visibility text.
        /// </summary>
        public Visibility Visibility { get => _visibility; set => SetPropertyValue(ref _visibility, value); }
        private Visibility _visibility;

        /// <summary>
        /// Text.
        /// </summary>
        public string Text { get => _text; set => SetPropertyValue(ref _text, value); }
        private string _text;
    }
}
