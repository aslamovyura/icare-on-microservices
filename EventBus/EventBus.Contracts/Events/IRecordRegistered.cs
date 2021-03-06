using EventBus.Contracts.Common;
using EventBus.Contracts.DTO;

namespace EventBus.Contracts.Events
{
    /// <summary>
    /// Define message interface for new record registration.
    /// </summary>
    public interface IRecordRegistered : IEvent
    {
        /// <summary>
        /// New record data transfer object.
        /// </summary>
        IRecordDTO Record { get; set; }
    }
}