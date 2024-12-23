The Factory Design Pattern is a creational design pattern that provides an interface for creating objects in a superclass, 
but allows subclasses to alter the type of objects that will be created.

Components:
	1. Interface (INotification):Ensures a common contract for all notification types.
	2. Concrete Classes (EmailNotification, SmsNotification, PushNotification):Provide specific implementations for different notification types.
	3. Factory (NotificationFactory):Encapsulates the logic of object creation. Returns the appropriate object based on input.
	4. The client doesn’t directly create objects. It asks the factory to create the appropriate object.



Benefits
	1. Encapsulation: The object creation logic is hidden from the client.
	2. Flexibility: The client code is not tightly coupled to specific classes or their instantiation.
	3. Reusability: You can reuse the factory to create different objects without modifying the client code.
	4. Maintainability: Adding new object types becomes easier without changing existing code.

When to Use the Factory Pattern
	1. The client code needs to be decoupled from the creation of objects.
	2. The specific type of object to create is determined at runtime.
	3. A class cannot anticipate which class to instantiate.
	4. Object creation is complex or involves multiple steps.



Use Case: Real-Life Applications
	1. Graphical Applications: Creating different UI components like buttons, textboxes, or icons.
	2. Game Development: Generating different characters or objects in the game world.
	3.Document Generation: Producing different types of charts (e.g., pie charts, bar charts, line charts).


What Happens Here?
1.The client only interacts with the factory (NotificationFactory) and the interface (INotification).
2.The factory decides which concrete class (EmailNotification or SmsNotification) to instantiate based on input.
3.If new notification types are added (e.g., PushNotification), the client code doesn’t need to change.


use Case:
- When creating objects involves complex logic or configuration (e.g., database connections, logging mechanisms).
- When you need to create families of related or dependent objects without specifying their concrete classes (can be extended to Abstract Factory).
- Systems where the exact type of object is determined dynamically (e.g., based on user input or configuration).


Analogy
Think of a factory that manufactures products. For example:

- A car factory can produce different types of cars (e.g., sedans, SUVs, or trucks).
- The client (buyer) doesn't directly assemble the car. Instead, they specify what they need (e.g., "SUV"), 
   and the factory decides how to produce it and returns the desired car.
