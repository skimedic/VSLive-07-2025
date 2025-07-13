// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Services - MakeDalDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Services.DataServices.Dal;

public class MakeDalDataService(IAppLogging<MakeDalDataService> appLogging, IMakeRepo repo)
    : DalDataServiceBase<Make, MakeDalDataService>(appLogging, repo), IMakeDataService;