using System;

namespace Proposed_Exercise_Exceptions.Entities.Exeptions
{
    class DomainExeptions: ApplicationException
    {
        public DomainExeptions(string menssage): base(menssage)
        {

        }
    }
}
