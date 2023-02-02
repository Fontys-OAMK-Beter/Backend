﻿using GroopySwoopyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroopySwoopyInterfaces;

namespace GroopySwoopyLogic
{
    public class UserService
    {
        private readonly IUserDataservice _Dataservice;

        public List<string> Users { get; set; }


        public UserService(IUserDataservice userdataservice)
        {
            this._Dataservice = userdataservice;
        }

        public UserService(List<string> users)
        {
            this.Users = users;
        }

        public void GetAllUsers()
        {
            _Dataservice.GetAllUsers();
        }
    }
}
