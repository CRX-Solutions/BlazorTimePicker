# BlazorTimePicker
Time picker for Blazor.

## Notice
This component is still in development and is not completely finished yet.

## Installation
[NuGet BlazorTimePicker](https://www.nuget.org/packages/BlazorTimePicker)

1. Download and install the BlazorTimePicker package from NuGet

## Usage
1. In **_imports.razor** file add the following using reference `@using BlazorTimePicker`
1. Then in the razor page add the **CRXTimePicker** component `<CRXTimePicker></CRXTimePicker>`

### Parameters

Parameter Name|Data Type|Default|Description
--------------|---------|-----------
Time|TimeSpan|0|The initial time you want the BlazorTimePicker be set to
MinutesSteps|int|5|
StartTime|TimeSpan|0|
ContainerClass|string|"container"|
RowClass|string|"row"|
ColumnClass|string|"col-sm"|
SelectClass|string|"form-control"|
OnTimeChange|EventCallback<TimeSpan>||
