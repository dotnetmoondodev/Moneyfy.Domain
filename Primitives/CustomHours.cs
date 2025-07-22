using System.ComponentModel;

namespace Domain.Primitives;

public enum CustomHours: int
{
    [Description( "12:00 a. m." )]
    AM_12 = 0,

    [Description( "01:00 a. m." )]
    AM_01 = 1,

    [Description( "02:00 a. m." )]
    AM_02 = 2,

    [Description( "03:00 a. m." )]
    AM_03 = 3,

    [Description( "04:00 a. m." )]
    AM_04 = 4,

    [Description( "05:00 a. m." )]
    AM_05 = 5,

    [Description( "06:00 a. m." )]
    AM_06 = 6,

    [Description( "07:00 a. m." )]
    AM_07 = 7,

    [Description( "08:00 a. m." )]
    AM_08 = 8,

    [Description( "09:00 a. m." )]
    AM_09 = 9,

    [Description( "10:00 a. m." )]
    AM_10 = 10,

    [Description( "11:00 a. m." )]
    AM_11 = 11,

    [Description( "12:00 m." )]
    PM_12 = 12,

    [Description( "01:00 p. m." )]
    PM_01 = 13,

    [Description( "02:00 p. m." )]
    PM_02 = 14,

    [Description( "03:00 p. m." )]
    PM_03 = 15,

    [Description( "04:00 p. m." )]
    PM_04 = 16,

    [Description( "05:00 p. m." )]
    PM_05 = 17,

    [Description( "06:00 p. m." )]
    PM_06 = 18,

    [Description( "07:00 p. m." )]
    PM_07 = 19,

    [Description( "08:00 p. m." )]
    PM_08 = 20,

    [Description( "09:00 p. m." )]
    PM_09 = 21,

    [Description( "10:00 p. m." )]
    PM_10 = 22,

    [Description( "11:00 p. m." )]
    PM_11 = 23
}