﻿using System;

    [Flags]
    enum table
    {
    Понедельник = 0b_0000001,
    Вторник = 0b_0000010,
    Среда = 0b_0000100,
    Четверг = 0b_0001000,
    Пятница = 0b_0010000,
    Суббота = 0b_0100000,
    Воскресенье = 0b_1000000,
    }
