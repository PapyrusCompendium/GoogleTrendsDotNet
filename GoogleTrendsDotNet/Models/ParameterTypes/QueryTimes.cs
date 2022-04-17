namespace GoogleTrends.Models.ParameterTypes {
    public enum QueryTimes {
        [EnumObject("now 1-H")]
        PastHour,

        [EnumObject("now 4-H")]
        PastFourHours,

        [EnumObject("now 1-d")]
        PastDay,

        [EnumObject("today 7-d")]
        PastWeek,

        [EnumObject("today 1-m")]
        PastMonth,

        [EnumObject("today 3-m")]
        PastThreeMonths,

        [EnumObject("today 12-m")]
        PastYear,

        [EnumObject("today 5-y")]
        PastFiveYears,

        [EnumObject("all_2008")]
        AllTime,

        [EnumObject("now 1-d")]
        _
    }
}
