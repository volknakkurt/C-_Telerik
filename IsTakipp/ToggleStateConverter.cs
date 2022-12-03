using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Automation;

namespace IsTakipp
{
    public class ToggleStateConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(ToggleState) || destinationType == typeof(bool);
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is char && destinationType == typeof(ToggleState))
            {
                char charValue = (char)value;
                switch (charValue)
                {
                    case 'Y':
                        return ToggleState.On;
                    case 'N':
                        return ToggleState.Off;
                    default:
                        return ToggleState.Indeterminate;
                }
            }
            else if (value is bool && destinationType == typeof(char))
            {
                bool boolValue = (bool)value;
                switch (boolValue)
                {
                    case true:
                        return 'Y';
                    case false:
                        return 'N';
                    default:
                        return 'M';
                }
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(ToggleState) || sourceType == typeof(bool);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            ToggleState state;
            bool boolValue;
            if (value is ToggleState)
            {
                state = (ToggleState)value;
                switch (state)
                {
                    case ToggleState.On:
                        return 'Y';
                    case ToggleState.Off:
                        return 'N';
                    default:
                        return 'M';
                }
            }
            else if (value is bool)
            {
                boolValue = (bool)value;
                switch (boolValue)
                {
                    case true:
                        return 'Y';
                    case false:
                        return 'N';
                    default:
                        return 'M';
                }
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
