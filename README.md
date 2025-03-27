🚀 Getting Started
1. Clone the Repository
git clone https://github.com/jgohel9902/UnitTesting.git

3. Open the Solution
Open Assignment2.sln in Visual Studio.

4. Build and Run
Press Ctrl + F5 to build and run the application.

🔬 Running Unit Tests
Open the Test Explorer in Visual Studio.

Run the unit tests to ensure that all tests pass.

📊 Git Repository Info
The .gitignore file ensures that unnecessary files such as bin/, obj/, and .vs/ folders are ignored in the repository.

The main branch contains all the committed changes and updates.




🧪 Unit Test Cases in RectangleTests.cs
The following test cases ensure the correctness of the Rectangle class:

✅ Constructor_ShouldInitialize_WithValidValues

Verifies that the constructor initializes width and height correctly with valid values.


❌ Constructor_ShouldThrowException_WhenNegativeValuesProvided

Ensures that the constructor throws an exception if negative width or height is provided.


📏 GetArea_ShouldReturn_CorrectArea

Confirms that the GetArea() method returns the correct area of the rectangle.


📐 GetPerimeter_ShouldReturn_CorrectPerimeter

Checks if the GetPerimeter() method returns the correct perimeter.


🔄 SetWidth_ShouldUpdate_WidthValue

Validates that setting the Width property updates the width correctly.


🔄 SetHeight_ShouldUpdate_HeightValue

Ensures that setting the Height property updates the height correctly.


🚫 Constructor_ShouldThrowException_WhenZeroWidthProvided

Verifies that zero width triggers an exception in the constructor.


🚫 Constructor_ShouldThrowException_WhenZeroHeightProvided

Ensures that zero height triggers an exception in the constructor.
