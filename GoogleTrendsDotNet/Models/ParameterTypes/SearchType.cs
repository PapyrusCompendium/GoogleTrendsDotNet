namespace GoogleTrends.Models.ParameterTypes {
    public enum SearchType {
        [EnumObject("")]
        WebSearch,

        [EnumObject("youtube")]
        Youtube,

        [EnumObject("images")]
        Images,

        [EnumObject("news")]
        News,

        [EnumObject("froogle")]
        Shopping
    }
}