using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace BlazorTimePicker
{
    public partial class CRXTimePicker
    {
        [Parameter]
        public TimeSpan Time { get; set; } = TimeSpan.Zero;

        [Parameter]
        public int MinutesSteps { get; set; } = 5;

        [Parameter]
        public TimeSpan StartTime { get; set; } = TimeSpan.Zero;


        [Parameter]
        public string ContainerClass { get; set; } = "container";

        [Parameter]
        public string RowClass { get; set; } = "row"; // two fields

        [Parameter]
        public string ColumnClass { get; set; } = "col-sm"; // column

        [Parameter]
        public string SelectClass { get; set; } = "form-control"; // ui fluid dropdown


        [Parameter]
        public EventCallback<TimeSpan> OnTimeChange { get; set; }

        protected void OnChange(ChangeEventArgs e, bool hours)
        {
            Time = (hours)
                ? TimeSpan.Parse($"{e.Value}:{Time.Minutes}")
                : TimeSpan.Parse($"{((StartTime != TimeSpan.Zero && Time.Hours < StartTime.Hours) ? StartTime.Hours : Time.Hours)}:{e.Value}");

            OnTimeChange.InvokeAsync(Time);
        }
    }
}
