// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Services - MakeDalDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/29
// ==================================

namespace AutoLot.Services.DataServices.Dal;

public class MakeDalDataService(IAppLogging<MakeDalDataService> appLogging, IMakeRepo repo)
    : DalDataServiceBase<Make, MakeDalDataService>(appLogging, repo), IMakeDataService;