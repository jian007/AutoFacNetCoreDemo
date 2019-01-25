using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.ModelsEntity
{
    public class Sys_MenusInfo
    {
        //{"id":25,"parentid":24,"name":"字典管理","ico":null,"href":"system/dictionary/dictionary_list.html","type":1,"permission":"","sort":52}
        public int Id { get; set; }
        /// <summary>
        /// 所属上级的菜单Id号
        /// </summary>
        public int ParentId { get; set; }
        public int Name { get; set; }
        public int Ico { get; set; }
        /// <summary>
        /// 跳转页面
        /// </summary>
        public int Href { get; set; }
        /// <summary>
        /// 菜单类型，1：表示是一级菜单类型，2：表示是二级菜单类型（按钮操作）
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 所拥有的权限  {id: 19, parentid: 15, name: "查询角色信息", ico: null, href: "", type: 2, permission: "sys:role:query",…}
        /// </summary>
        public int Permission { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        public string Description { get; set; }
        public string CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string UpdateOperatorId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string OperatorIP { get; set; }

    }
}
