# BlazorTimePicker
Time picker for Blazor.

## Notice
This component is still in development and is not completely finished yet.

## Installation
1. [Download](https://www.nuget.org/packages/BlazorTimePicker) and install the **BlazorTimePicker** package from NuGet

## Usage
1. In **_imports.razor** file add the following using reference `@using BlazorTimePicker`
1. Then in the razor page add the **CRXTimePicker** component `<CRXTimePicker></CRXTimePicker>`

### Parameters

Parameter Name|Default Value|Description
--------------|-------------|-----------
Time [TimeSpan]|0|Initial time you want the BlazorTimePicker to be set to<br/>Default value: 0
MinutesSteps [int]|5|Minute interval
StartTime [TimeSpan]|0|From which time you want the BlazorTimePicker to start from *e.g. when you have 'Time From' and 'Time To' and you want the 'Time To' to start from the selected 'Time From'*
ContainerClass [string]|"container"|
RowClass [string]|"row"|
ColumnClass [string]|"col-sm"|
SelectClass [string]|"form-control"|
OnTimeChange [`EventCallback<TimeSpan>`]|N/A|

### Examples
`<CRXTimePicker Time="@(new TimeSpan(8,30,0))"></CRXTimePicker>`
