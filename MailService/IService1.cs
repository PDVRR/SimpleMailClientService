using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MailService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string SendMail(string subject, DateTime date, string emailTo, string emailFrom, string tags, string content);

        [OperationContract]
        DataTable GetInboxMessages(string emailTo);

        [OperationContract]
        DataTable GetSentMessages(string emailFrom);

    }

}
