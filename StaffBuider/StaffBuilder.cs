using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint; 

namespace StaffBuider
{
    public class StaffBuilder:SPJobDefinition
    {
        public StaffBuilder():base() { }

        public StaffBuilder(SPWebApplication webApplication)
            : base(
            "StaffBuilder", webApplication, null, SPJobLockType.Job)
        {
            this.Title = "Staff Builder Job";
        }

        public override void Execute(Guid targetInstanceId)
        {
            base.Execute(targetInstanceId);

            // Execute Your Code Here
        }
    }
}
