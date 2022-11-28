using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq1
{
    [Theory(DisplayName = "Deve cadastrar um evento com o construtor completo")]
    [InlineData("Jogo da Copa", "2022-11-28", "Brasil vs Suiça")]
    public void TestEventFullConstructor(string title, string date, string description)
    {
        var newEvent = new Event(title, date, description);
        newEvent.Title.Should().Be(title);
        newEvent.EventDate.Should().Be(DateTime.Parse(date));
        newEvent.Description.Should().Be(description);
    }

    [Theory(DisplayName = "Deve cadastrar um evento com o construtor sem descrição")]
    [InlineData("Jogo da Copa", "2022-11-28")]
    public void TestEventHalfConstructor(string title, string date)
    {
        var newEvent = new Event(title, date);
        newEvent.Title.Should().Be(title);
        newEvent.EventDate.Should().Be(DateTime.Parse(date));   
    }

    [Theory(DisplayName = "Deve atrasar a data de um evento corretamente")]
    [InlineData("Jogo da Copa", "2022-11-28", 2, "2022-11-30")]
    public void TestEventDelayDate(string title, string date, int days, string expected)
    {
        var newEvent = new Event(title, date);
        newEvent.DelayDate(days);
        newEvent.EventDate.Should().Be(DateTime.Parse(expected));
        
    }

    [Theory(DisplayName = "Deve imprimir um evento corretamente")]
    [InlineData()]    
    public void TestPrintEvent(string title, string date, string description, string format, string expected)
    {
        throw new NotImplementedException(); 
    }
    
    
}