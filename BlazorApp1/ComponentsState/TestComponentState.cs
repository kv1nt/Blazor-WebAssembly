using BlazorApp1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.ComponentsState
{
    public class TestComponentState
    {
        public List<UserViewModel> Users { get; set; }

        public TestComponentState()
        {
            Users = new List<UserViewModel>();
        }

       public void OnAddUserToSate(UserViewModel user)
       {
            Users.Add(user);
       }

        public IEnumerable<UserViewModel> OnGetUserFromSate()
        {
            return Users.ToList();
        }
    }
}
