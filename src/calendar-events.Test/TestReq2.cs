using Xunit;
using FluentAssertions;
using calendar_events;
using System;

namespace calendar_events.Test;

public class TestReq2
{
    [Theory(DisplayName = "Deve procurar um evento por titulo")]
    [InlineData("Jogo da Copa", "2022-11-28", "Brasil vs Suiça", 0)]
    public void TestListSearchByTitle(string title, string date, string description,int expected)
    {
        var newEvent = new Event(title, date, description);
        var eventList = new EventList();

        eventList.Add(newEvent);

        eventList.SearchByTitle(title).Should().Be(expected);
    }

    [Theory(DisplayName = "Deve procurar um evento por data")]
    [InlineData("Jogo da Copa", "2022-11-28", "Brasil vs Suiça", 0)]
    public void TestListSearchByDate(string title, string date, string description, int expected)
    {
        var newEvent = new Event(title, date, description);
        var eventList = new EventList();

        eventList.Add(newEvent);

        eventList.SearchByDate(date).Should().Be(expected);
    }

    
}