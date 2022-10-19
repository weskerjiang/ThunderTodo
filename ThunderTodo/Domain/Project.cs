/**
* Namespace: ThunderTodo.Domain
* Name:      Project
* Author:    江挺
* Time:      2022/10/19 15:05:05
* Ver:       1.0
*
* Info: N/A
*/

using SqlSugar;
using System;

namespace ThunderTodo.Domain
{
    [SugarTable("Project", "项目表")]
    public class Project
    {
        [SugarColumn(ColumnDescription = "项目ID", IsIdentity = true, IsNullable = false, IsPrimaryKey = true)]
        public long Id { get; set; }

        [SugarColumn(ColumnDescription = "项目名称")]
        public string Name { get; set; }

        [SugarColumn(ColumnDescription = "项目类型")]
        public string Type { get; set; }

        [SugarColumn(ColumnDescription = "计划开始日期")]
        public DateTime StartDate { get; set; }

        [SugarColumn(ColumnDescription = "计划结束日期")]
        public DateTime EndDate { get; set; }

        [SugarColumn(ColumnDescription = "实际结束日期")]
        public DateTime FinishDate { get; set; }

        [SugarColumn(ColumnDescription = "负责人Id")]
        public long LeaderId { get; set; }

        [SugarColumn(ColumnDescription = "参与人员")]
        public string Members { get; set; }

        [SugarColumn(ColumnDescription = "备注")]
        public string Remark { get; set; }

        [SugarColumn(ColumnDescription = "客户")]
        public string Customer { get; set; }

        [SugarColumn(ColumnDescription = "联系人")]
        public string Contact { get; set; }
    }
}
