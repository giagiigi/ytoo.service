﻿using System;
using System.Globalization;
using Yintai.Architecture.Common.Models;

namespace Yintai.Hangzhou.Service.Manager
{
    /// <summary>
    /// cache key
    /// </summary>
    public class CacheKeyManager
    {
        //公司名_项目名_功能名_小功能_方法名_参数
        private const string ApiDataServiceKeyPre = "yt_hz_api_ds";
        private const string ProductKeyPre = ApiDataServiceKeyPre + "_prod";
        private const string TagKeyPre = ApiDataServiceKeyPre + "_tag";
        private const string StoreKeyPre = ApiDataServiceKeyPre + "_store";
        private const string BrandKeyPre = ApiDataServiceKeyPre + "_brand";
        private const string PromotionKeyPre = ApiDataServiceKeyPre + "_pro";

        private const int CacheDateSecond = 60;

        /// <summary>
        /// 产品详情 key
        /// </summary>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <returns>cache second</returns>
        public static int ProductInfoKey(int id, out string key)
        {
            const string keypre = ProductKeyPre + "_info";

            key = String.Concat(keypre, "_" + id.ToString(CultureInfo.InvariantCulture));

            return CacheDateSecond;
        }

        public static int ProductSearchKey(out string key, string mark)
        {
            const string keypre = ProductKeyPre + "_sch";

            key = String.Concat(keypre, "_" + mark);

            return CacheDateSecond;
        }

        public static int ProductListKey(out string key, string mark)
        {
            const string keypre = ProductKeyPre + "_ls";

            key = String.Concat(keypre, "_" + mark);

            return CacheDateSecond;
        }

        public static int TagAllKey(out string key)
        {
            const string tagKeyPre4All = TagKeyPre + "_all";
            key = tagKeyPre4All;

            return CacheDateSecond;
        }

        public static int StoreAllKey(CoordinateInfo info, out string key)
        {
            const string keyPre4All = StoreKeyPre + "_all";

            if (info == null)
            {
                key = keyPre4All;
            }
            else
            {
                key = String.Format("{0}_{1}_{2}", keyPre4All, info.Longitude, info.Latitude);
            }

            return CacheDateSecond;
        }

        public static int BrandAllKey(out string key)
        {
            const string keyPre4All = BrandKeyPre + "_all";

            key = keyPre4All;

            return CacheDateSecond;
        }

        public static int BrandAll4GroupKey(out string key)
        {
            const string keyPre4All = BrandKeyPre + "_all4group";

            key = keyPre4All;

            return CacheDateSecond;
        }
    }
}