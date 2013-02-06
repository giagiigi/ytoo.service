﻿using System.Collections.Generic;
using Yintai.Architecture.Common.Models;
using Yintai.Hangzhou.Data.Models;
using Yintai.Hangzhou.Model.Enums;

namespace Yintai.Hangzhou.Repository.Contract
{
    public interface IPromotionRepository : IRepository<PromotionEntity, int>
    {
        /// <summary>
        /// 查
        /// </summary>
        /// <param name="pagerRequest">分页</param>
        /// <param name="totalCount"></param>
        /// <param name="sortOrder"></param>
        /// <param name="dateTimeRangeInfo"></param>
        /// <param name="coordinateInfo"></param>
        /// <param name="timestamp"></param>
        /// <param name="recommendUser"></param>
        /// <param name="filterMode">暂时没实现</param>
        /// <param name="promotionName"></param>
        /// <param name="tagids"></param>
        /// <param name="brandId">暂时没实现</param>
        /// <returns></returns>
        List<PromotionEntity> GetPagedListForSearch(PagerRequest pagerRequest, out int totalCount,
                                                    PromotionSortOrder sortOrder,
                                                    DateTimeRangeInfo dateTimeRangeInfo, CoordinateInfo coordinateInfo,
                                                    Timestamp timestamp, int? recommendUser,
                                                    PromotionFilterMode? filterMode, string promotionName,
                                                    List<int> tagids, int? brandId);

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pagerRequest">page</param>
        /// <param name="totalCount">记录数</param>
        /// <param name="sortOrder">排序方式</param>
        /// <param name="dateTimeRangeInfo"></param>
        /// <param name="coordinateInfo"></param>
        /// <param name="timestamp"></param>
        /// <param name="recommendUser">推荐人</param>
        /// <param name="filterMode">过滤方式</param>
        /// <returns></returns>
        List<PromotionEntity> GetPagedList(PagerRequest pagerRequest, out int totalCount, PromotionSortOrder sortOrder,
                                           DateTimeRangeInfo dateTimeRangeInfo, CoordinateInfo coordinateInfo, Timestamp timestamp, int? recommendUser, PromotionFilterMode filterMode);


        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pagerRequest">page</param>
        /// <param name="totalCount">记录数</param>
        /// <param name="sortOrder">排序方式</param>
        /// <param name="dateTimeRangeInfo"></param>
        /// <param name="coordinateInfo"></param>
        /// <param name="timestamp"></param>
        /// <param name="recommendUser">推荐人</param>
        /// <param name="filterMode">过滤方式</param>
        /// <param name="specialSkipCount"></param>
        /// <returns></returns>
        List<PromotionEntity> GetPagedList(PagerRequest pagerRequest, out int totalCount, PromotionSortOrder sortOrder,
                                           DateTimeRangeInfo dateTimeRangeInfo, CoordinateInfo coordinateInfo, Timestamp timestamp, int? recommendUser, PromotionFilterMode filterMode, int? specialSkipCount);


        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pagerRequest">page</param>
        /// <param name="totalCount">记录数</param>
        /// <param name="sortOrder">排序方式</param>
        /// <param name="dateTimeRangeInfo"></param>
        /// <param name="coordinateInfo"></param>
        /// <param name="timestamp"></param>
        /// <param name="recommendUser">推荐人</param>
        /// <returns></returns>
        List<PromotionEntity> GetPagedList(PagerRequest pagerRequest, out int totalCount, PromotionSortOrder sortOrder,
                                           DateTimeRangeInfo dateTimeRangeInfo, CoordinateInfo coordinateInfo, Timestamp timestamp, int? recommendUser);

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        [System.Obsolete("有问题，默认使用了，开始时间和介绍时间的限制")]
        List<PromotionEntity> GetPagedList(int pageIndex, int pageSize, out int totalCount, int sort);

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <param name="sort"></param>
        /// <param name="timestamp">时间戳 </param>
        /// <returns></returns>
        [System.Obsolete("有问题，默认使用了，开始时间和介绍时间的限制")]
        List<PromotionEntity> GetPagedList(int pageIndex, int pageSize, out int totalCount, int sort, Timestamp timestamp);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <param name="sort"></param>
        /// <param name="lng"></param>
        /// <param name="lat"></param>
        /// <param name="timestamp">时间戳 </param>
        /// <returns></returns>
        [System.Obsolete("有问题，默认使用了，开始时间和介绍时间的限制")]
        List<PromotionEntity> GetPagedList(int pageIndex, int pageSize, out int totalCount, int sort, double lng, double lat, Timestamp timestamp);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <param name="sort"></param>
        /// <param name="lng"></param>
        /// <param name="lat"></param>
        /// <returns></returns>
        [System.Obsolete("有问题，默认使用了，开始时间和介绍时间的限制")]
        List<PromotionEntity> GetPagedList(int pageIndex, int pageSize, out int totalCount, int sort, double lng,
                                           double lat);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="sort"></param>
        /// <param name="timestamp">时间戳 </param>
        /// <returns></returns>
        List<PromotionEntity> GetList(int pageSize, int sort, Timestamp timestamp);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="sort"></param>
        /// <param name="lng"></param>
        /// <param name="lat"></param>
        /// <param name="timestamp">时间戳 </param>
        /// <returns></returns>
        List<PromotionEntity> GetList(int pageSize, int sort, double lng, double lat, Timestamp timestamp);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        List<PromotionEntity> GetList(List<int> ids);
    }
}
