using MockBankApi.Models;
using System.Net;

namespace MockBankApi.Services
{
    public class AccountService : IAccountService
    {


        List<Staging> Accounts = new List<Staging>
            {
                new Staging { Id =  new Guid("933dda97-6617-4da0-86e8-a1fa5c63da19") ,
                 AccountNumber  = "1590572512",
                 AccountName = "Tomiloba Maryam",
                 Address = "3 Fair View Appartment, Dolphin Estate",
                 City = "Ikoyi",
                State = "Lagos",
                Currency = "Naira",
                CumulativeInflow = 5075.00
                },
                  new Staging { Id =  new Guid("509b9d3a-bc4f-4ef9-948b-97597e0bf28b") ,
                 AccountNumber  = "3121784323",
                 AccountName = "Jadesola Ehigiator",
                 Address = "Shop 53 Block C, Mabushi Altra Modern Market",
                  City = "Mabushi",
                State = "Abuja",
                Currency = "Naira",
                CumulativeInflow = 502300.00
                },
                   new Staging { Id =  new Guid("34cc335c-b0c3-4eac-b0a7-5aa99497f922") ,
                 AccountNumber  = "0405772257",
                 AccountName = "Ireti Osuagwu",
                 Address = "1649A,4th Avenue",
                 City = "Festac Town",
                State = "Lagos",
                Currency = "Naira",
                CumulativeInflow = 0.00
                },
                   new Staging { Id =  new Guid("1dab465c-9b6f-4314-a935-cc7d6b94cee6") ,
                 AccountNumber  = "2080766748",
                 AccountName = "Adeboye Nojeem",
                 Address = "Akanbi Adeniran Street,Oko Oba",
                  City = "Agege",
                State = "Lagos",
                Currency = "Naira",
                CumulativeInflow = 700.00
                },
                  new Staging { Id =  new Guid("f3fd7242-654e-40fa-ba24-a1d2cf937a0a") ,
                 AccountNumber  = "07247533310",
                 AccountName = "Ebiowei Adewura",
                 Address = " Block C, Ultra Modern Market, Garki Ii",
                  City = "Fct",
                State = "Abuja",
                Currency = "Naira",
                CumulativeInflow = 2.00
                },
                   new Staging { Id =  new Guid("cd4ba6f4-4abf-4550-b753-b49458db301d") ,
                 AccountNumber  = "3121234079",
                 AccountName = "Abisola Saheed",
                 Address = "5, Ifelodun Street",
                  City = "Olugbode Town",
                State = "  Ibadan South West",
                Currency = "Naira",
                CumulativeInflow = 400.00
                },
                   new Staging { Id =  new Guid("618cfe61-4acc-4969-aa66-2a6f17fabc09") ,
                 AccountNumber  = "0405171001",
                 AccountName = "Kayode Obianuju",
                 Address = "Dolphin Estate",
                  City = "Ajah",
                State = "Lagos",
                Currency = "Naira",
                CumulativeInflow = 5000
                },
                 new Staging { Id =  new Guid("9170187f-4384-4510-8ae4-3cd2d9f8c9a7") ,
                 AccountNumber  = "2080125745",
                 AccountName = "Tope Oyelude",
                 Address = " 3 Nworgu St Rumuomasi",
                  City = "Port Harcourt",
                State = "Rivers",
                Currency = "Naira",
                CumulativeInflow = 5000
                },
                  new Staging { Id =  new Guid("fcec5278-066f-4f8e-a8b8-a47c3f5ee454") ,
                 AccountNumber  = "0724829293",
                 AccountName = "Bankole Olasunkanmi",
                 Address = "Sokode Crescent, Zone 5, Wuse",
                  City = "Fct",
                State = " Abuja",
                Currency = "Naira",
                CumulativeInflow = 5000
                },

            };
        public List<Staging> GetAccountService()
        {    
            return Accounts;       
        }

        public Staging GetAccountById(Guid stagingId)
        {
            return Accounts.FirstOrDefault(x => x.Id == stagingId);
        }
    }
}
