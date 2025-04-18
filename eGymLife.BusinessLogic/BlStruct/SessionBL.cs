using eGymLife.BusinessLogic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eGymLife.BusinessLogic.Interfaces;
using eGymLife.Domain.Entities.User;
using eGymLife.Domain.Model.User;
using System.Data.Entity;
using System.Web;
using eGymLife.BusinessLogic.DBModel;
using eGymLife.Domain.Entities;


namespace eGymLife.BusinessLogic.BlStruct
{
    public class SessionBL : UserAPI, ISession
    {
        public void UserRegister(UDbTable data)
        {
            UserRegisterAction(data);
        }

    }

}
