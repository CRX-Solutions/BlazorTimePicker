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

Parameter Name|Description
--------------|-----------
**Time**<br/>[TimeSpan]|Initial time you want the BlazorTimePicker to be set to<br/>Default value: 0
**MinutesSteps**<br/>[int]|Minute interval<br/>Default value: 5
**StartTime**<br/>[TimeSpan]|From which time you want the BlazorTimePicker to start from *e.g. when you have 'Time From' and 'Time To' and you want the 'Time To' to start from the selected 'Time From'*<br/>Default value: 0
**ContainerClass**<br/>[string]|<br/>Default value: "container"
**RowClass**<br/>[string]|<br/>Default value: "row"
**ColumnClass**<br/>[string]|<br/>Default value: "col-sm"
**SelectClass**<br/>[string]|<br/>Default value: "form-control"
**OnTimeChange**<br/>[`EventCallback<TimeSpan>`]|<br/>Default value: N/A

### Examples
Description|Example
-----------|-------
Setting initial time|`<CRXTimePicker Time="@(new TimeSpan(8,30,0))"></CRXTimePicker>`
