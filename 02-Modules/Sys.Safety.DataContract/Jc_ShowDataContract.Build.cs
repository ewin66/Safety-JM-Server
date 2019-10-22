﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Sys.Safety.DataContract
{
    public partial class Jc_ShowInfo : Basic.Framework.Web.BasicInfo
    {        
         	    /// <summary>
        /// ID编号
        /// </summary>
        public string ID
        {
           get;
           set;
        }
         	    /// <summary>
        /// 显示序号（组号）
        /// </summary>
        public int Px
        {
           get;
           set;
        }
         	    /// <summary>
        /// 行号
        /// </summary>
        public int Rowid
        {
           get;
           set;
        }
         	    /// <summary>
        /// 测点号
        /// </summary>
        public string Point
        {
           get;
           set;
        }
         	    /// <summary>
        /// 页面编号
        /// </summary>
        public string Page
        {
           get;
           set;
        }
         	    /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
           get;
           set;
        }
         	    /// <summary>
        /// 上传标志：0未传，1已传
        /// </summary>
        public string Upflag
        {
           get;
           set;
        }
            }
}


