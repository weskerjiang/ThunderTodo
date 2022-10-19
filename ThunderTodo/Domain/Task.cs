/**
* Namespace: ThunderTodo.Domain
* Name:      Task
* Author:    江挺
* Time:      2022/10/19 15:01:02
* Ver:       1.0
*
* Info: N/A
*/

using SqlSugar;
using System;

namespace ThunderTodo.Domain
{
    [SugarTable("Task", "任务表")]
    public class Task
    {
        [SugarColumn(ColumnDescription = "任务ID", IsIdentity = true, IsNullable = false, IsPrimaryKey = true)]
        public long Id { get; set; }

        [SugarColumn(ColumnDescription = "项目ID")]
        public long ProjectId { get; set; }

        [SugarColumn(ColumnDescription = "任务名称")]
        public string Name { get; set; }

        [SugarColumn(ColumnDescription = "负责人")]
        public long Respo { get; set; }

        [SugarColumn(ColumnDescription = "计划开始日期")]
        public DateTime StartDate { get; set; }

        [SugarColumn(ColumnDescription = "计划结束日期")]
        public DateTime EndDate { get; set; }

        [SugarColumn(ColumnDescription = "实际结束日期")]
        public DateTime FinishDate { get; set; }

        [SugarColumn(ColumnDescription = "状态：0未结束，1结束")]
        public int State { get; set; }

        [SugarColumn(ColumnDescription = "备注")]
        public string Remark { get; set; }
    }
}
