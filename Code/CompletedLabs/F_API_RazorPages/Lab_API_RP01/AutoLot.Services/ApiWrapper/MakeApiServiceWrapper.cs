// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Services - MakeApiServiceWrapper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/29
// ==================================

namespace AutoLot.Services.ApiWrapper;

public class MakeApiServiceWrapper(
    HttpClient client,
    IOptionsMonitor<ApiServiceSettings> apiSettingsMonitor)
    : ApiServiceWrapperBase<Make>(client, apiSettingsMonitor, apiSettingsMonitor.CurrentValue.MakeBaseUri), 
        IMakeApiServiceWrapper;