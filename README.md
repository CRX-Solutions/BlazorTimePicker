# BlazorTimePicker
Time picker for Blazor developed by **CRX Solutions**.

## Description
This is a component that will facilitate time picking in a Blazor project. By default it is designed to use the Bootstrap styling. But you can pass your own CSS classes through the following parameters (ContainerClass, RowClass, ColumnClass, and SelectClass)

```
<div class="**<ContainerClass>**">
</div>
```

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
**Time**<br/>[TimeSpan]|Initial time you want the BlazorTimePicker to be set to<br/><br/>**Default value:** 0<br/>**Example:** `Time="@(new TimeSpan(8,30,0))`
**MinutesSteps**<br/>[int]|Minute interval<br/><br/>**Default value:** 5<br/>**Example:** `MinutesSteps="10"`
**StartTime**<br/>[TimeSpan]|From which time you want the BlazorTimePicker to start from *e.g. when you have 'Time From' and 'Time To' and you want the 'Time To' to start from the selected 'Time From'*<br/><br/>**Default value:** 0<br/>**Example:** `StartTime="@(new TimeSpan(12,45,0))`
**ContainerClass**<br/>[string]|<br/><br/>**Default value:** "container"<br/>**Example:** `ContainerClass="container"`
**RowClass**<br/>[string]|<br/><br/>**Default value:** "row"<br/>**Example:** `RowClass="two fields"`
**ColumnClass**<br/>[string]|<br/><br/>**Default value:** "col-sm"<br/>**Example:** `ColumnClass="column"`
**SelectClass**<br/>[string]|<br/><br/>**Default value:** "form-control"<br/>**Example:** `SelectClass="ui fluid dropdown"`
**TimeChanged**<br/>[`EventCallback<TimeSpan>`]|<br/><br/>**Default value:** N/A<br/>**Example:** N/A

### Examples
Description|Example
-----------|-------
Setting initial time|`<CRXTimePicker Time="@(new TimeSpan(8,30,0))"></CRXTimePicker>`
Setting initial time and minutes interval|`<CRXTimePicker Time="@(new TimeSpan(8,30,0))"MinutesSteps="15" ></CRXTimePicker>`
Two way data binding for Time property|`@code {`<br/>`    private TimeSpan timeTo;`<br/>`}`<br/>`<CRXTimePicker @bind-Time"@timeTo"></CRXTimePicker>`

## Contribution & Feedback
Please feel free to use this component and do not hesitate to open an issue should you encouter any.
<br/>You are more then welcome to share your feedback with us regarding this component.
