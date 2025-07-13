// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Services - MakeApiDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/29
// ==================================

namespace AutoLot.Services.DataServices.Api;

public class MakeApiDataService(
    IAppLogging<MakeApiDataService> appLogging, IMakeApiServiceWrapper serviceWrapper)
    : ApiDataServiceBase<Make, MakeApiDataService>(appLogging, serviceWrapper), IMakeDataService;