namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Define_A_Class_Named_Person_That_Takes_Two_Parameters_FirstName_And_LastName_When_Its_Created(){
        var party = new Party();

        Assert.Equal(3, party.Guests.Length);
    }

    [Fact]
    public void Should_Create_A_Class_Level_Variable_Array_Named_Guests_That_Contains_Three_Instances_Of_The_Person_Class(){
         var party = new Party();

        Assert.Equal(3, party.Guests.Length);
        Assert.True(party.Guests[0].GetType() == typeof(Person));
        Assert.True(party.Guests[1].GetType() == typeof(Person));
        Assert.True(party.Guests[2].GetType() == typeof(Person));
    }
}