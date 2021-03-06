using EventBus.Contracts.Commands;
using EventBus.Contracts.Common;
using EventBus.Contracts.DTO;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace DataProcessor.API.EventBus.Produsers
{
    /// <summary>
    /// Define class to send commands to event bus for data processing report registration.
    /// </summary>
    public class RegisterReportProducer : ICommandProducer<IRegisterReport, IReportDTO> 
    {
        private readonly IBusControl _bus;

        /// <summary>
        /// Constructor of command producer.
        /// </summary>
        /// <param name="bus">Event bus.</param>
        public RegisterReportProducer(IBusControl bus) => _bus = bus ?? throw new ArgumentNullException(nameof(bus));

        /// <inheritdoc/>
        /// <param name="report">Report data transfer object.</param>
        public async Task<bool> Send(IReportDTO report)
        {
            try
            {
                await _bus.Send<IRegisterReport>(new
                {
                    CommandId = Guid.NewGuid(),
                    Report = report,
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