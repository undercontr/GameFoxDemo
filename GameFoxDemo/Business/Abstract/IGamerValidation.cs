using System;
using System.Collections.Generic;
using System.Text;

namespace GameFoxDemo.Business.Abstract
{
    interface IGamerValidation
    {
        bool Validate(IGamer gamer);
    }
}
