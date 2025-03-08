1️ Singleton Pattern → Ensure only one instance of ParkingLot exists to manage parking operations.

2️ Factory Pattern → Create objects like Vehicle, ParkingSpot, and Ticket dynamically based on type.

3️ Strategy Pattern → Implement different parking fee calculation strategies (hourly, flat rate, etc.).

4️ Observer Pattern → Notify subscribed services (e.g., DisplayBoard, NotificationService) when parking status changes.

5️ Decorator Pattern → Add extra services like valet, premium parking, or EV charging dynamically to a parking spot.

6️ Command Pattern → Encapsulate user actions like ParkVehicle, UnparkVehicle, and ProcessPayment into separate commands for better control and undo/redo functionality.

7️ State Pattern → Manage ParkingSpot state changes (AVAILABLE → OCCUPIED → RESERVED).

8️ Adapter Pattern → Integrate third-party payment gateways without modifying core payment logic.

9️ Proxy Pattern → Control access to expensive operations like DatabaseService (caching queries for available parking spots).

10 Composite Pattern → Handle multiple parking floors and sections as a tree structure, where ParkingLot consists of multiple ParkingFloors, and each floor has multiple ParkingSpots.