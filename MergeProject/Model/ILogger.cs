using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ICHDUStorage
    {
        /// <summary>
        /// Adds receipt data message to the storage
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="Date">Date</param>
        /// <param name="ReceiptNumber">Receipt number</param>
        /// <param name="DataMessage">DataMessage XML</param>
        //Task AddReceiptDataMessageRequest(DocumentType JSON, string xml)
        Task AddReceiptDataMessageRequest(ChduMessageHeader header, string DataMessage);

        /// <summary>
        /// Returns the first data message for the receipt
        /// </summary>
        /// <param name="CashRegisterCode"></param>
        /// <param name="Date"></param>
        /// <param name="ReceiptNumber"></param>
        /// <returns></returns>
        Task<string> GetReceiptDataMessage(string CashRegisterCode, DateTime Date, int ReceiptNumber);

        /// <summary>
        /// Adds location message request to the storage
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="Date">Date</param>
        /// <param name="DataMessage">DataMessage XML</param>
        Task AddLocationDataMessageRequest(ChduMessageHeader header, string DataMessage);

        /// <summary>
        /// Adds location message response to the storage
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="Date">Date</param>
        /// <param name="DataMessage">DataMessage XML</param>
        Task AddLocationDataMessageResponse(ChduMessageHeader header, string DataMessage);

        /// <summary>
        /// Adds text printout to the storage
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="Date">Date</param>
        /// <param name="Printout"></param>
        Task AddTextPrintout(ChduMessageHeader header, string Printout);

        /// <summary>
        /// Adds text printout to the storage
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="Date">Date</param>
        /// <param name="Printout"></param>
        Task AddReceiptPrintout(ChduMessageHeader header, string Printout);

        /// <summary>
        /// Add authentication and identity info
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="Authentication">Authentication data</param>
        /// <param name="Identification">Identification information</param>
        /// <param name="Id">Id</param>
        /// <param name="UploadDate">UpladDate</param>
        Task AddAuthIdSet(ChduMessageHeader header, string Authentication, string Identification);

        /// <summary>
        /// Returns authentication set by parameters
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="Authentication">Authentication</param>
        /// <param name="Identification">Identification</param>
        /// <param name="Id">Id</param>
        /// <returns></returns>
        Task<object> GetAuthIdSet(string CashRegisterCode, int Id);

        /// <summary>
        /// Returns all authentication set for parameters
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="Authentication">Authentication</param>
        /// <param name="Identification">Identification</param>
        /// <returns></returns>
        Task<IEnumerable<object>> GetAuthIdSets(string CashRegisterCode);

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
        /// <returns></returns>
        Task<byte[]> GetBinaryImage();

        /// <summary>
        /// Returns all send receipt messages
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="From">From</param>
        /// <param name="To">To</param>
        /// <returns></returns>
        Task<byte[][]> GetSentReceiptMessages(string CashRegisterCode, DateTime From, DateTime To);

        /// <summary>
        /// Returns unsent receipt messages
        /// </summary>
        /// <param name="CashRegisterCode">ChasRegisterCode</param>
        /// <param name="From">From</param>
        /// <param name="To">To</param>
        /// <returns></returns>
        Task<byte[][]> GetUnsentReceiptMessages(string CashRegisterCode, DateTime From, DateTime To);

        /// <summary>
        /// Returns all text printouts
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="From">From</param>
        /// <param name="To">To</param>
        /// <returns></returns>
        Task<byte[][]> GetTextPrintout(string CashRegisterCode, DateTime From, DateTime To);

        /// <summary>
        /// Get all location messages
        /// </summary>
        /// <param name="CashRegisterCode">CashRegisterCode</param>
        /// <param name="From"></param>
        /// <param name="To"></param>
        /// <returns></returns>
        Task<byte[][]> GetLocationMessages(string CashRegisterCode, DateTime From, DateTime To);
    }

    public class StorageCapacity
    {
        public long Capacity { get; set; }
        public long AvailableCapacity { get; set; }
    }

    public class ChduMessageHeader
    {
        public string CashRegisterCode { get; set; }
        public DateTime DateTime { get; set; }
        public int ReceiptNumber { get; set; }
        public int AuthId { get; set; }
    }
}
