The Facade Design Pattern is a structural design pattern that provides a simplified interface to a larger and more complex subsystem. 
It hides the complexity of the subsystem and exposes only what is necessary for the client.

When to Use the Facade Pattern
1. Simplifying Client Interaction:When you want to provide a unified and simplified interface to a complex subsystem.

	Scenario: Online Shopping
	Online shopping involves multiple subsystems:

	Inventory System to check product availability.
	Payment Gateway to process payments.


2. Decoupling:When you need to decouple the client code from the implementation details of a subsystem.
   
   A media player interacts with multiple components:
	Audio Player
	Video Player
	Subtitles Manager
 
3. Legacy Systems:When working with complex or legacy systems, the facade can act as a wrapper to modernize the interaction.
					
	Scenario: Banking System
     A banking application needs to interact with an old legacy system for:
		
	Account Management
    Transaction Processing
    Notifications

4. Reducing Dependency:When multiple components of a system interact with the same complex subsystem, a facade can reduce tight coupling.
   
    Scenario: Hotel Management System
    Multiple systems interact with the same subsystem:

    Reservation System
    Billing System
    Housekeeping System



How to Use the Facade Pattern
1. Identify the complex subsystem that needs simplification.
2.Create a facade class that acts as an interface between the client and the subsystem.
3. The facade class should delegate calls to the subsystem components internally.


Key Benefits
1. Simplification:The client doesn’t need to know the details of how the subsystems work.
2. Decoupling:The facade acts as a mediator, reducing dependencies between the client and the subsystems.
3. Ease of Use: A single method (WatchMovie) encapsulates the behavior of multiple subsystem methods.



Other Real-Life Examples
	Banking System:
	  A customer interacts with a bank teller (facade) instead of directly dealing with backend operations like withdrawals, deposits,
	  or account queries.
	

   Car Service:
      A service advisor (facade) handles requests for maintenance, repairs, and billing, instead of customers interacting 
	  with mechanics or spare parts departments.


//--------------------------------------------------------------------------------------------------------------------------------------------
How the Repository Pattern Aligns with the Facade Pattern
Facade Characteristics:

A facade simplifies access to a complex subsystem.
	It provides a unified and simplified interface to the client, hiding implementation details.
	Repository Characteristics:

A repository provides a simplified abstraction over the data access layer.
	It encapsulates data access logic, allowing the client to interact with the data source (e.g., database) 
	without dealing with the intricacies of querying or managing connections.


