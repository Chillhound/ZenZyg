using System;
using System.Drawing;
using QRCoder;
using ZenZygServer_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ZenZygServer_API.Entities;

namespace ZenZygServer_API
{
    /*
    * Encoder for QRCoder
    *
    * Decoder will not be implemented in this project, instead we will display the QRCode in the UI and make it clickabl which redirects.
    */


    public class TicketGenerator
    {
      
        // The QrCode will be saved as a Base64 image that is stored as a string
        public async Task<Ticket> GenerateTicket(string phoneNumb, int storeID)
        {
            if (phoneNumb == null || storeID == null) return null;

            QRCodeGenerator QRGen = new QRCodeGenerator();
            QRCodeData QRData =  QRGen.CreateQrCode(storeID + "-" + phoneNumb, QRCodeGenerator.ECCLevel.Q); // ECC = Error correction level   Q = 25%
            Base64QRCode QrCode = new Base64QRCode(QRData);
            string QrCodeImageData = QrCode.GetGraphic(20);  // PixelsPerModule 20

            Ticket ticket = new Ticket
            {
                phoneNumber = phoneNumb,
                StoreId = storeID,
                QRData = QrCodeImageData
            };
           
            return ticket;
        }
    }
}