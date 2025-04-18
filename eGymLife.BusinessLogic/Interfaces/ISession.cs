using System;
using System.Collections.Generic;
using System.Text;
using eGymLife.Domain.Entities.User;
using eGymLife.Domain.Model.User;

namespace eGymLife.BusinessLogic.Interfaces
{//declaram metoda
    public interface ISession
    {
        void UserRegister(UDbTable data);
    }
}


