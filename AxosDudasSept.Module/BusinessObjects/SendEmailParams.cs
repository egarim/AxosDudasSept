using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace AxosDudasSept.Module.BusinessObjects
{
    [NonPersistent()]
    public class SendEmailParams : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public SendEmailParams(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string body;
        string subject;
        string bcc;
        string cc;
        string to;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string To
        {
            get => to;
            set => SetPropertyValue(nameof(To), ref to, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Cc
        {
            get => cc;
            set => SetPropertyValue(nameof(Cc), ref cc, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Bcc
        {
            get => bcc;
            set => SetPropertyValue(nameof(Bcc), ref bcc, value);
        }

        public string Subject
        {
            get => subject;
            set => SetPropertyValue(nameof(Subject), ref subject, value);
        }
        
        [Size(SizeAttribute.Unlimited)]
        public string Body
        {
            get => body;
            set => SetPropertyValue(nameof(Body), ref body, value);
        }
    }
}