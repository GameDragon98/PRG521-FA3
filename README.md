# Zoo Management System

## Overview

The Zoo Management System is a software application designed to facilitate the management of a zoo's animal collection. It provides functionalities for adding new animals to the zoo, interacting with existing animals, and learning about their behaviors. The application is built using C# and .NET Framework.

## Design Decisions

### Object-Oriented Design

The system is designed using object-oriented principles to model real-world entities as objects. Each animal is represented as an object of a specific class, allowing for easy management and interaction.

### Inheritance

Inheritance is a fundamental concept utilized in this project to establish a hierarchical relationship between different types of animals and their common attributes and behaviors. The `Animal` class serves as the base class (parent) for all animals, encapsulating properties such as `Name`, `Age`, and `Type`, as well as methods for eating, sleeping, and making sounds. Specific animal types such as `Lion`, `Parrot`, and `Turtle` inherit from the `Animal` class, inheriting its properties and methods while also providing the flexibility to define their own unique behaviors.

### Polymorphism

Polymorphism is a key principle employed through method overriding in derived classes. Each animal type overrides the virtual methods defined in the base `Animal` class to specify its unique behaviors. For example, the `Eat`, `Sleep`, and `Speak` methods are overridden in the `Lion`, `Parrot`, and `Turtle` classes to define their specific eating, sleeping, and communication behaviors. This approach allows for the same method names to be used across different animal types while exhibiting different behaviors based on the specific type of animal, enabling code reuse and flexibility.

### Interfaces

Interfaces are utilized in the project to define contracts for common behaviors that can be implemented by different animal types. For example, the `IMovable` interface defines a `Move` method, while the `IFeedable` interface defines a `Feed` method. Animal classes such as `Lion`, `Parrot`, and `Turtle` implement these interfaces to specify their feeding and movement behaviors, allowing for polymorphic behavior and enabling the application to interact with animals in a consistent manner.

## Method Usage

### Animal Class

- `Eat(StringBuilder sb)`: Simulates the eating behavior of an animal.
- `Sleep(StringBuilder sb)`: Simulates the sleeping behavior of an animal.
- `Speak(StringBuilder sb)`: Simulates the vocalization behavior of an animal.
- `DisplayInfo(StringBuilder sb)`: Displays information about the animal, including its name, age, and behaviors.

### Lion, Parrot, Turtle Classes

- `Eat(StringBuilder sb)`: Overrides the base method to specify each animal's eating behavior.
- `Sleep(StringBuilder sb)`: Overrides the base method to specify each animal's sleeping behavior.
- `Speak(StringBuilder sb)`: Overrides the base method to specify each animal's vocalization behavior.
- `Speak()`: Overrides the base method to play a sound specific to each animal.

### Zoo Class

- `AddAnimal(Animal animal)`: Adds a new animal to the zoo and categorizes it based on its type.
- `GetLions()`, `GetParrots()`, `GetTurtles()`: Retrieves lists of lions, parrots, and turtles stored in the zoo.
- `DisplayAnimalInfo(Animal SelectedAnimal)`: Displays information about a selected animal.

## Running the Executable (exe) File

To run the Zoo Management System application, follow these steps:

1. Navigate to the `bin\Debug\net8.0-windows` folder in the project directory.
2. Locate the `ZooManagementSystem.exe` file.
3. Double-click the `ZooManagementSystem.exe` file to run the application.

Upon launching the application, you will be presented with a user interface that allows you to perform various actions such as adding new animals to the zoo, interacting with existing animals, and learning more about their behaviors. Follow the on-screen instructions to navigate through the application and explore its features.

## Expected Errors

While every effort has been made to ensure the stability and functionality of the application, there may be some expected errors or edge cases, including:

1. Input validation errors: Ensure all required fields are filled out correctly when adding new animals.
2. File path errors: If the audio files for animal sounds are missing or inaccessible, sound playback may fail.
3. Compatibility issues: Ensure that the application is run on a compatible platform with the necessary dependencies installed.

## Future Implementations

Some potential future implementations and enhancements for the Zoo Management System include:

1. Conversion to a desktop application: Enhance the user interface and functionality to create a more intuitive and feature-rich desktop application.
2. Integration with external APIs: Incorporate features such as real-time weather updates, animal conservation information, and educational resources from external APIs.
3. Database integration: Implement database storage to persist zoo data, allowing for data retrieval, updating, and querying.
4. User authentication and authorization: Add user accounts and roles to control access to certain features and functionalities within the application.
5. Automated testing: Develop and implement automated test cases to ensure the reliability and robustness of the application.

## Credits

Developer: [Jandré van Zyl]
GitHub Repository: [https://github.com/GameDragon98/PRG521-FA3]
