using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyTaskNew.Exceptions
{
    public class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException(string message):base(message)
        {

        }
    }
}
