using System;

namespace proyectoprogramado.Models {

    public class LoginModel {

        public bool check_user (string id, string password){
            bool result = string.Compare(id, password) == 0;
            return result;
        }

    }
}

