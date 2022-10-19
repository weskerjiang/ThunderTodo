/**
* Namespace: ThunderTodo.Utils
* Name:      Util
* Author:    江挺
* Time:      2022/10/19 16:30:23
* Ver:       1.0
*
* Info: N/A
*/

using ThunderTodo.Domain;

namespace ThunderTodo.Utils
{
    public static class Util
    {
        public static string EXEPATH = System.Environment.CurrentDirectory + "\\";

        public static User CurrentUser { get; set; }
    }
}
