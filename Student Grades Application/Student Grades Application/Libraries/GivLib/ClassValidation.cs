using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GivLib
{
    public class ClassValidation
    {
        bool reponse; //if the reponse is true its a RED FLAG
       public bool AddCheck(string file, string subject, 
           string studentNo, string Name, string Surname, 
           string IndAssignment, string GrpAssignment, string Test)
        {
            if (file != null && subject == null | studentNo == null | Name == null |
                Surname == null | IndAssignment == null | GrpAssignment == null | Test == null)
            {
                 reponse = true;
            }
            return reponse;
        }
    }
}
