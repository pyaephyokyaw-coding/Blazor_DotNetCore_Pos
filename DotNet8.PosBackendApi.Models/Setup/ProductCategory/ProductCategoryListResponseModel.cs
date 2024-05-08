﻿namespace DotNet8.PosBackendApi.Models.Setup.ProductCategory;

public class ProductCategoryListResponseModel
{
    public List<ProductCategoryModel> DataList { get; set; }
    public MessageResponseModel MessageResponse { get; set; }
    public ProductCategoryDataModel Data { get; set; }
}

public class ProductCategoryDataModel
{
    public PageSettingModel PageSetting { get; set; }
    public List<ProductCategoryModel> ProductCategory { get; set; }
}

public class PageSettingModel
{
    public PageSettingModel(int pageNo, int pageSize, int pageCount, int totalCount)
    {
        PageNo = pageNo;
        PageSize = pageSize;
        PageCount = pageCount;
        TotalCount = totalCount;
    }
    public int TotalCount { get; set; }
    public int PageCount { get; set; }
    public int PageNo { get; set; }
    public int PageSize { get; set; }
    public bool IsEndOfPage { get { return PageNo == PageCount; } }
}
