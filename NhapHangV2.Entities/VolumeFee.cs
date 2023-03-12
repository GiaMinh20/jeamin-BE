﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Entities
{
    public class VolumeFee : DomainEntities.AppDomain
    {
        /// <summary>
        /// ID từ kho
        /// </summary>
        public int? WarehouseFromId { get; set; } = 0;

        /// <summary>
        /// Tên từ kho
        /// </summary>
        [NotMapped]
        public string WarehouseFromName { get; set; } = string.Empty;

        /// <summary>
        /// ID đến kho
        /// </summary>
        public int? WarehouseId { get; set; } = 0;

        /// <summary>
        /// Tên đến kho
        /// </summary>
        [NotMapped]
        public string WareHouseToName { get; set; } = string.Empty;

        /// <summary>
        /// Thể tích từ
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal? VolumeFrom { get; set; } = 0;

        /// <summary>
        /// Thể tích đến
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal? VolumeTo { get; set; } = 0;

        /// <summary>
        /// Giá
        /// </summary>
        [Column(TypeName = "decimal(18,0)")]
        public decimal? Price { get; set; } = 0;

        /// <summary>
        /// ID Hình thức vận chuyển
        /// </summary>
        public int? ShippingTypeToWareHouseId { get; set; } = 0;

        /// <summary>
        /// Tên hình thức vận chuyển
        /// </summary>
        [NotMapped]
        public string ShippingTypeToWareHouseName { get; set; } = string.Empty;

        /// <summary>
        /// Loại đơn hàng (True: Đơn ký gửi, False: Đơn mua hộ)
        /// </summary>
        public bool? IsHelpMoving { get; set; } = false;
    }
}
