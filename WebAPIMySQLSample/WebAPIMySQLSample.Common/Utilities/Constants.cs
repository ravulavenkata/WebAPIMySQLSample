using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Common.Utilities
{
    public class WebAPIMySQLSampleApplicationConstants
    {

        public const string WebAPIMySQLSampleApplicationAPI = "http://localhost:43321/";
        public const string WebAPIMySQLSampleApplicationClient = "http://localhost:27470/";
        public const string WebAPIMySQLSampleApplicationiOSMobile = "ms-app://s-1-15-2-467734538-4209884262-1311024127-1211083007-3894294004-443087774-3929518054/";
        public const string WebAPIMySQLSampleApplicationAndroidMobile = "ms-app://s-1-15-2-467734538-4209884262-1311024127-1211083007-3894294004-443087774-3929518054/";


    }


    public  enum RecordStatus
    {
        Active=0,
        InActive,
        Pending,
        Cancelled,
        Rejected,
        TBD,
        Created,
        Deleted,
        InProgress,
        Delayed,
        AtRisk

    }
}
