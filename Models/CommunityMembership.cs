using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class CommunityMembership
    {
        //5.	Refer to the lecture, and add the proper navigational properties to CommunityMembership, Community and Student models
        //          a.For Navigational properties you define in Community and Student models, name both Membership, and make sure that they navigate to CommunityMembership

        public int StudentId { get; set; }

        public string CommunityId { get; set; }

        //proper navigational properties for this model
        
        Community Community { get; set; }
        Student Student { get; set; }
    }
}
