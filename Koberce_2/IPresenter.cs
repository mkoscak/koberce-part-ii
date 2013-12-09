using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Koberce_2.Entities;

namespace Koberce_2
{
    public interface IPresenter
    {
        /// <summary>
        /// Zobrazi status message v status bare
        /// </summary>
        /// <param name="status"></param>
        void ShowStatus(string status);

        /// <summary>
        /// Najde a zobrazi entitu s danym typom a id
        /// </summary>
        /// <param name="ofType"></param>
        /// <param name="id"></param>
        void FindShowEntity(Type ofType, long id);
    }
}
