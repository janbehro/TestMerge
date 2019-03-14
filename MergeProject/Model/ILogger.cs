using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// ICHDUStorage interface
    /// </summary>
    public interface ICHDUStorage
    {
        /// <summary>
        /// Add authentication and identity info
        /// </summary>
        /// <param name="cashRegisterCode"></param>
        /// <param name="set"></param>
        /// <returns>new AuthIdSet Id</returns>
        Task<int> AddAuthIdSet(string cashRegisterCode, object set);

        /// <summary>
        /// Returns all authentication set for parameters
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <returns></returns>
        Task<IEnumerable<object>> GetAuthIdSets(string CashRegisterCode);


        /// <summary>
        /// Adds receipt data message to the storage
        /// </summary>
        /// <param name="header">Message header</param>
        /// <param name="DataMessage">Serialized message data</param>
        Task AddReceiptDataMessageRequest(string cashRegisterCode, DateTime createDate, int receiptNumber, string DataMessage);

        /// <summary>
        /// Adds receipt data message to the storage
        /// </summary>
        /// <param name="header">Message header</param>
        /// <param name="DataMessage">Serialized message data</param>
        Task AddReceiptDataMessageResponse(string cashRegisterCode, DateTime createDate, int receiptNumber, string DataMessage);

        /// <summary>
        /// Returns the first data message for the receipt (used for copy printing)
        /// </summary>
        /// <param name="header">Message header</param>
        Task<string> GetReceiptDataMessage(string cashRegisterCode, DateTime createDate, int receiptNumber);

        /// <summary>
        /// Returns all data messages related to parameters
        /// </summary>
        /// <param name="cashRegisterCode"></param>
        /// <param name="createDate"></param>
        /// <param name="receiptNumber"></param>
        /// <returns></returns>
        Task<IEnumerable<object>> GetReceiptDataMessages(string cashRegisterCode, DateTime createDate, int receiptNumber);
        /// <summary>
        /// Returns all unsend messages
        /// </summary>
        /// <param name="cashRegisterCode"></param>
        /// <returns></returns>
        Task<IEnumerable<string>> GetUnsendReceiptMessages(string cashRegisterCode);

        /// <summary>
        /// Adds location message request to the storage
        /// </summary>
        /// <param name="cashRegisterCode"></param>
        /// <param name="date"></param>
        /// <param name="locationId">If 0, generate Id</param>
        /// <param name="DataMessage"></param>
        /// <returns></returns>
        Task<int> AddLocationDataMessageRequest(string cashRegisterCode, DateTime currentDate, int locationId, string DataMessage);

        /// <summary>
        /// Adds location message response to the storage
        /// </summary>
        /// <param name="cashRegisterCode"></param>
        /// <param name="currentDate"></param>
        /// <param name="locationId"></param>
        /// <param name="DataMessage">DataMessage XML</param>
        Task AddLocationDataMessageResponse(string cashRegisterCode, DateTime currentDate, int locationId, string DataMessage);

        /// <summary>
        /// Vráti všetky neodoslané správy 
        /// </summary>
        /// <param name="cashRegisterCode"></param>
        /// <returns></returns>
        IEnumerable<string> GetUnsendLocationMessages(string cashRegisterCode);

        /// <summary>
        /// Adds text printout to the storage
        /// </summary>
        /// <param name="Printout"></param>
        /// <returns></returns>
        Task AddTextPrintout(string Printout);

        /// <summary>
        /// Adds text printout to the storage and pair printout to receipt
        /// </summary>
        /// <param name="cashRegisterCode"></param>
        /// <param name="createDate"></param>
        /// <param name="receiptNumber"></param>
        /// <param name="Printout"></param>
        /// <returns></returns>
        Task AddReceiptPrintout(string cashRegisterCode, DateTime createDate, int receiptNumber, string Printout);

        /// <summary>
        /// Returns capacity information
        /// </summary>
        /// <returns>Returns total and available capacity in bytes</returns>
        Task<StorageCapacity> GetStorageCapacity();

        /// <summary>
        /// Get CHDU's serial number
        /// </summary>
        /// <returns></returns>
        Task<string> GetSerialNumber();

        /// <summary>
        /// Get CHDU's frimware version
        /// </summary>
        /// <returns></returns>
        Task<string> GetFirmwareVersion();

        /// <summary>
        /// Gets CHDU's binary image
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        Task GetBinaryImage(Stream stream);

        /// <summary>
        /// Returns all send receipt messages
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="From">From</param>
        /// <param name="To">To</param>
        /// <returns></returns>
        Task<IEnumerable<string>> GetSentReceiptMessages(string CashRegisterCode, DateTime From, DateTime To, Stream stream);

        /// <summary>
        /// Returns all text printouts
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="From">From</param>
        /// <param name="To">To</param>
        /// <returns></returns>
        Task<IEnumerable<string>> GetTextPrintout(string CashRegisterCode, DateTime From, DateTime To);

        /// <summary>
        /// Get all location messages
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="From"></param>
        /// <param name="To"></param>
        /// <returns></returns>
        Task<IEnumerable<string>> GetLocationMessages(string CashRegisterCode, DateTime From, DateTime To, Stream stream);
    }

    public class StorageCapacity
    {
        public long Capacity { get; set; }
        public long AvailableCapacity { get; set; }
    }
    [Obsolete]
    public class ChduMessageHeader
    {
        public string CashRegisterCode { get; set; }
        public DateTime DateTime { get; set; }
        public int ReceiptNumber { get; set; }
        public int AuthId { get; set; }
    }
}
