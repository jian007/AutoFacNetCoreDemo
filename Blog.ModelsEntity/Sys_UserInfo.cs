using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.ModelsEntity
{
    public class Sys_UserInfo
    {
        public int Uid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NiceName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }
        public string HeadImgeUrl { get; set; }
        public int Status { get; set; }
        public string CreateUserID { get; set; }
        public DateTime CreateTime { get; set; }
        public string UpdateUserID { get; set; }
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 角色ID编号
        /// </summary>
        public int Rid { get; set; }
        /// <summary>
        /// 菜单ID编号
        /// </summary>
        public int Mid { get; set; }
        /// <summary>
        /// 是否激活，激活：（1）true激活，（0），false未激活
        /// </summary>
        public int Enabled { get; set; }
        /// <summary>
        /// 账户不过期，（1）true（不过期）
        /// </summary>
        public int AccountNonExpired { get; set; }
        /// <summary>
        /// 未锁定 1表示为true（未锁定），0表示为false（锁定）
        /// </summary>
        public int AccountNonLocked { get; set; }
        /// <summary>
        /// 凭证不过期, 1表示为true（凭证不过期），0表示为false（凭证过期）
        /// </summary>
        public int CredentialsNonExpired { get; set; }
        //public int credentials Non Expired { get; set; }
    }
}
