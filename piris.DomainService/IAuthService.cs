using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace piris.DomainService
{
    [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        bool UserRegistration(UserRegistration userObj);
        [OperationContract]
        bool UserAuth(UserRegistration userObj);
    }
}