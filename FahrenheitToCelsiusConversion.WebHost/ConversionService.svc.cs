using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FahrenheitToCelsiusConversion.WebHost
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ConversionService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы ConversionService.svc или ConversionService.svc.cs в обозревателе решений и начните отладку.
    public class ConversionService : IConversionService
    {
        public double FahrenheitToCelsius(double farenheitDegrees)
        {
            return 5 / 9 * (farenheitDegrees - 32);
        }
        public double CelsiusToFahrenheit(double celsiusDegrees)
        {
            return 9.0 / 5 * celsiusDegrees + 32;
        }
    }
}
