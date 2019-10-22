﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sys.Safety.Model
{
    [Table("KJ_Note")]
    public partial class Jc_RemarkModel
    {
        /// <summary>
        /// ID编号
        /// </summary>
        [Key]
        public string ID
        {
           get;
           set;
        }
        	    /// <summary>
        /// 与JC_B中的DevID关联
        /// </summary>
                public string BID
        {
           get;
           set;
        }
        	    /// <summary>
        /// 日期
        /// </summary>
                public DateTime Timer
        {
           get;
           set;
        }
        	    /// <summary>
        /// 备注信息
        /// </summary>
                public string Remark
        {
           get;
           set;
        }
        	    /// <summary>
        /// 写数据库时间
        /// </summary>
                public DateTime Intime
        {
           get;
           set;
        }
        	    /// <summary>
        /// 备用
        /// </summary>
                public string Bz1
        {
           get;
           set;
        }
        	    /// <summary>
        /// 备用
        /// </summary>
                public string Bz2
        {
           get;
           set;
        }
        	    /// <summary>
        /// 备用
        /// </summary>
                public string Bz3
        {
           get;
           set;
        }
        	    /// <summary>
        /// 备用
        /// </summary>
                public string Bz4
        {
           get;
           set;
        }
        	    /// <summary>
        /// 标志
        /// </summary>
                public string Upflag
        {
           get;
           set;
        }
            }
}

