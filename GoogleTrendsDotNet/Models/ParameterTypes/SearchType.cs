namespace GoogleTrends.Models.ParameterTypes {
    public enum SearchType {
        [EnumObject("youtube")]
        Youtube,

        [EnumObject("images")]
        Images,

        [EnumObject("news")]
        News,

        [EnumObject("froogle")]
        Shopping,

        [EnumObject("")]
        WebSearch,

        [EnumObject("")]
        _
    }
}