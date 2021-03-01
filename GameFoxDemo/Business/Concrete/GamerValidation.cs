using System;
using System.Collections.Generic;
using System.Text;
using GameFoxDemo.Business.Abstract;
using TcKimlikValidation;

namespace GameFoxDemo.Business.Concrete
{
    class GamerValidation: IGamerValidation
    {
        public bool Validate(IGamer gamer)
        {
            using (KPSPublicSoapClient service = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12))
            {
                var result = service.TCKimlikNoDogrulaAsync(
                    new TCKimlikNoDogrulaRequest(
                        new TCKimlikNoDogrulaRequestBody(
                            gamer.TcNo,
                            gamer.FirstName.ToUpper(),
                            gamer.LastName.ToUpper(),
                            gamer.DateOfBirth.Year
                        )));
                return result.Result.Body.TCKimlikNoDogrulaResult;
            }
        }
    }
}
