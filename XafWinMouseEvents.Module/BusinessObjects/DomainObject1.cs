using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XafWinMouseEvents.Module.BusinessObjects
{
    public class DomainObject1: DevExpress.Persistent.BaseImpl.BaseObject
    {
        /// <summary>
        /// <para>Used to initialize a new instance of a <see cref="DomainObject1"/> descendant, in a particular <see cref="DevExpress.Xpo.Session"/>.</para>
        /// </summary>
        /// <param name="session">A DevExpress.Xpo.Session object which represents a persistent object’s cache where the business object will be instantiated.</param>
        public DomainObject1(Session session) : base(session)
        {

        }

        /// <summary>
        /// <para>Creates a new instance of the <see cref="DomainObject1"/> class.</para>
        /// </summary>
        public DomainObject1()
        {

        }

        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }
    }
}
