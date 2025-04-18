using System;
using eGymLife.BusinessLogic.BlStruct;
using eGymLife.BusinessLogic.Interfaces;

namespace eGymLife.BusinessLogic
{//implimentarea la metoda
    public class BusinessLogic
    {
        public ISession GetAuthBl()
        {
            return new LoginBl();
        }

    }
}