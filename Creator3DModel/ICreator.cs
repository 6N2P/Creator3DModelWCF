using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Creator3DModel
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "ICreator" в коде и файле конфигурации.
    [ServiceContract]
    public interface ICreator
    {
        [OperationContract]
        int CreateCub(int height, int width, int thickness);
    }
}
