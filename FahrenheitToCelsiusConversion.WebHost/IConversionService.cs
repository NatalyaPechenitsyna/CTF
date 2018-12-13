using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FahrenheitToCelsiusConversion.WebHost
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IConversionService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IConversionService
    {
        [OperationContract]
        double FahrenheitToCelsius(double farenheitDegrees);
        [OperationContract]
        double CelsiusToFahrenheit(double celsiusDegrees);
    }
}
