﻿using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLogger
{
    public class FileLog : ICHDUStorage
    {
        public Task AddAuthIdSet(ChduMessageHeader header, string Authentication, string Identification)
        {
            throw new NotImplementedException();
        }

        public Task AddLocationDataMessageRequest(ChduMessageHeader header, string DataMessage)
        {
            throw new NotImplementedException();
        }

        public Task AddLocationDataMessageResponse(ChduMessageHeader header, string DataMessage)
        {
            throw new NotImplementedException();
        }

        public Task AddReceiptDataMessageRequest(ChduMessageHeader header, string DataMessage)
        {
            throw new NotImplementedException();
        }

        public Task AddReceiptPrintout(ChduMessageHeader header, string Printout)
        {
            throw new NotImplementedException();
        }

        public Task AddTextPrintout(ChduMessageHeader header, string Printout)
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

        public Task<string> GetFirmwareVersion()
        {
            throw new NotImplementedException();
        }

        public Task<byte[][]> GetLocationMessages(string CashRegisterCode, DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetReceiptDataMessage(string CashRegisterCode, DateTime Date, int ReceiptNumber)
        {
            throw new NotImplementedException();
        }

        public Task<byte[][]> GetSentReceiptMessages(string CashRegisterCode, DateTime From, DateTime To)
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

        public Task<byte[][]> GetUnsentReceiptMessages(string CashRegisterCode, DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }
    }
}
