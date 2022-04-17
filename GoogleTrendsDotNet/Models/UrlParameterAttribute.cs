using System;

namespace GoogleTrends.Models {
    [AttributeUsage(AttributeTargets.Property)]
    internal class UrlParameterAttribute : Attribute {
        public string UrlQueryName { get; }

        public UrlParameterAttribute(string urlQueryName) {
            UrlQueryName = urlQueryName;
        }
    }
}