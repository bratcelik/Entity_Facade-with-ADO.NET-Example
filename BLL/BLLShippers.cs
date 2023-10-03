using Entity;
using Facade;

namespace BLL
{
    public class BLLShippers
    {
        public static bool BLL_INSERT(EShipper shipper)
        {
            bool sonuc;
            if(!string.IsNullOrEmpty(shipper.CompanyName) && !string.IsNullOrEmpty(shipper.Phone))
            {
                if (shipper.CompanyName.Length <= 40 && shipper.Phone.Length <= 24)
                {
                    sonuc = FShippers.Insert(shipper);
                }
                else
                {
                    sonuc =false;
                }
            }
            else
            {
                sonuc =false;
            }
            return sonuc;
        }

        public static bool BLL_UPDATE(EShipper shipper)
        {
            bool sonuc;
            if (shipper.ShipperID > 0 && !string.IsNullOrEmpty(shipper.CompanyName) && !string.IsNullOrEmpty(shipper.Phone))
            {
                if (shipper.CompanyName.Length <= 40 && shipper.Phone.Length <= 24)
                {
                    sonuc = FShippers.Update(shipper);
                }
                else
                {
                    sonuc = false;
                }
            }
            else
            {
                sonuc = false;
            }
            return sonuc;
        }

        public static bool BLL_DELETE(int shipperID)
        {
            bool sonuc;
            if (shipperID > 0)
            {
                sonuc = FShippers.Delete(shipperID);
            }
            else
            {
                sonuc = false;
            }
            return sonuc;
        }
    }
}
