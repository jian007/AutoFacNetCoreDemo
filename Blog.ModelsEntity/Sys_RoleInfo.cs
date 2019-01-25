using System;

namespace Blog.ModelsEntity
{
    public class Sys_RoleInfo
    {
        public int Rid { get; set; }
        public string RName { get; set; }
        /// <summary>
        /// 备注角色说明
        /// </summary>
        public string Description { get; set; }
        public string CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string UpdateOperatorId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string OperatorIP  { get; set; }
    }
}
