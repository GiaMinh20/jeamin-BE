﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace jeamin.Models.DomainModels
{
    public class AppDomainFileModel : AppDomainModel
    {
        /// <summary>
        /// Tên file (Tên lưu trong thư mục)
        /// </summary>
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// Loại file
        /// </summary>
        public string ContentType { get; set; } = string.Empty;

        /// <summary>
        /// Đuôi file
        /// </summary>
        public string FileExtension { get; set; } = string.Empty;

        /// <summary>
        /// Mô tả
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Link download File
        /// </summary>
        public string FileUrl { get; set; } = string.Empty;

    }
}
