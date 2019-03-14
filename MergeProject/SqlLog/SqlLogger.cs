using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLog
{
    public class SqlLogger : ICHDUStorage
    {
        public Task AddAuthIdSet(ChduMessageHeader header, string Authentication, string Identification)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAuthIdSet(string cashRegisterCode, object set)
        {
            throw new NotImplementedException();
        }

        public Task AddLocationDataMessageRequest(ChduMessageHeader header, string DataMessage)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddLocationDataMessageRequest(string cashRegisterCode, DateTime currentDate, int locationId, string DataMessage)
        {
            throw new NotImplementedException();
        }

        public Task AddLocationDataMessageResponse(ChduMessageHeader header, string DataMessage)
        {
            throw new NotImplementedException();
        }

        public Task AddLocationDataMessageResponse(string cashRegisterCode, DateTime currentDate, int locationId, string DataMessage)
        {
            throw new NotImplementedException();
        }

        public Task AddReceiptDataMessageRequest(ChduMessageHeader header, string DataMessage)
        {
            throw new NotImplementedException();
        }

        public Task AddReceiptDataMessageRequest(string cashRegisterCode, DateTime createDate, int receiptNumber, string DataMessage)
        {
            throw new NotImplementedException();
        }

        public Task AddReceiptDataMessageResponse(string cashRegisterCode, DateTime createDate, int receiptNumber, string DataMessage)
        {
            throw new NotImplementedException();
        }

        public Task AddReceiptPrintout(ChduMessageHeader header, string Printout)
        {
            throw new NotImplementedException();
        }

        public Task AddReceiptPrintout(string cashRegisterCode, DateTime createDate, int receiptNumber, string Printout)
        {
            throw new NotImplementedException();
        }

        public Task AddTextPrintout(ChduMessageHeader header, string Printout)
        {
            throw new NotImplementedException();
        }

        public Task AddTextPrintout(string Printout)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetAuthIdSet(string CashRegisterCode, int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<object>> GetAuthIdSets(string CashRegisterCode)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetBinaryImage()
        {
            throw new NotImplementedException();
        }

        public Task GetBinaryImage(Stream stream)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetFirmwareVersion()
        {
            throw new NotImplementedException();
        }

        public Task<byte[][]> GetLocationMessages(string CashRegisterCode, DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetLocationMessages(string CashRegisterCode, DateTime From, DateTime To, Stream stream)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetReceiptDataMessage(string CashRegisterCode, DateTime Date, int ReceiptNumber)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<object>> GetReceiptDataMessages(string cashRegisterCode, DateTime createDate, int receiptNumber)
        {
            throw new NotImplementedException();
        }

        public Task<byte[][]> GetSentReceiptMessages(string CashRegisterCode, DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetSentReceiptMessages(string CashRegisterCode, DateTime From, DateTime To, Stream stream)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSerialNumber()
        {
            throw new NotImplementedException();
        }

        public Task<StorageCapacity> GetStorageCapacity()
        {
            throw new NotImplementedException();
        }

        public Task<byte[][]> GetTextPrintout(string CashRegisterCode, DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetUnsendLocationMessages(string cashRegisterCode)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetUnsendReceiptMessages(string cashRegisterCode)
        {
            throw new NotImplementedException();
        }

        public Task<byte[][]> GetUnsentReceiptMessages(string CashRegisterCode, DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<string>> ICHDUStorage.GetTextPrintout(string CashRegisterCode, DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }
    }
}
