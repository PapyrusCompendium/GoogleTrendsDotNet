using System;

namespace GoogleTrends.Models.ParameterTypes {
    internal class EnumObjectAttribute : Attribute {
        public object EnumValue { get; }

        public EnumObjectAttribute(object enumValue) {
            EnumValue = enumValue;
        }
    }
}