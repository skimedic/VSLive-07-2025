﻿// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Mvc - ItemEditTagHelper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Mvc.TagHelpers;

public class ItemEditTagHelper : ItemLinkTagHelperBase
{
    public ItemEditTagHelper(
        IActionContextAccessor contextAccessor,
        IUrlHelperFactory urlHelperFactory)
        : base(contextAccessor, urlHelperFactory)
    {
        ActionName = nameof(CarsController.EditAsync).RemoveAsyncSuffix(); 
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        BuildContent(output,"text-warning","Edit","edit");
    }
}