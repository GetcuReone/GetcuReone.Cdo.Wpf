using GetcuReone.MvvmFrame.Wpf.Models;
using System.Windows.Input;

namespace GetcuReone.Cdo.Wpf.Models
{
    /// <summary>
    /// Model for radio button
    /// </summary>
    public class RadioButtonModel<TCommand> : ButtonModel<TCommand>
        where TCommand : ICommand
    {
        /// <summary>
        /// Is checked
        /// </summary>
        public bool IsChecked { get => _isChecked; set => SetPropertyValue(ref _isChecked, value); }
        private bool _isChecked;

        /// <summary>
        /// Value.
        /// </summary>
        public string Value { get => _value; set => SetPropertyValue(ref _value, value); }
        private string _value;

        /// <summary>
        /// Group name.
        /// </summary>
        public string GroupName { get => _groupName; set => SetPropertyValue(ref _groupName, value); }
        private string _groupName;
    }

    /// <inheritdoc/>
    public class RadioButtonModel : RadioButtonModel<ICommand> { }
}
