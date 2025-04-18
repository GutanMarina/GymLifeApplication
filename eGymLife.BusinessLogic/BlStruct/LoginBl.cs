using System;
using System.Collections.Generic;
using System.Text;
using eGymLife.BusinessLogic.Core;
using eGymLife.BusinessLogic.Interfaces;
using eGymLife.Domain.Entities.User;
using eGymLife.Domain.Model.User;

namespace eGymLife.BusinessLogic.BlStruct
{//legatura businesslog cu metoda, declararea metodei, implementare din interfata cu parametru in useriapi
    public class LoginBl : UserAPI, ISession
    {

        public string UserAuthLogic(UserLoginDTO data)
        {
            return UserAuthLogicAction(data);
        }


        public void UserRegister(UDbTable data)
        {
            throw new NotImplementedException();
        }
    }
}
