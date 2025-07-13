// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Blazor.Models - BaseEntity.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

namespace AutoLot.Blazor.Models.Entities.Base;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public long TimeStamp { get; set; }
}