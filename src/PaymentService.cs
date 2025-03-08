namespace ParkingLotSystem
{
    public class PaymentService
    {
        private Dictionary<string, double> _paymentRecords = new();

        public bool ProcessPayment(ParkingTicket ticket, double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Payment failed: Invalid amount {amount} for Ticket ID: {ticket.TicketNumber}");
                return false;
            }

            _paymentRecords[ticket.TicketNumber] = amount;
            Console.WriteLine($"Payment of {amount} processed for Ticket ID: {ticket.TicketNumber}");
            return true;
        }

        public bool Refund(ParkingTicket ticket, double amount)
        {
            if (_paymentRecords.ContainsKey(ticket.TicketNumber) && _paymentRecords[ticket.TicketNumber] == amount)
            {
                _paymentRecords.Remove(ticket.TicketNumber);
                Console.WriteLine($"Refund of {amount} issued for Ticket ID: {ticket.TicketNumber}");
                return true;
            }

            Console.WriteLine($"Refund failed: No payment record found for Ticket ID: {ticket.TicketNumber}");
            return false;
        }
    }

}