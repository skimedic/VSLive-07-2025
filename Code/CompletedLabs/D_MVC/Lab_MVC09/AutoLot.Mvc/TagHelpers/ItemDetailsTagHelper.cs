﻿// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Mvc - ItemDetailsTagHelper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Mvc.TagHelpers;

public class ItemDetailsTagHelper : ItemLinkTagHelperBase
{
    public ItemDetailsTagHelper(
        IActionContextAccessor contextAccessor, 
        IUrlHelperFactory urlHelperFactory) 
        : base(contextAccessor, urlHelperFactory) 
    {
        ActionName = nameof(CarsController.DetailsAsync).RemoveAsyncSuffix(); 
    }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        BuildContent(output,"text-info","Details","info-circle");
    }
}