using System.ServiceModel;

namespace piris.DomainService
{
    [ServiceContract]
    public interface ICentralBankService
    {
        [OperationContract]
        ConverterObject ConvertValue(double value, string
        currencyValue);
    }
}