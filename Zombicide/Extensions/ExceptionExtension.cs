using System;

namespace Zombicide.Extensions
{
    public static class ExceptionExtension
    {
        public static Exception GetFirstException(this Exception ex)
        {
            Exception temp = ex;

            while (temp.InnerException != null)
            {
                temp = temp.InnerException;
            }
            return temp;
        }
    }
}