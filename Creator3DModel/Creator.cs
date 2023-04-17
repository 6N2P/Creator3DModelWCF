using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Creator3DModel
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Creator" в коде и файле конфигурации.
    public class Creator : ICreator
    {
        public int  CreateCub(int height, int width, int thickness)
        {
            //создать метод для возвращения куба
            return height * width * thickness;
        }
    }
}
