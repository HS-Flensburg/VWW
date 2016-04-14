using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using VWW_V4_WCF;

namespace VWW_V4_WCF2
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "MyService" sowohl im Code als auch in der SVC- und der Konfigurationsdatei ändern.
    // HINWEIS: Wählen Sie zum Starten des WCF-Testclients zum Testen dieses Diensts MyService.svc oder MyService.svc.cs im Projektmappen-Explorer aus, und starten Sie das Debuggen.
    public class MyService : IMyService
    {
        User myUser = new User()
        {
            Name = "Max Mustermann",
            Age = 22
        };
        public User getUser()
        {
            return myUser;
        }

        public bool IsAdult(User usr)
        {
            return usr.Age >= 18;
        }

        public void print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
