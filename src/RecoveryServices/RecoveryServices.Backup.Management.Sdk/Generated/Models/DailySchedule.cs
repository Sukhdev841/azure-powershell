// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    public partial class DailySchedule
    {
        /// <summary>
        /// Initializes a new instance of the DailySchedule class.
        /// </summary>
        public DailySchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DailySchedule class.
        /// </summary>

        /// <param name="scheduleRunTimes">List of times of day this schedule has to be run.
        /// </param>
        public DailySchedule(System.Collections.Generic.IList<System.DateTime?> scheduleRunTimes = default(System.Collections.Generic.IList<System.DateTime?>))

        {
            this.ScheduleRunTimes = scheduleRunTimes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets list of times of day this schedule has to be run.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scheduleRunTimes")]
        public System.Collections.Generic.IList<System.DateTime?> ScheduleRunTimes {get; set; }
    }
}