using System;
using System.Collections.Generic;

namespace Tracker.Domain.Models
{
    public partial class TaskExtendedReadModel
    {
        #region Generated Properties
        public Guid TaskId { get; set; }

        public string UserAgent { get; set; }

        public string Browser { get; set; }

        public string OperatingSystem { get; set; }

        public DateTimeOffset Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset Updated { get; set; }

        public string UpdatedBy { get; set; }

        public Byte[] RowVersion { get; set; }

        #endregion

    }
}
