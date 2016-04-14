using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using VWW_V4_WCF;

namespace VWW_V4_WCF2
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "IMyService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        [ServiceKnownType(typeof(User))]
        bool IsAdult(User usr);

        [OperationContract]
        [ServiceKnownType(typeof(User))]
        User getUser();

        [OperationContract]
        void print(string text);
    }
}
