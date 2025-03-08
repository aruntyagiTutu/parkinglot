namespace ParkingLotSystem
{
    public class ProcessPaymentCommand : ICommand
    {
        private PaymentService _paymentService;
        private ParkingTicket _ticket;
        private double _amount;
        private bool _paymentProcessed;

        public ProcessPaymentCommand(PaymentService paymentService, ParkingTicket ticket, double amount)
        {
            _paymentService = paymentService;
            _ticket = ticket;
            _amount = amount;
        }

        public void Execute()
        {
            _paymentProcessed = _paymentService.ProcessPayment(_ticket, _amount);
            Console.WriteLine(_paymentProcessed
                ? $"Payment of {_amount} successful for Ticket ID: {_ticket.TicketNumber}"
                : $"Payment failed for Ticket ID: {_ticket.TicketNumber}");
        }

        public void Undo()
        {
            if (_paymentProcessed)
            {
                _paymentService.Refund(_ticket, _amount);
                Console.WriteLine($"Undo: Payment of {_amount} refunded for Ticket ID: {_ticket.TicketNumber}");
            }
        }
    }
}