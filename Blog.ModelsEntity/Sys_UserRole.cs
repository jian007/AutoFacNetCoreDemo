using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.ModelsEntity
{
    public  class Sys_UserRole
    {
        public int URId { get; set; }
        /// <summary>
        /// 所属用户id编号
        /// </summary>
        public int UId { get; set; }
        /// <summary>
        /// 所属角色id编号
        /// </summary>
        public int RId { get; set; }
    }
}
