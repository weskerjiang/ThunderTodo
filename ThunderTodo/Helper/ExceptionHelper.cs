/**
* Namespace: ThunderTodo.Helper
* Name:      ExceptionHelper
* Author:    江挺
* Time:      2022/10/19 16:34:12
* Ver:       1.0
*
* Info: N/A
*/

using System;

namespace ThunderTodo.Helper
{
    public sealed class ExceptionHelper
    {
        private ExceptionHelper() { }

        private static readonly Lazy<ExceptionHelper> InstanceLock = new Lazy<ExceptionHelper>(() => new ExceptionHelper());

        public static ExceptionHelper CreateInstance
        {
            get
            {
                return InstanceLock.Value;
            }
        }

        public string Log(Exception ex)
        {
            //ErrorEntity error = new ErrorEntity();
            //error.Id = Guid.NewGuid().ToString();
            //error.CreateDate = GlobalUtil.ServerDate;
            //error.CreateUserId = GlobalUtil.CurrentUser.Id;
            //error.Code = StringUtil.GetErrorCode();
            //error.Message = ex.Message;
            //error.StackTrace = ex.StackTrace;

            //SqlServerHelper.GetInstance().Insertable(error).ExecuteCommand();
            //return error.Code;
            return "";
        }
    }
}
