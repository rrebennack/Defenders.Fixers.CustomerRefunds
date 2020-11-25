using System;

namespace CustomerRefunds.Helpers
{
    public enum ResultSetStatus
    {
        Good = 0,
        Error = 1,
        NoData = 2
    }

    public class ResultSet
    {
        public ResultSetStatus Status
        {
            get;
            set;
        }

        public object Data
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public string LocationCode
        {
            get;
            set;
        }

        public ResultSet(object data = null)
        {
            this.Data = data;
            this.Status = ResultSetStatus.Good;
            this.Message = string.Empty;
        }

        public static ResultSet MakeError()
        {
            return new ResultSet()
            {
                Status = ResultSetStatus.Error
            };
        }

        public static ResultSet MakeError(string message)
        {
            return ResultSet.MakeError(null, message);
        }

        public static ResultSet MakeError(string locationCode, string message)
        {
            return new ResultSet()
            {
                Status = ResultSetStatus.Error,
                Message = message,
                LocationCode = locationCode
            };
        }

        public static ResultSet MakeError(string locationCode, Exception gotsError)
        {
            Util.WriteError(locationCode, gotsError);

            return ResultSet.MakeError(locationCode, gotsError.Message);
        }

        public static ResultSet MakeNoData(string message = null)
        {
            return new ResultSet
            {
                Status = ResultSetStatus.NoData,
                Message = message ?? "No data found"
            };
        }

        public static ResultSet MakeGood(object data = null)
        {
            return new ResultSet
            {
                Data = data,
                Status = ResultSetStatus.Good
            };
        }
    }
}