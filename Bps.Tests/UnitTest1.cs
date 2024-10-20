using System;
using System.Diagnostics;
using System.Security.Principal;
using Xunit;



using Bps.APP;
 
namespace testRT
{ 
 

public class testingRNT
{
    [Fact]
    public void RunTotalmethodtest()
    {
       double tola = 0;
       double rata = 5;

        //Arrange
        double expected = 5;
        // Act
        double actual = Bps.APP.RunTotal.RunningTotal(tola,rata);
        

        //Assert
        Assert.Equal(expected, actual);
        
        

    }
}
}