using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ExceptionManager
    {

        public string PATH = @"C:\Users\milton\source\repos\Proyecto2Lab2\logs";

        private static ExceptionManager instance;

        public static ExceptionManager GetInstance()
        {
            if (instance == null)
                instance = new ExceptionManager();

            return instance;
        }

        public void Process(Exception ex)
        {
            var bex = new BusinessException();

            if(ex.GetType() == typeof(BusinessException))
            {
                bex = (BusinessException)ex;
            }
            else
            {
                bex = new BusinessException(0, ex);
            }

            ProcessBusinessException(bex);

        }

        public void ProcessBusinessException(BusinessException bex)
        {
            var today = DateTime.Now.ToString("yyyyMMDD_hh");
            var logName = PATH + today + "_" + "log.txt";

            var message = bex.Message + "\n" + bex.StackTrace + "\n";

            if(bex.InnerException != null)
                message += bex.InnerException.Message + "\n" + bex.InnerException.StackTrace;

            using(StreamWriter w = File.AppendText(logName))
            {
         //Aqui quedamos
            }

        }



    }
}
