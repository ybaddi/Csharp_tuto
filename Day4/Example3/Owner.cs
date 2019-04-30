
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Csharp_tuto.Day4.Example3
{
    internal class Owner: ISerializable
    {
        private string v1;
        private int v2;


        public Owner() : this("v1", 0)
        {
            
        }

        public Owner(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        // hibernat JPA
        // elquante ==> laravel 
        // Django Python
        string Name { get; set; }
        int ID { get; set; }

        public void GetObjectData(SerializationInfo info, 
            StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("ID", ID);
        }

        public  Owner(SerializationInfo info,
            StreamingContext context)
        {
           Name = (string)  info.GetValue("Name", typeof(string));
           ID  = (int) info.GetValue("ID", typeof(int));
        }



    }
}