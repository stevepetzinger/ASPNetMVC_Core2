using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerStore.BLL
{
    public interface IPriceManager
    {
        decimal GetPrice(int computerId, int stateId);
    }
}
