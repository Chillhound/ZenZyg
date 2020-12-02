using System;
using System.Drawing;
using QRCoder;
using ZenZygServer_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ZenZygServer_API.Entities;
using ZenZygServer_API.Models.DTO;

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
        public async Task<Ticket> GenerateTicket(TicketCreateDTO createDTO)
        {
           // if (phoneNumb == null || storeID == null) return null;

            QRCodeGenerator QRGen = new QRCodeGenerator();
            QRCodeData QRData =  QRGen.CreateQrCode(createDTO.StoreId + "-" + createDTO.CustomerId, QRCodeGenerator.ECCLevel.Q); // ECC = Error correction level   Q = 25%
            Base64QRCode QrCode = new Base64QRCode(QRData);
            string QrCodeImageData = QrCode.GetGraphic(20);  // PixelsPerModule 20

            Ticket ticket = new Ticket
            {
                
                CustomerId = createDTO.CustomerId,
                StoreId = createDTO.StoreId,
                QRData = QrCodeImageData
            };
            return ticket;
        }
    }
}