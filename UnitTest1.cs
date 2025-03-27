using System;
using Xunit;
using Assignment2;

public class RectangleTests
{
    // Test 1 : Constructor should initialize with valid values
    [Fact]
    public void Constructor_ShouldInitialize_WithValidValues()
    {
        var rectangle = new Rectangle(10, 5);
        Assert.Equal(10, rectangle.Width);
        Assert.Equal(5, rectangle.Height);
    }

    // Test 2 : Constructor should throw exception for negative values
    [Fact]
    public void Constructor_ShouldThrowException_WhenNegativeValuesProvided()
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(-5, 10));
    }

    // Test 3 : GetArea should return correct area
    [Fact]
    public void GetArea_ShouldReturn_CorrectArea()
    {
        var rectangle = new Rectangle(10, 5);
        double area = rectangle.GetArea();
        Assert.Equal(50, area);
    }

    // Test 4 : GetPerimeter should return correct perimeter
    [Fact]
    public void GetPerimeter_ShouldReturn_CorrectPerimeter()
    {
        var rectangle = new Rectangle(10, 5);
        double perimeter = rectangle.GetPerimeter();
        Assert.Equal(30, perimeter);
    }

    // Test 5: Setting width should update correctly
    [Fact]
    public void SetWidth_ShouldUpdate_WidthValue()
    {
        var rectangle = new Rectangle(10, 5);
        rectangle.Width = 15;
        Assert.Equal(15, rectangle.Width);
    }

    // Test 6: Setting height should update correctly
    [Fact]
    public void SetHeight_ShouldUpdate_HeightValue()
    {
        var rectangle = new Rectangle(10, 5);
        rectangle.Height = 20;
        Assert.Equal(20, rectangle.Height);
    }

    //  Test 7: Zero width should throw exception
    [Fact]
    public void Constructor_ShouldThrowException_WhenZeroWidthProvided()
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentException>(() => new Rectangle(0, 10));
    }

    //  Test 8: Zero height should throw exception
    [Fact]
    public void Constructor_ShouldThrowException_WhenZeroHeightProvided()
    { 
        Assert.Throws<ArgumentException>(() => new Rectangle(10, 0));
    }
}
