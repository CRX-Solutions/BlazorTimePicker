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

Parameter Name|Data Type|Default Value|Description
--------------|---------|-------------|-----------
Time|TimeSpan|0|Initial time you want the BlazorTimePicker to be set to
MinutesSteps|int|5|Minute interval
StartTime|TimeSpan|0|From which time you want the BlazorTimePicker to start from *e.g. when you have Time From and Time To*
ContainerClass|string|"container"|
RowClass|string|"row"|
ColumnClass|string|"col-sm"|
SelectClass|string|"form-control"|
OnTimeChange|`EventCallback<TimeSpan>`|N/A|
