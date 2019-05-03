﻿// Copyright 2019 The Noda Time Authors. All rights reserved.
// Use of this source code is governed by the Apache License 2.0,
// as found in the LICENSE.txt file.

using NUnit.Framework;
using System;

namespace NodaTime.Demo
{
    public class OffsetDateDemo
    {
        [Test]
        public void Construction()
        {
            OffsetDate offsetDate = Snippet.For(new OffsetDate(
                new LocalDate(2019, 5, 3),
                Offset.FromHours(3)));

            Assert.AreEqual(Offset.FromHours(3), offsetDate.Offset);
            Assert.AreEqual(new LocalDate(2019, 5, 3), offsetDate.Date);
        }

        [Test]
        public void WithOffset()
        {
            var original = new OffsetDate(
                new LocalDate(2019, 5, 3),
                Offset.FromHours(3));

            OffsetDate updated = Snippet.For(original.WithOffset(Offset.FromHours(-3)));
            Assert.AreEqual(Offset.FromHours(-3), updated.Offset);
            Assert.AreEqual(original.Date, updated.Date);
        }

        [Test]
        public void With()
        {
            var original = new OffsetDate(
                new LocalDate(2019, 5, 3),
                Offset.FromHours(3));

            Func<LocalDate, LocalDate> tomorrowAdjuster = x => x + Period.FromDays(1);
            OffsetDate updated = Snippet.For(original.With(tomorrowAdjuster));
            Assert.AreEqual(original.Offset, updated.Offset);
            Assert.AreEqual(tomorrowAdjuster(original.Date), updated.Date);
        }

        [Test]
        public void WithCalendar()
        {
            var original = new OffsetDate(
                new LocalDate(2019, 5, 3, CalendarSystem.Iso),
                Offset.FromHours(3));

            OffsetDate updated = Snippet.For(original.WithCalendar(CalendarSystem.Gregorian));
            Assert.AreEqual(original.Offset, updated.Offset);
            Assert.AreEqual(CalendarSystem.Gregorian, updated.Calendar);
        }
    }
}
