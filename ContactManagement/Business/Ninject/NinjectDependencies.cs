using Ninject.Modules;
using Ninject.Extensions.Factory;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Managers.Interfaces;
using Data.Managers;
using Business.Managers.Interfaces;
using Business.Managers;

namespace Business.Ninject
{
    public class NinjectDependencies : NinjectModule
    {
        public override void Load()
        {

            #region DbContext
            Bind<ContactContext>()
                .ToMethod(c => new ContactContext())
                .InRequestScope();
            #endregion

            #region Data Managers
            Bind<IContactDataManager>().To<ContactDataManager>();
            #endregion

            #region Business Managers
            Bind<IContactBusinessManager>().To<ContactBusinessManager>();
            #endregion

        }
    }
}
