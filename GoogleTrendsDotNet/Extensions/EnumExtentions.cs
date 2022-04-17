using System;
using System.Collections.Generic;
using System.Linq;

using GoogleTrends.Models.ParameterTypes;

namespace GoogleTrends.Extensions {
    public static class EnumExtentions {
        private static readonly Dictionary<Enum, object> _enumValuesMemo = new();

        public static TType GetObject<TType>(this Enum enumSelection) {
            if (_enumValuesMemo.TryGetValue(enumSelection, out var objectAttributes)) {
                return (TType)objectAttributes;
            }

            var enumType = enumSelection.GetType().GetField(enumSelection.ToString());
            objectAttributes = (enumType.GetCustomAttributes(typeof(EnumObjectAttribute), false)
                .SingleOrDefault() as EnumObjectAttribute)?.EnumValue;

            _enumValuesMemo.Add(enumSelection, objectAttributes);
            return (TType)objectAttributes;
        }
    }
}
