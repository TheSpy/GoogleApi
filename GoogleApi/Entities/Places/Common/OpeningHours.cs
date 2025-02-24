﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

using GoogleApi.Entities.Places.Details.Response;

namespace GoogleApi.Entities.Places.Common;

/// <summary>
/// Opening Hours.
/// </summary>
public class OpeningHours
{
    /// <summary>
    /// OpenNow is a boolean value indicating if the Place is open at the current time.
    /// </summary>
    [JsonPropertyName("open_now")]
    public virtual bool OpenNow { get; set; } = false;

    /// <summary>
    /// periods[] is an array of opening periods covering seven days, starting from Sunday, in chronological order.
    /// </summary>
    public virtual IEnumerable<Period> Periods { get; set; }

    /// <summary>
    /// WeekdayTexts is an array of seven strings representing the formatted opening hours for each day of the week.
    /// If a language parameter was specified in the Place Details request, the Places Service will format and localize the opening hours appropriately for that language.
    /// The ordering of the elements in this array depends on the language parameter. Some languages start the week on Monday while others start on Sunday.
    /// </summary>
    [JsonPropertyName("weekday_text")]
    public virtual IEnumerable<string> WeekdayTexts { get; set; }
}