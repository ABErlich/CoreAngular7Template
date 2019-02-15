using System;
using Organigrama.ViewModels;

namespace Organigrama.Web.App_Start
{
    public class DBInitializeConfig
    {
		private IUserMap userMap;

        public DBInitializeConfig(IUserMap _userMap)
        {
			userMap = _userMap
        }

        public void DataTest(){
            Users();
        }

        private void Users(){
            userMap.Create(new UserViewModel() { id = 1, username = "Pablo" });
            userMap.Create(new UserViewModel() { id = 1, username = "Diego" });

        }
    }
}
