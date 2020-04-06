using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceBehaviors
{
    public class ChangeCollectionTypeBehaviorExtensionElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get
            {
                return typeof(ChangeCollectionTypeBehaviorAttribute);
            }
        }

        protected override object CreateBehavior()
        {
            return new ChangeCollectionTypeBehaviorAttribute();
        }
    }
}