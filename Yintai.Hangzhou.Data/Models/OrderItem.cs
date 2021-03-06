using System;
using System.Collections.Generic;

namespace Yintai.Hangzhou.Data.Models
{
    public partial class OrderItemEntity : Yintai.Architecture.Common.Models.BaseEntity
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public int ProductId { get; set; }
        public string ProductDesc { get; set; }
        public string StoreItemNo { get; set; }
        public string StoreItemDesc { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal ExtendPrice { get; set; }
        public int BrandId { get; set; }
        public int StoreId { get; set; }
        public int CreateUser { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int Status { get; set; }

        #region Overrides of BaseEntity

        /// <summary>
        /// KeyMemberId
        /// </summary>
        public override object EntityId
        {       
                get { return new Dictionary<string, object> (14){
                {"Id",Id}, {"OrderNo",OrderNo}, {"ProductId",ProductId}, {"ProductDesc",ProductDesc}, {"Quantity",Quantity}, {"ItemPrice",ItemPrice}, {"ExtendPrice",ExtendPrice}, {"BrandId",BrandId}, {"StoreId",StoreId}, {"CreateUser",CreateUser}, {"CreateDate",CreateDate}, {"UpdateUser",UpdateUser}, {"UpdateDate",UpdateDate}, {"Status",Status} 
                };}
 
        }

        #endregion
    }
}
