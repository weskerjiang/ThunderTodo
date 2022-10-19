/**
* Namespace: ThunderTodo.Domain
* Name:      User
* Author:    江挺
* Time:      2022/10/19 15:28:27
* Ver:       1.0
*
* Info: N/A
*/

using SqlSugar;

namespace ThunderTodo.Domain
{
    [SugarTable("User", "用户表")]
    public class User
    {
        [SugarColumn(ColumnDescription = "用户ID", IsIdentity = true, IsNullable = false, IsPrimaryKey = true)]
        public long Id { get; set; }

        [SugarColumn(ColumnDescription = "用户名字")]
        public string Name { get; set; }

        [SugarColumn(ColumnDescription = "用户密码")]
        public string Password { get; set; }

        [SugarColumn(ColumnDescription = "用户密码盐值")]
        public string Salt { get; set; }

        [SugarColumn(ColumnDescription = "用户状态：1正常，0冻结")]
        public int State { get; set; }

    }
}
