using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConsoleLog().AddAuthIdSet(new ChduMessageHeader(), "", "");
        }
    }

    public class ConsoleLog : ICHDUStorage
    {
        public Task AddAuthIdSet(ChduMessageHeader header, string Authentication, string Identification) => Task.Run(() => { });

        public Task AddLocationDataMessageRequest(ChduMessageHeader header, string DataMessage) => Task.Run(() => { });

        public Task AddLocationDataMessageResponse(ChduMessageHeader header, string DataMessage) => Task.Run(() => { });

        public Task AddReceiptDataMessageRequest(ChduMessageHeader header, string DataMessage) => Task.Run(() => { });

        public Task AddReceiptPrintout(ChduMessageHeader header, string Printout) => Task.Run(() => { });

        public Task AddTextPrintout(ChduMessageHeader header, string Printout) => Task.Run(() => { });

        public Task<object> GetAuthIdSet(string CashRegisterCode, int Id) => Task.Run(() => new object());

        public Task<IEnumerable<object>> GetAuthIdSets(string CashRegisterCode)
        {
            throw new Exception();
        }

        public Task<byte[]> GetBinaryImage()
        {
            // implementation
            throw new NotImplementedException();
        }

        public Task<string> GetFirmwareVersion()
        {
            // implementation
            throw new NotImplementedException();
        }

        public Task<byte[][]> GetLocationMessages(string CashRegisterCode, DateTime From, DateTime To)
        {
            // implementation
            throw new NotImplementedException();
        }

        public Task<string> GetReceiptDataMessage(string CashRegisterCode, DateTime Date, int ReceiptNumber)
        {
            // implementation
            throw new NotImplementedException();
        }

        public Task<byte[][]> GetSentReceiptMessages(string CashRegisterCode, DateTime From, DateTime To)
        {
            // implementation
            throw new NotImplementedException();
        }

        public Task<string> GetSerialNumber()
        {
            // implementation
            throw new NotImplementedException();
        }

        public Task<StorageCapacity> GetStorageCapacity()
        {
            // implementation
            throw new NotImplementedException();
        }

        public Task<byte[][]> GetTextPrintout(string CashRegisterCode, DateTime From, DateTime To)
        {
            // implementation
            throw new NotImplementedException();
        }

        public Task<byte[][]> GetUnsentReceiptMessages(string CashRegisterCode, DateTime From, DateTime To)
        {
            // implementation
            throw new NotImplementedException();
        }
    }
}
