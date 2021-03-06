using EventBus.Contracts.Commands;
using EventBus.Contracts.Common;
using EventBus.Contracts.DTO;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace Sensor.API.EventBus.Produsers
{
    /// <summary>
    /// Define producer of commands to process telemetry data (records).
    /// </summary>
    public class ProcessDataProducer : ICommandProducer<IProcessData, IRecordDTO> 
    {
        private readonly IBusControl _bus;

        /// <summary>
        /// Constructor of "process data" commands producer.
        /// </summary>
        /// <param name="bus">Event bus.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ProcessDataProducer(IBusControl bus) => _bus = bus ?? throw new ArgumentNullException(nameof(bus));

        /// <inheritdoc/>
        /// <param name="record">Record data transfer object.</param>
        public async Task<bool> Send(IRecordDTO record)
        {
            try
            {
                await _bus.Send<IProcessData>(new
                {
                    CommandId = Guid.NewGuid(),
                    Record = record,
                    CreationDate = DateTime.Now,
                });
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}