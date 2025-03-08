#Problem statement#

Implement a Low level design of Parking lot.

###Requirements###
1. Parking lot will have multiple floors.
2. Parking lot will have different types of parking spots (ex- Bike, Compact cars, Big vehicle, Electric car, electric bike, Truck)
3. Parking lot will have priority slots for handicapped/Pregnant
4. Parking lot will have multiple entry and exits.
5. Parking lot will have multiple payment options(Card, Cash, or Pass) 
6. Availability count should be displayed at entry. Should display free spots for each spot type.
7. User will take ticket at the entry from parking agent.
8. User should be able to pay at automated exit or to the parking agent at exit.
9. Payment should have hourly and daily charges rates. (first hour - 50, following hours 30 ) (First day - 300, following days - 200) - different for each vehicle category  
10. System should not allow vehicle more then capacity.


###List down proper nouns###
- Admin
- System
- User
- Agent

- Vehicle 
    Car 
    Bike
    Van
    Truck
    Electric Car
    Electric Bike

- Payment
- Rate
- Cash
- Card
- Pass
- Ticket

- Parking Lot
- Floor
- Spot
- Entry
- Exit
- Capacity

###Activities###
Admin
- add floors
- add/remove spaces
- add payment methods
- add/update rates
- add/update exit/entry

Agent
- Issue a ticket at entry
- Pay against ticket at exit

Customer
- Issue ticket at entry
- Pay against ticket at exit
- park vehicle at spot
- Pay via Card or Cash

System
- Assign spot to vehicle
- Display free spots
- generate bill



###Class Diagram###



Customer              
- - Take ticket                              
- - Scan ticket
- - Pay ticket 
- - Park Vehicle  

Ticket
- Id
- entry time
- Vehicle type
- Vehicle number
- Parking Spot
- Amount
- Payment
- - Show Due
- - Pay Due

Payment
- Amount
- Status
- time
- - Calculate

Cash <- Payment

Credit <- Payment

Parking Rate
- Hours
- Rate
- - Calculate

Vehicle
- Number
- VehicleType

VehicleType*
- Bike
- Electric Bike
- Car
- Electric Car
- Truck
- Van


Agent 
- - Take ticket
- - Scan ticket

Admin
- - Add Floors
- - Add Entry
- - Add Exit
- - Add/Update Rates
- - Add Spot

Parking Spot
- Large
- Compact
- Bike
- Handicapped


Parking Floor
- Number
- Availability
- - UpdateAvailability



System

- - Assign Vehicle to spot
- - Show availability
