using System;
using System.Collections;
using System.Data;
using System.IO;

namespace CustomerRefunds.Helpers
{
    public class Util
    {
        public const string LogName = "CustomerRefunds.log";

        public static void WriteError(string locationCode, Exception except)
        {
            var message = string.Format("{0}\n{1}", except.Message, except.InnerException?.Message);

            Util.WriteError(locationCode, message);
        }

        public static void WriteError(string locationCode, string message)
        {
            var log = Path.Combine(Path.GetTempPath(), Util.LogName);

            message = string.Format("[{0}] [{1}]\t{2}\n", DateTime.Now, locationCode, message);

            File.AppendAllText(log, message);
        }

        public static bool IsEmpty(object testEmpty)
        {
            if ( testEmpty == null || testEmpty == DBNull.Value )
            {
                return true;
            }

            if ( testEmpty is DataTable )
            {
                return ((DataTable)testEmpty).Rows.Count == 0;
            }

            if ( testEmpty is ICollection )
            {
                return ((ICollection)testEmpty).Count == 0;
            }

            if ( String.IsNullOrEmpty(testEmpty.ToString()) )
            {
                return true;
            }

            if ( testEmpty.ToString().StartsWith("0000-00-00") )
            {
                return true;
            }

            if ( decimal.TryParse(testEmpty.ToString(), out var dude) )
            {
                return (dude == 0);
            }

            if ( bool.TryParse(testEmpty.ToString(), out var logi) && !logi )
            {
                return true;
            }

            return false;
        }
    }
}